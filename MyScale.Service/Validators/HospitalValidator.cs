using AutoMapper;
using FluentValidation;
using MyScale.Domain.Entities;

namespace MyScale.Service.Validators 
{
    internal class HospitalValidator : AbstractValidator<Hospital>
    {
        public HospitalValidator()
        {
            RuleFor(hospital => hospital.Name)
                .NotEmpty().WithMessage("Hospital name is required.")
                .MaximumLength(100).WithMessage("Hospital name cannot exceed 100 characters.");

            RuleFor(hospital => hospital.MunicipalRegistry)
                .NotEmpty().WithMessage("Municipal Registry is required.")
                .MaximumLength(50).WithMessage("Municipal Registry cannot exceed 50 characters.");

            RuleFor(Hospital => Hospital.CNPJ)
                .NotEmpty().WithMessage("CNPJ is required.")
                .Length(14).WithMessage("CNPJ must be exactly 14 characters.");

            RuleFor(hospital => hospital.FoundationDate)
                .NotEmpty().WithMessage("Foundation Date is required.")
                .WithMessage("Foundation Date must be a valid date.")
                .LessThan(DateOnly.FromDateTime(DateTime.Now)).WithMessage("BirthDate must be in the past.");

            RuleFor(agent => agent.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.")
                .MaximumLength(100).WithMessage("Email cannot exceed 100 characters.");

            RuleFor(agent => agent.Password)
                .NotEmpty().WithMessage("Password is required.")
                .WithMessage("Password cannot be empty.");

            RuleFor(agent => agent.Username)
                .NotEmpty().WithMessage("Username is required.")
                .MaximumLength(50).WithMessage("Username cannot exceed 50 characters.");
            
            //SHIFTS
        }
}
}
