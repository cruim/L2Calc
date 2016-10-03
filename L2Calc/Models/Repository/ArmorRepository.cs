using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L2Calc.Models.Repository
{
    public class ArmorRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Armor> Armors
        {
            get { return context.Armors; }
        } 
    }
}