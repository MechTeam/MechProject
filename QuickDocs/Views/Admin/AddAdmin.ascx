<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<QuickDocs.Logic.WebTemplateObject.UserWTO>" %>

<script src="<%: Url.Content("~/Scripts/jquery-1.7.1.min.js") %>"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>

    <fieldset>
        <legend>Добавление администратора</legend>
        <div class="LabelContainer">
            <p>Имя</p>
        </div>
        <div class="textContainer">
            <input id="FirstNameTxt" name="Name" class="txt" type="text" />
        </div>
        <div class="LabelContainer">
            <p>Фамилия</p>
        </div>
        <div class="textContainer">
            <input id="SecondNameTxt" name="SecondName" class="txt" type="text" />
        </div>
        <div class="LabelContainer">
            <p>E-mail</p>
        </div>
        <div class="textContainer">
            <input id="EMailTxt" name="EMail" class="txt" type="text" />
        </div>
        <%: Html.HiddenFor(model => model.Id) %>

        <p>
            <input type="submit" value="Добавить" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>
