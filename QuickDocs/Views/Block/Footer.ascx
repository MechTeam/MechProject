<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<% using(Html.BeginForm()) { %>
    <div>
        <table class="footerTable">
            <tr>
                <td class="footerTD">
                    <p class="FooterText">
                        Мехатроника и робототехника, 2015
                    </p>
                </td>
            </tr>
        </table>
    </div>
<% } %>


