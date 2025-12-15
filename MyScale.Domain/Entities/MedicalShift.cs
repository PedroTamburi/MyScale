using MyScale.Domain.Base;
using System.Reflection.Metadata;
namespace MyScale.Domain.Entities;

public class MedicalShift : BaseEntity<int>
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public DateOnly Date { get; set; }
    public decimal PaymentAmount { get; set; }

    // hospital relationship
    public int HospitalId { get; set; }
    public Hospital Hospital { get; set; }

    // health agent relationship
    public int? HealthAgentId { get; set; }
    public HealthAgent HealthAgent { get; set; }

    public bool IsOpen => HealthAgentId == null;

    public MedicalShift()
    {

    }

    public MedicalShift(int id, DateTime startTime, DateTime endTime, DateOnly date, decimal paymentAmount,int hospitalId) : base(id)
    {
        StartTime = startTime;
        EndTime = endTime;
        Date = date;
        PaymentAmount = paymentAmount;
        HospitalId = hospitalId;
    }

    public void AssignAgent(int agentId)
    {
        HealthAgentId = agentId;
    }

    public void Update(DateTime start, DateTime end, DateOnly date, decimal amount)
    {
        StartTime = start;
        EndTime = end;
        Date = date;
        PaymentAmount = amount;
    }
}
