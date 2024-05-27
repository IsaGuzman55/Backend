using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Backend.Controllers
{
public class CustomerDeleteControllers : ControllerBase
{
    private readonly ICustomerRepository _customerRepository;
    public CustomerDeleteControllers(ICustomerRepository customerRepository)
    {
    _customerRepository = customerRepository;
    }
    [HttpDelete("{id}")]
    [Route("api/customers/{id}")]
     public IActionResult Delete(int id)
    {
        _customerRepository.remove(id);
        return Ok();
    }
}
}