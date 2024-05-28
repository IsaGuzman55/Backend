using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend.Services;
using Backend.Models;

namespace Backend.Controllers
{
    public class DiscountTypeControllers : ControllerBase
    {
         private readonly IDiscountTypesRepository _DiscountTypesRepository;
        public DiscountTypeControllers(IDiscountTypesRepository DiscountTypesRepository)
        {
            _DiscountTypesRepository = DiscountTypesRepository;
        }

        [HttpGet]
        [Route("api/DiscountTypes")]
        public IEnumerable<DiscountType> GetDiscountTypes(){
            return _DiscountTypesRepository.GetAll();
        }
        [HttpGet]
        [Route("api/DiscountTypes/{id}")]
        public DiscountType Details(int id){
            return _DiscountTypesRepository.GetById(id);
        }  
        
    }
}