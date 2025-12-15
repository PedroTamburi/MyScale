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
    }
}