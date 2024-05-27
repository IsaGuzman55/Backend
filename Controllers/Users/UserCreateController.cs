using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Data;
using Backend.Models;
using Backend.Services;

namespace Backend.Controllers{
    public class UserCreateController : ControllerBase{
        private readonly IUserRepository _userRepository;

        public UserCreateController(IUserRepository userRepository){
            _userRepository = userRepository;
        }

        [HttpPost]
        [Route("api/user")]
        public IActionResult Create([FromBody] User user){
            try
            {
                _userRepository.Add(user);
                return Ok("El usuario se creó correctamente");

            }
            catch (System.Exception)
            {   
                return BadRequest("El usuario no pudo crearse");
            }
        }
    }
}