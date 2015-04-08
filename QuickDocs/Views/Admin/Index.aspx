<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>ADMIN PAGE INDEX</h2>
<div id="adminPanelContainer">
    <% Html.RenderAction("AdminPanel"); %>
</div>
    
<div id="userContainer">
   <% using (Ajax.BeginForm(new AjaxOptions 
   { 
       HttpMethod = "POST",
       InsertionMode = InsertionMode.Replace,
       UpdateTargetId = "ajaxFormContainer"
   }))
   { %>
    
    <div id="ajaxFormContainer">                
    </div>
<% } %>
</div>

</asp:Content>
