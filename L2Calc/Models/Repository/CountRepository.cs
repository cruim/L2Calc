using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L2Calc.Models.Repository
{
    public class CountRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<CountOfEnchant> Counts
        {
            get { return context.Counts; }
        }
    }
}