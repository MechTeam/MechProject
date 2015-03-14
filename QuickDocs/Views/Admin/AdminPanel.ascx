<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<QuickDocs.Logic.WebTemplateObject.SuperAdminWTO>" %>

<% using(Html.BeginForm()) { %>

    <div id="selectControl" style="width: 820px;">
        <select id="showType">
            <option value="1">Все</option>
            <option value="2">Студенты</option>
            <option value="3">Преподователи</option>
            <option value="4">Администраторы</option>
        </select>
    </div>
    <div>
        <%= Html.ActionLink("Добавить админимстратора", "AddAdmin") %>        
    </div>
<% } %>

