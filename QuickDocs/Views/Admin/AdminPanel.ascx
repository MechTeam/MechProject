<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<QuickDocs.Logic.WebTemplateObject.SuperAdminWTO>" %>

<% using(Html.BeginForm()) { %>
    
    <div id="AdminInfo">
    </div>
    <div id="AdminControls" style="width: 820px;">
        <div>
            <input type="submit" id="showAll" class="flat" value="Все" />
        </div>
        <div>
            <input type="submit" id="showStudents" class="flat" value="Студенты" />
        </div>
        <div>
            <input type="submit" id="showTeachers" class="flat" value="Преподователи" />
        </div>
        <div>
            <input type="submit" id="showAdmins" class="flat" value="Администраторы" />
        </div>
    </div>
    

<% } %>

