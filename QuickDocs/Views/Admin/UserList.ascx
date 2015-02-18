<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<QuickDocs.Logic.WebTemplateObject.UserWTO>>" %>

<% using(Html.BeginForm()) { %>
    <h2>
        Список пользователей
    </h2>
    <% foreach(var item in Model) { %>
        <div class="userElementRow">
            <div class="labelContainer">
                <%= item.Name %>
            </div>
            <div class="labelContainer">                
                <%= item.Surname %>                
            </div>
            <div class="labelContainer">
                <%= item.getRolesInString() %>
            </div>
            <div>

            </div>
            <div class="buttonContainer">
                <%= Html.ActionLink("Удалить", "DeleteUser", "Admin", new { id = item.Id }, new {@class = "flatActionLink"}) %>                
            </div>
            <div class="buttonContainer">
                <%= Html.ActionLink("Изменить", "EditUser", "Admin", new { id = item.Id }, new {@class ="flatActionLink" })%>
            </div>
            <div class="buttonContainer">
                <%= Html.ActionLink("Детали", "DetailsUser", "Admin", new { id = item.Id }, new {@class = "flatActionLink" })%>
            </div>
        </div>

    <% } %>


<% } %>

