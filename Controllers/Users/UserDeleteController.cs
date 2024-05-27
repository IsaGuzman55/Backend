using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Data;
using Backend.Models;
using Backend.Services;

namespace Backend.Controllers{
    public class UserDeleteController : ControllerBase{
        private readonly IUserRepository _userRepository;

        public UserDeleteController(IUserRepository userRepository){
            _userRepository = userRepository;
        }

        [HttpDelete("{id}")]
        [Route("api/user/{id}")]
        public IActionResult Delete(int id){
            try
            {
                _userRepository.Remove(id);
                return Ok("El usuario se eliminó correctamente");

            }
            catch (System.Exception)
            {   
                return BadRequest("El usuario no se pudo eliminar");
            }
        }
    }
}