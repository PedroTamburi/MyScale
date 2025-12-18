using MyScale.Domain.Base;
using MyScale.Domain.Entities;

namespace MyScale.Domain.Interfaces
{
    public interface IMedicalShiftRepository : IBaseRepository<MedicalShift>
    {

        List<MedicalShift> GetByHospitalId(int hospitalId); // deixar

        bool HasTimeConflict(int agentId, DateOnly date, DateTime newStart, DateTime newEnd); // deixar

        List<MedicalShift> GetByHealthAgentId(int healthAgentId); // deixar
        
        void ReleaseShiftsByAgentId(int agentId); // deixar

        List<MedicalShift> GetAvailableShifts(); // deixar

        void AcceptShift(int shiftId, int healthAgentId); // deixar
    }
    }

