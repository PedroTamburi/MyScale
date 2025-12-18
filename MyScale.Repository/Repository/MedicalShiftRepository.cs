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
        // retorna os plantoes de um hospital especifico ordenado pela data de inicio 
        public List<MedicalShift> GetByHospitalId(int hospitalId)
        {
            return _context.Set<MedicalShift>()
                .Include(x => x.HealthAgent)
                .Where(p => p.HospitalId == hospitalId)
                .OrderByDescending(p => p.StartTime)
                .ToList();
        }

        // verifica se tem conflito de horario p um agente de saude em um dia especifico
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
        // libera todos os plantoes ligados a um agente de saude
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

        // retorna os plantoes de um agente especifico
        public List<MedicalShift> GetByHealthAgentId(int healthAgentId)
        {
            return _context.Set<MedicalShift>()
                .Include(x => x.Hospital)
                .Where(x => x.HealthAgentId == healthAgentId)
                .OrderBy(x => x.Date)
                .ToList();
        }

        // retorna os plantoes disp (onde healthAgentId é null)
        public List<MedicalShift> GetAvailableShifts()
        {
            return _context.Set<MedicalShift>()
                .Include(x => x.Hospital)
                .Where(x => x.HealthAgentId == null)
                .OrderBy(x => x.Date)
                .ToList();
        }

        // aceita um plantao por um agente de saude
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
    }
}