using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using L2Calc.Models.Entities;

namespace L2Calc.Models.Repository
{
    public class ShadowWeaponRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<ShadowWeapon> ShadowWeapons
        {
            get { return context.ShadowWeapons; }
        }
    }
}
