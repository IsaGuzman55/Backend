using Microsoft.EntityFrameworkCore;
using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class BaseCuponesContext : DbContext
    {
        public BaseCuponesContext(DbContextOptions<BaseCuponesContext> options) : base(options){
        }
        public DbSet<DiscountType> DiscountTypes  { get; set; }
    }
    
}