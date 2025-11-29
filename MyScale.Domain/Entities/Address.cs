using MyScale.Domain.Base;
using System.Reflection.Metadata;
namespace MyScale.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

[Owned]
public class Address 
{
    public string Street { get; set; }
    public string Number { get; set; }
    public string Neighborhood { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string? Complement { get; set; }

    public Address()
    {

    }

    public Address(string street, string number, string neighborhood, string city, string state, string zipCode, string? complement)
    {
        Street = street;
        Number = number;
        Neighborhood = neighborhood;
        City = city;
        State = state;
        Complement = complement;
    }
}
