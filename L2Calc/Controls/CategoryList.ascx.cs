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
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected string CreateHomeLinkHtml()
        {
            string path = RouteTable.Routes.GetVirtualPath(null,null).VirtualPath;
            return string.Format("<a href='{0}'>R - R99</a>", path);
        }

        protected string CreateFaqLinkHtml()
        {
            string path = RouteTable.Routes.GetVirtualPath(null, "faq", null).VirtualPath;
            return string.Format("<a href='{0}'>FAQ</a>", path);
        }

        protected string CreateDS80LinkHtml()
        {
            string path = RouteTable.Routes.GetVirtualPath(null, "D-S80", null).VirtualPath;
            return string.Format("<a href='{0}'>D - S80</a>", path);
        }


    }
}

