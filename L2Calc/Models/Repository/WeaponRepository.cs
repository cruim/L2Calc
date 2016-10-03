using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace L2Calc.Models.Repository
{
    public class WeaponRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Weapon> Weapons
        {
            get { return context.Weapons; }
        } 
    }
}