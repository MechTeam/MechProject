<%@ Page Language="C#" MasterPageFile="~/Views/Master.Master" Inherits="System.Web.Mvc.ViewPage<QuickDocs.Models.Domain.Entities.Account>" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <% using(Html.BeginForm()) { %>        
        <div class="inputRow">      
            <div class="labelContainer">
                <p>Логин:</p>
            </div>  
            <div class="textContainer">
                <input id="loginTxt" name="Login" class="txt" type="text" />
                <%= Html.ValidationMessage("LoginMessage") %>
            </div>
            <div class="messageContainer">
                <label for="loginTxt" class="ErrorMessage"></label>                
            </div>
        </div>
        <div class="inputRow">
            <div class="labelContainer">
                <p>Пароль:</p>
            </div>
            <div class="textContainer">
                <input id="passwordTxt" name="Password" class="txt" type="text" />
                <%= Html.ValidationMessage("PasswordMessage") %>
            </div>
            <div class="messageContainer">
                <label for="passwordTxt" class="ErrorMessage"></label>                
            </div>            
        </div>
        <div class="inputRow">
            <div class="buttonContainer">
                <input class="flat" type="submit" value="Регистрация" />
            </div>
            <div class="buttonContainer">
                <input class="flat" type="submit" value="Войти" />
            </div>
        </div>
    <% } %>
</asp:Content>
   

