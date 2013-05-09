using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InspectorIT.RouteFinder.Components.Common;

namespace InspectorIT.RouteFinder.View
{
    public partial class Main : CustomModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                rptRoutes.DataSource = System.Web.Routing.RouteTable.Routes;
                rptRoutes.DataBind();
            }



        }
    }
}