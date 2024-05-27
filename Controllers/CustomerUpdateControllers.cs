using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Services;


namespace Backend.Controllers
{ 
public class CustomerUpdateControllers : ControllerBase
{
private readonly ICustomerRepository _customerRepository;
public CustomerUpdateControllers(ICustomerRepository customerRepository)
{
 _customerRepository = customerRepository;
}

[HttpPut]
[Route("api/customer/{id}/update")]
public IActionResult Update([FromBody] Customer customer){
    try {
        _customerRepository.update(customer);
        return Ok("El usuario se actualizo correctamente");
    }
    catch(System.Exception)
    {
        return BadRequest("No se pudo actualizar el usuario");
    }
    }
  }
}