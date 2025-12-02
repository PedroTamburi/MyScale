using AutoMapper;
using FluentValidation;
using MyScale.Domain.Entities;

namespace MyScale.Service.Validators
{
    public class MedicalShiftValidator : AbstractValidator<MedicalShift>
    {
        public MedicalShiftValidator()
        {
            RuleFor(shift => shift.StartTime)
                .NotEmpty().WithMessage("Start time is required.")
                .LessThan(shift => shift.EndTime)
                .WithMessage("Start time must be earlier than end time.");

            RuleFor(shift => shift.EndTime)
                .NotEmpty().WithMessage("End time is required.")
                .GreaterThan(shift => shift.StartTime)
                .WithMessage("End time must be after than start time.");

            RuleFor(shift => shift.Date)
                .NotEmpty().WithMessage("Date is required.")
                .GreaterThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now)).WithMessage("Date must be in the future.");

            RuleFor(shift => shift.PaymentAmount)
                .NotEmpty().WithMessage("Payment amount is required.")
                .GreaterThan(0).WithMessage("Payment amount must be greater than zero.");

            RuleFor(c => c.HospitalId)
                .NotEmpty().WithMessage("Hospital ID is required.")
                .GreaterThan(0).WithMessage("Hospital ID invalid");

            When(c => c.HealthAgentId.HasValue, () =>
            {
                RuleFor(c => c.HealthAgentId)
                    .GreaterThan(0).WithMessage("Health Agent ID invalid");
            });
        }
    }
}
