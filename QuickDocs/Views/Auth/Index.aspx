<%@ Page Language="C#" MasterPageFile="~/Views/Master.Master" Inherits="System.Web.Mvc.ViewPage<QuickDocs.Models.Domain.Entities.Account>" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <% using(Html.BeginForm()) { %>
        <div id="loginBlock" style="text-align: center; width: 1000px;">        
            <table class="userInput">
                <tr>
                    <td style="width: 150px;">
                        <p>Логин:</p>
                    </td>
                    <td style="width: 150px;">
                        <input id="loginTxt" name="Login" class="txt" type="text" />                        
                    </td>
                    <td style="width: 200px;">
                        <p id="loginMessage" class="Message"></p>
                    </td>
                </tr>
            </table>
        </div>
        <div id="passwordBlock" style="text-align: center; width: 1000px;">
            <table class="userInput">
                <tr>
                    <td style="width: 150px;">
                        <p>Пароль:</p>
                    </td>
                    <td style="width: 150px;">
                        <input id="passwordTxt" name="Password" class="txt" type="text" />
                    </td>
                    <td style="width: 200px;">
                        <p id="passwordMessage"></p>            
                    </td>
                </tr>
            </table>
        </div>
        <div id="buttonBlock" style="text-align: center; width: 1000px;">
            <table style="padding-top: 30px;">
                <tr>
                    <td>
                        <input class="flat" type="submit" value="Регистрация" />                                
                    </td>
                    <td>
                        <input class="flat" type="button" value="Войти" onclick="location.href='<%= Url.Action("Index", "Admin") %>'" />        
                    </td>                   
                </tr>
            </table>
        </div>
    <% } %>
</asp:Content>
   

