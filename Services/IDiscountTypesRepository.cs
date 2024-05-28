using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Services
{
    public interface IDiscountTypesRepository 
    {
    IEnumerable<DiscountType> GetAll();
    DiscountType GetById(int id);
        
    }
}