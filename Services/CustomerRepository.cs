using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Data;
using Backend.Models;

namespace Backend.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BaseCuponesContext _context;
        public CustomerRepository(BaseCuponesContext context)
        {
            _context = context;
        }
        //crear
        public void add(Customer customer)
        {
            Console.WriteLine(customer.Birthdate);
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
        //listar
        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }
        //buscar por id
        public Customer GetById(int id)
        {
            return _context.Customers.Find(id);
        }
        //eliminar
        public void remove(int id)
        {
            var customer = _context.Customers.Find(id);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
        //actualizar
        public void update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
    }
}