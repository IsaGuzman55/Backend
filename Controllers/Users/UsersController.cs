using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Data;
using Backend.Models;
using Backend.Services;

namespace Backend.Controllers{
    public class UsersController : ControllerBase{
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository){
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("api/users")]
        public IActionResult GetUsers()
        {
            var users = _userRepository.GetAll();
            if (!users.Any())
            {
                return Ok(new { Message = "No hay ningún empleado registrado." });
            }
            return Ok(users);
        }

        [HttpGet]
        [Route("api/user/{id}")]
        public IActionResult Details(int id)
        {
            var user = _userRepository.GetById(id);
            if (user == null)
            {
                return NotFound("Este empleado no existe");
            }
            return Ok(user);
        }


    }
}