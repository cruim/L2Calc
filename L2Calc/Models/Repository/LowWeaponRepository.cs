using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L2Calc.Models.Repository
{
    public class LowWeaponRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<LowWeapon> LowWeapons
        {
            get { return context.LowWeapons; }
        }
    }
}