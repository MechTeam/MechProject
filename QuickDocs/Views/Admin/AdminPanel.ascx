<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<QuickDocs.Logic.WebTemplateObject.RoleWTO>" %>

<% using(Html.BeginForm()) { %>
    <div id="selectControl" style="width: 820px;">
        <select id="showType">
            <% foreach(var item in Model.WebRoles) { %>
                <option value="<%=item.Key %>"><%= item.Value %></option>
            <% } %>
        </select>        
    </div>
    <div>
        
    </div>
<% } %>

