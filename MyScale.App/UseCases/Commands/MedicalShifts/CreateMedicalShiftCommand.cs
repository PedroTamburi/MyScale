using MediatR;
using MyScale.Domain.Base;
using MyScale.Domain.Entities;

namespace MyScale.App.UseCases.Commands.Shifts
{
    public record CreateMedicalShiftCommand(
        int HospitalId,
        DateTime StartTime,
        DateTime EndTime,
        DateOnly Date,
        decimal PaymentAmount
    ) : IRequest<Result<int>>;
}
