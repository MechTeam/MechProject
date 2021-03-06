﻿<%@ Page Language="C#" MasterPageFile="~/Views/Master.Master" Inherits="System.Web.Mvc.ViewPage<QuickDocs.Models.Domain.Entities.Account>" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <% using(Html.BeginForm()) { %>
        <div class="inputRow">      
            <div class="labelContainer">
                <p>Логин:</p>
            </div>  
            <div class="textContainer">
                <input id="loginTxt" name="Login" class="txt" type="text" />
            </div>
            <div class="messageContainer">
                <p id="loginMessage" class="Message"></p>
            </div>
        </div>
        <div class="inputRow">
            <div class="labelContainer">
                <p>Пароль:</p>
            </div>
            <div class="textContainer">
                <input id="passwordTxt" name="Password" class="txt" type="text" />
            </div>
            <div class="messageContainer">
                <p id="passwordMessage"></p>            
            </div>            
        </div>
        <div class="inputRow">
            <div class="buttonContainer">
                <input class="flat" type="submit" value="Регистрация" />
            </div>
            <div class="buttonContainer">
                <input class="flat" type="button" value="Войти" onclick="location.href='<%= Url.Action("Index", "Admin") %>    '" />
            </div>
        </div>
    <% } %>
</asp:Content>
   

