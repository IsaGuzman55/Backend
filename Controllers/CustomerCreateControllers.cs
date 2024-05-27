using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Services;

namespace Backend.Controllers
{
public class CustomerCreateControllers : ControllerBase
{
    private readonly ICustomerRepository _customerRepository;
    public CustomerCreateControllers(ICustomerRepository customerRepository)
    {
    _customerRepository = customerRepository;
    }
    [HttpPost]
    [Route("api/customers")]
    public ActionResult Create([FromBody] Customer customer)
    {
        Console.WriteLine("hola zura");
        _customerRepository.add(customer);
        return Ok();
    }
 }
}