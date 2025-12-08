using FluentValidation;
using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using MyScale.Service.Interfaces;

namespace MyScale.Service.Services
{
    public class MedicalShiftService : IMedicalShiftService
    {
        private readonly IBaseRepository<MedicalShift> _repository;
        private readonly IValidator<MedicalShift> _validator;

        public MedicalShiftService(IBaseRepository<MedicalShift> repository, IValidator<MedicalShift> validator)
        {
            _repository = repository;
            _validator = validator;
        }

        public Result<MedicalShift> Create(MedicalShift medicalShift)
        {
            var validationResult = _validator.Validate(medicalShift);

            if (!validationResult.IsValid)
            {
                var errorMessage = validationResult.Errors.First().ErrorMessage;

                return Result<MedicalShift>.Failure(new Error("Validation.Error", errorMessage));
            }

            try
            {
                _repository.Insert(medicalShift);

                return Result<MedicalShift>.Success(medicalShift);
            }
            catch (Exception ex)
            {
                return Result<MedicalShift>.Failure(new Error("Database.Error", ex.Message));
            }
        }
    }
}