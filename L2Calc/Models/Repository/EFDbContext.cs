using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace L2Calc.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Armor> Armors { get; set; } 
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<CountOfEnchant> Counts { get; set; } 
    }
}