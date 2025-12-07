using MyScale.Domain.Base;
using System.Reflection.Metadata;
namespace MyScale.Domain.Entities;

public class Hospital : BaseEntity<int>
{
    public string Name { get; set; }
    public string MunicipalRegistry { get; set; }
    public string CNPJ { get; set; }
    public DateOnly FoundationDate { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }
    public DateTime RegisterDate { get; set; } = DateTime.Now;
    public DateTime? LoginDate { get; set; }
    public bool IsActive { get; set; }
    public Address Address { get; set; }
    public virtual ICollection<MedicalShift> Shifts { get; set; }



    public Hospital()
    {
        Address  = new Address();
        Shifts = new List<MedicalShift>();
    }

    public Hospital(int id, string name,string municipalRegistry, string cnpj, DateOnly foundationDate, string password, string username, string email, DateTime registerDate, DateTime loginDate, bool isActive)
        : base(id)
    {
        Name = name;
        MunicipalRegistry = municipalRegistry;
        FoundationDate = foundationDate;
        CNPJ = cnpj;
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
