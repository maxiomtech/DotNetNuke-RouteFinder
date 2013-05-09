<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Main.ascx.cs" Inherits="InspectorIT.RouteFinder.View.Main" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>
<%@ Import Namespace="System.Web.Routing" %>


<dnn:DnnCssInclude ID="DnnCssInclude1" runat="server" FilePath="~/DesktopModules/InspectorIT/RouteFinder/module.css"></dnn:DnnCssInclude>
<dnn:DnnJsInclude runat="server" FilePath="~/DesktopModules/InspectorIT/RouteFinder/module.js"></dnn:DnnJsInclude>

<asp:Repeater runat="server" ID="rptRoutes">
    <HeaderTemplate>
        <ul class="iit-zebra">
            <li class="hdr">Endpoints</li>
    </HeaderTemplate>
    <ItemTemplate>
        <li><%# ((Route)Container.DataItem).Url %></li>
    </ItemTemplate>
    <FooterTemplate>
        </ul>
    </FooterTemplate>
</asp:Repeater>