using Microsoft.EntityFrameworkCore;
using MyScale.Domain.Entities;
using MyScale.Domain.Interfaces;
using MyScale.Repository.Context;

namespace MyScale.Repository.Repository
{
    public class MedicalShiftRepository : IMedicalShiftRepository
    {
        private readonly MyScaleDbContext _context;

        public MedicalShiftRepository(MyScaleDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddAsync(MedicalShift medicalShift)
        {
            await _context.MedicalShifts.AddAsync(medicalShift);
            await _context.SaveChangesAsync();
            return medicalShift.Id;
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
        public async Task<List<MedicalShift>> GetAvailableShiftsAsync()
        {
            return await _context.MedicalShifts
                .Where(p => p.HealthAgentId == null)
                .OrderBy(p => p.StartTime)
                .ToListAsync();
        }
    }
}