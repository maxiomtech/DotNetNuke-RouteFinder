using System.Web.Routing;
using System.Xml;
using DotNetNuke.Modules.Dashboard.Components;

namespace InspectorIT.RouteFinder.Components
{
    public class DnnController : IDashboardData
    {
        public void ExportData(XmlWriter writer)
        {
            writer.WriteStartElement("webapi");
            foreach (Route route in RouteTable.Routes)
            {
                writer.WriteElementString("route", route.Url);
            }

            writer.WriteEndElement();
        }
    }
}