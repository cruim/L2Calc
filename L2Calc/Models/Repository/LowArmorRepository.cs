using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using L2Calc.Models.Entities;

namespace L2Calc.Models.Repository
{
    public class LowArmorRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<LowArmor> Armors
        {
            get { return context.LowArmors; }
        }
    }
}