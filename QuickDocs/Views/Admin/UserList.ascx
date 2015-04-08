<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<QuickDocs.Logic.WebTemplateObject.UserWTO>>" %>

<% foreach (var item in Model)
    { %>
    <div class="userElementRow">
        <input id="userId" type="hidden" data-id="<%= item.Id %>" />
        <div class="labelContainer">
            <%= item.Name %>
        </div>
        <div class="labelContainer">                
            <%= item.Surname %>
        </div>
        <div class="labelContainer">
            <%= item.getRolesInString() %>
        </div>

        <div class="buttonContainer">
            <%= Html.ActionLink("Редактировать", "EditUser", new { name = item.Id }) %>            
        </div>

        <div class="buttonContainer">
            <%= Html.ActionLink("Удалить", "DeleteUser", new { name = item.Id }) %>            
        </div>

        <div class="buttonContainer">
            <%= Html.ActionLink("Инфо", "DetailsUser", new { name = item.Id }) %> 
        </div>

    </div>
<% } %>

