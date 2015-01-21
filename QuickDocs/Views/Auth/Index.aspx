<%@ Page Language="C#" MasterPageFile="~/Views/Master.Master" Inherits="System.Web.Mvc.ViewPage<QuickDocs.Models.Domain.Entities.Account>" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <% using(Html.BeginForm()) { %>
        <div id="authContent">
            <table id="conentTable">                        
                <tr>
                    <td>
                        <p>Логин:</p>
                    </td>
                    <td>
                        <input name="Login" class="txt" type="text" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <p>Пароль:</p>
                    </td>
                    <td>
                        <input name="Password" class="txt" type="text" />
                    </td>
                </tr>                
                <tr>
                    <td>
                        <input class="flat" type="submit" value="Регистрация" />
                    </td>
                    <td>
                        <input class="flat" type="submit" value="Войти" />
                    </td>
                </tr>
            </table>
        </div>
    <% } %>
</asp:Content>
   

