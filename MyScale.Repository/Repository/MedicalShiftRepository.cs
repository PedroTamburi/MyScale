using Microsoft.EntityFrameworkCore;
using MyScale.Domain.Entities;
using MyScale.Domain.Interfaces;
using MyScale.Repository.Context;

namespace MyScale.Repository.Repository
{
    public class MedicalShiftRepository : BaseRepository<MedicalShift>, IMedicalShiftRepository
    {
        private readonly MyScaleDbContext _context;

        public MedicalShiftRepository(MyScaleDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> AddAsync(MedicalShift medicalShift)
        {
            await _context.MedicalShifts.AddAsync(medicalShift);
            await _context.SaveChangesAsync();
            return medicalShift.Id;
        }
        public bool HasTimeConflict(int agentId, DateOnly date, DateTime newStart, DateTime newEnd)
        {
            var plantoesDoDia = _context.Set<MedicalShift>()
                .Where(shift =>
                    shift.HealthAgentId == agentId &&
                    shift.Date == date &&
                    shift.Id != 0)
                .ToList(); 

            bool temConflito = plantoesDoDia.Any(shift =>
                newStart.TimeOfDay < shift.EndTime.TimeOfDay &&
                newEnd.TimeOfDay > shift.StartTime.TimeOfDay
            );

            return temConflito;
        }
        public void ReleaseShiftsByAgentId(int agentId)
        {
            var shifts = _context.Set<MedicalShift>()
                .Where(x => x.HealthAgentId == agentId)
                .ToList();
            
            foreach (var shift in shifts)
            {
                shift.HealthAgentId = null; 
            }

            _context.SaveChanges();
        }
        public List<MedicalShift> GetByHealthAgentId(int healthAgentId)
        {
            return _context.Set<MedicalShift>()
                .Include(x => x.Hospital) 
                .Where(x => x.HealthAgentId == healthAgentId) 
                .OrderBy(x => x.Date)
                .ToList();
        }
        // buscar lista de plantões de um hospital específico
        public async Task<List<MedicalShift>> GetByHospitalIdAsync(int hospitalId)
        {
            return await _context.MedicalShifts
                .Where(p => p.HospitalId == hospitalId)
                .OrderByDescending(p => p.StartTime)
                .ToListAsync();
        }

        // buscar plantões disponíveis para o Agente
        public List<MedicalShift> GetAvailableShifts()
        {
            return _context.Set<MedicalShift>()
                .Include(x => x.Hospital)
                .Where(x => x.HealthAgentId == null)
                .OrderBy(x => x.Date)
                .ToList();
        }
        // aceitar plantao pelo agente de saude
        public void AcceptShift(int shiftId, int healthAgentId)
        {
            var shift = _context.Set<MedicalShift>().Find(shiftId);

            if (shift != null)
            {
                shift.HealthAgentId = healthAgentId;

                _context.Update(shift);
                _context.SaveChanges();
            }
        }

        // buscar um plantão específico para editar
        public async Task<MedicalShift> GetByIdAsync(int id)
        {
            return await _context.MedicalShifts.FindAsync(id);
        }

        // salva as alterações no banco
        public async Task UpdateAsync(MedicalShift medicalShift)
        {
            _context.MedicalShifts.Update(medicalShift);
            await _context.SaveChangesAsync();
        }

        // deleta plantao
        public async Task DeleteAsync(int id)
        {
            var plantao = await _context.MedicalShifts.FindAsync(id);
            if (plantao != null)
            {
                _context.MedicalShifts.Remove(plantao);

                await _context.SaveChangesAsync();
            }
        }
    }
}