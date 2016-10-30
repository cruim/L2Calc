using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using L2Calc.Models.Entities;

namespace L2Calc.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public DbSet<Armor> Armors { get; set; } 
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<CountOfEnchant> Counts { get; set; }
        public DbSet<LowWeapon> LowWeapons { get; set; } 
        public DbSet<LowArmor> LowArmors { get; set; }
        public DbSet<ShadowWeapon> ShadowWeapons { get; set; }  
    }
}