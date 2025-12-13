using AutoMapper;
using FluentValidation;
using MyScale.Domain.Entities;

namespace MyScale.Service.Validators 
{
    public class HospitalValidator : AbstractValidator<Hospital>
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
                .LessThan(DateTime.Now.Date).WithMessage("BirthDate must be in the past.");

            RuleFor(agent => agent.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email format.")
                .MaximumLength(100).WithMessage("Email cannot exceed 100 characters.");

            RuleFor(h => h.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(8).WithMessage("The password must be at least 8 characters long.")
                .Matches(@"[A-Z]").WithMessage("The password should contain at least 1 uppercase character.")
                .Matches(@"[a-z]").WithMessage("The password must contain at least one lowercase letter.")
                .Matches(@"[0-9]").WithMessage("The password must contain at least one number.")
                .Matches(@"[\W]").WithMessage("The password must contain at least one special character (!? *.).");

            RuleFor(agent => agent.Username)
                .NotEmpty().WithMessage("Username is required.")
                .MaximumLength(50).WithMessage("Username cannot exceed 50 characters.");

            RuleFor(h => h.Address).SetValidator(new AddressValidator());
        }
}
}
