using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Data;
using Backend.Models;


namespace Backend.Services
{
    public class DiscountTypesRepository : IDiscountTypesRepository
    {
        private readonly BaseCuponesContext _context;
        public DiscountTypesRepository(BaseCuponesContext context)
        {
            _context = context;
        }
        //listar
        public IEnumerable<DiscountType> GetAll()
        {
            return _context.DiscountTypes.ToList();
        }
        //buscar por id
        public DiscountType GetById(int id)
        {
            return _context.DiscountTypes.Find(id);
        }
    }
}