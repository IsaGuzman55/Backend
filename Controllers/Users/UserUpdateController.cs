using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Data;
using Backend.Models;
using Backend.Services;

namespace Backend.Controllers{
    public class UserUpdateController : ControllerBase{
        private readonly IUserRepository _userRepository;

        public UserUpdateController(IUserRepository userRepository){
            _userRepository = userRepository;
        }

        [HttpPut]
        [Route("api/user/{id}/update")]
        public IActionResult Update([FromBody] User user){
            try
            {
                _userRepository.Update(user);
                return Ok("El usuario se actualizó correctamente");

            }
            catch (System.Exception)
            {   
                return BadRequest("El usuario no se actualizó");
            }
        }
    }
}