using MyScale.Domain.Entities;

namespace MyScale.Domain.Interfaces
{
    public interface IMedicalShiftRepository
    {
        Task<int> AddAsync(MedicalShift medicalShift);
    }
}
