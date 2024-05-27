using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Customer
    {
    public int Id {get; set;}
    public string? FirstName {get; set;}
    public string? LastName {get; set;}
    public int DocumentTypeId {get; set;}
    public string? IdentificationNumber {get; set;}
    public string? Email {get; set;}
    public string? PhoneNumber {get; set;}
    public DateOnly? Birthdate {get; set;}
    }
}