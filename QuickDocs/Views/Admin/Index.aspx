<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>
<div id="adminPanelContainer">
    <% Html.RenderAction("AdminPanel"); %>
</div>
    
<div id="userContainer">
    <% Html.RenderAction("UserList"); %>
</div>

</asp:Content>
