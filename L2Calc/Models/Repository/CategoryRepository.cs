using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace L2Calc.Models.Repository
{
    public class CategoryRepository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Category> Categories
        {
            get { return context.Categories; }
        }
    }
}