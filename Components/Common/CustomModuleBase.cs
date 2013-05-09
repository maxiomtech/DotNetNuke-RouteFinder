using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using DotNetNuke.Entities.Modules;

namespace InspectorIT.RouteFinder.Components.Common
{
    public class CustomModuleBase : PortalModuleBase
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Control currentCtl = this;
            while ((currentCtl as PortalModuleBase) == null || (currentCtl as PortalModuleBase).ModuleConfiguration==null)
            {
                currentCtl = currentCtl.Parent;
            }

            ModuleConfiguration = ((PortalModuleBase)currentCtl).ModuleConfiguration;
            
        }
    }
}