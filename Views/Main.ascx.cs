using System;
using System.Linq;
using System.Web.Routing;
using InspectorIT.RouteFinder.Components.Common;

namespace InspectorIT.RouteFinder.View
{
    public partial class Main : CustomModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                rptRoutes.DataSource = RouteTable.Routes.OfType<Route>();
                rptRoutes.DataBind();
            }



        }
    }
}