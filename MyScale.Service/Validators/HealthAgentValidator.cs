using FluentValidation;
using MyScale.Domain.Entities;

namespace MyScale.Service.Validators
{
    public class HealthAgentValidator : AbstractValidator<HealthAgent>
    {
        public HealthAgentValidator() 
        { 
            RuleFor(agent => agent.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");

            RuleFor(agent => agent.Document)
                .NotEmpty().WithMessage("Document is required.")
                .MaximumLength(20).WithMessage("Document cannot exceed 20 characters.");

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

            RuleFor(agent => agent.BirthDate)
                .LessThan(DateOnly.FromDateTime(DateTime.Now)).WithMessage("BirthDate must be in the past.");

            RuleFor(h => h.Address).SetValidator(new AddressValidator());
        }
    }
}
