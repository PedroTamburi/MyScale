using MyScale.Domain.Base;
using System.Reflection.Metadata;
namespace MyScale.Domain.Entities;

public class HealthAgent : BaseEntity<int>
{
    public string Name { get; set; }
    public string Document { get; set; }
    public DateOnly BirthDate { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }
    public DateTime RegisterDate { get; set; }
    public DateTime LoginDate { get; set; }
    public bool IsActive { get; set; }
    public Address Address { get; set; }
    public virtual ICollection<MedicalShift> Shifts { get; set; }

    public HealthAgent()
    {
        Address = new Address();
        Shifts = new List<MedicalShift>();
    }

    public HealthAgent(int id, string name, DateOnly birthDate, string document,  string password, string username, string email, DateTime registerDate, DateTime loginDate, bool isActive)
        : base(id)
    {
        Name = name;
        Document = document;
        BirthDate = birthDate;
        Email = email;
        Password = password;
        Username = username;
        RegisterDate = registerDate;
        LoginDate = loginDate;
        IsActive = isActive;

        Address = new Address();
        Shifts = new List<MedicalShift>();
    }
}
