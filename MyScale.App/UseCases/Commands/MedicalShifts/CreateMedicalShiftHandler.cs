using MediatR;
using MyScale.App.UseCases.Commands.Shifts;
using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using MyScale.Domain.Interfaces;

namespace MyScale.Application.UseCases.Commands.MedicalShifts
{
    public class CreateMedicalShiftHandler : IRequestHandler<CreateMedicalShiftCommand, Result<int>>
    {
        private readonly IMedicalShiftRepository _repository;

        public CreateMedicalShiftHandler(IMedicalShiftRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<int>> Handle(CreateMedicalShiftCommand request, CancellationToken cancellationToken)
        {
            if (request.EndTime <= request.StartTime)
            {
                return Result<int>.Failure("O horário de fim deve ser posterior ao início.");
            }

            try
            {
                var medicalShift = new MedicalShift(
                    id: 0,
                    startTime: request.StartTime,
                    endTime: request.EndTime,
                    date: request.Date,
                    paymentAmount: request.PaymentAmount,
                    hospitalId: request.HospitalId
                );

                var newId = await _repository.AddAsync(medicalShift);

                return Result<int>.Success(newId);
            }
            catch (Exception ex)
            {
                return Result<int>.Failure($"Erro ao criar plantão: {ex.Message}");
            }
        }
    }
}