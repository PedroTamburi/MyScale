using MyScale.Domain.Entities;

namespace MyScale.Domain.Interfaces
{
    public interface IMedicalShiftRepository
    {
        Task<int> AddAsync(MedicalShift medicalShift);
        // buscar lista de plantões de um hospital específico
        Task<List<MedicalShift>> GetByHospitalIdAsync(int hospitalId);
        // buscar plantões disponíveis para o Agente 
        Task<List<MedicalShift>> GetAvailableShiftsAsync();
        // busca plantao pelo id
        Task<MedicalShift> GetByIdAsync(int id);
        // salva no banco
        Task UpdateAsync(MedicalShift medicalShift);
        // deleta plantao
        Task DeleteAsync(int id);
    }
    }

