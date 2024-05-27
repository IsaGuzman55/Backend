using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Services;
using Backend.Data;
using Backend.Models;

namespace Backend.Services
{
    public interface IUserRepository
    {
        /* void GetAll(User user); */
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Add(User user);
        void Update(User user);
        void Remove(int id);
        /*void Remove(int id);
        void Update(User user); */
    }
}