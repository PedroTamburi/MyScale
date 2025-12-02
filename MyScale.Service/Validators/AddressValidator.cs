using FluentValidation;
using MyScale.Domain.Entities;

namespace MyScale.Service.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(address => address.Street)
                .NotEmpty().WithMessage("Street is required.")
                .MaximumLength(150).WithMessage("Street cannot exceed 150 characters.");

            RuleFor(address => address.Number)
                .NotEmpty().WithMessage("Number is required.")
                .MaximumLength(20).WithMessage("Number cannot exceed 20 characters.");

            RuleFor(address => address.Neighborhood)
                .NotEmpty().WithMessage("Neighborhood is required.")
                .MaximumLength(100).WithMessage("Neighborhood cannot exceed 100 characters.");

            RuleFor(address => address.City)
                .NotEmpty().WithMessage("City is required.")
                .MaximumLength(100).WithMessage("City cannot exceed 100 characters.");

            RuleFor(address => address.State)
                .NotEmpty().WithMessage("State is required.")
                .MaximumLength(2).WithMessage("State cannot exceed 2 characters.");

            RuleFor(address => address.Complement)
                .MaximumLength(100).WithMessage("Complement cannot exceed 100 characters.");
        }
    }
}