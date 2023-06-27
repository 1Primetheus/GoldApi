using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoldApi.Enums;

namespace GoldApi.Models;

public class Person
{
    public Guid PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}".Trim();
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public int Zipcode { get; set; }
}
