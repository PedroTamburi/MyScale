using MyScale.Domain.Base;
using MyScale.Domain.Entities;

namespace MyScale.Domain.Interfaces
{
    public interface IMedicalShiftRepository : IBaseRepository<MedicalShift>
    {
        Task<int> AddAsync(MedicalShift medicalShift); // retirar

        Task<List<MedicalShift>> GetByHospitalIdAsync(int hospitalId); // deixar

        bool HasTimeConflict(int agentId, DateOnly date, DateTime newStart, DateTime newEnd); // deixar

        List<MedicalShift> GetByHealthAgentId(int healthAgentId); // deixar
        
        void ReleaseShiftsByAgentId(int agentId); // deixar

        List<MedicalShift> GetAvailableShifts(); // deixar

        void AcceptShift(int shiftId, int healthAgentId); // deixar

        Task<MedicalShift> GetByIdAsync(int id); // retirar
        Task UpdateAsync(MedicalShift medicalShift); // retirar
        Task DeleteAsync(int id); // retirar

    }
    }

