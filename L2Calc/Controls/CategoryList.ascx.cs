using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using L2Calc.Models;
using L2Calc.Models.Repository;

namespace L2Calc.Controls
{
    public partial class CategoryList : System.Web.UI.UserControl
    {
        private CategoryRepository categoryRepository = new CategoryRepository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected IEnumerable<Category> GetCategories()
        {
            return new CategoryRepository().Categories;
        }

        protected string CreateHomeLinkHtml()
        {
            string path = RouteTable.Routes.GetVirtualPath(null,null).VirtualPath;
            return string.Format("<a href='{0}'>Главная</a>", path);
        }

        protected string CreateFaqLinkHtml()
        {
            string path = RouteTable.Routes.GetVirtualPath(null, "faq", null).VirtualPath;
            return string.Format("<a href='{0}'>FAQ</a>", path);
        }


    }
}

