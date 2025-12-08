using MyScale.Domain.Base;
using MyScale.Domain.Entities;

namespace MyScale.Service.Interfaces
{
    public interface IMedicalShiftService
    {
        Result<MedicalShift> Create(MedicalShift medicalShift);
    }
}