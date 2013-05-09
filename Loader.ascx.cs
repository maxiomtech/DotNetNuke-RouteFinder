using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InspectorIT.RouteFinder.Components.Common;
using InspectorIT.RouteFinder.View;

namespace InspectorIT.RouteFinder
{
    public partial class Loader : CustomModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            phOutput.Controls.Add(LoadControl(ControlPath + "Views/Main.ascx") as Main);
        }
    }
}