<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<BancMobile.Models.Modelos.CompaniaModel>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ListaCompanias
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>ListaCompanias</h2>

    <table class="table">
        <tr>
            
            <th>
                idCompania
            </th>
            <th>
                nombreCompania
            </th>
            <th></th>
        </tr>



    <% foreach (var item in Model) { %>
    
        <tr>
           
            <td>
                <%: item.idCompania %>
            </td>
            <td>
                <%: item.nombreCompania %>
            </td>
             <td>
                <%: Html.ActionLink("Editar", "Edit", new { /* id=item.PrimaryKey */ }) %> |
                <%: Html.ActionLink("Detalle", "Details", new { /* id=item.PrimaryKey */ })%> |
                <%: Html.ActionLink("Borrar", "Delete", new { /* id=item.PrimaryKey */ })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear nueva compañia", "Create") %>
    </p>

</asp:Content>

