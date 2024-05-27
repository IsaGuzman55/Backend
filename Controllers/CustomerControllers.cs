using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Models;
using Backend.Services;

namespace Backend.Controllers
{
    public class CustomerControllers : ControllerBase

    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerControllers(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        [Route("api/customers")]
        public IEnumerable<Customer> GetCustomers(){
            return _customerRepository.GetAll();
        }
        [HttpGet]
        [Route("api/customers/{id}")]
        public Customer Details(int id){
            return _customerRepository.GetById(id);
        }  
    }
}