<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<BancMobile.Models.Modelos.RecargaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Recargar
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Recargar</h2>

    <% Html.BeginForm(); %>

    <div class="editor-label">Valor</div>
            <div class="editor-field">
                 <select onclick="GetValor(value);">
                    <option value="3500">3.500</option>
                    <option value="5000">5.000</option>
                    <option value="10000">10.000</option>
                   </select>

                <%: Html.ValidationMessageFor(model => model.valor)%>
            </div>

  <div class="editor-label">Duración</div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.descripcion_recarga)%>
                <%: Html.ValidationMessageFor(model => model.descripcion_recarga)%>

            </div>
            
            <p>
                <input type="submit" value="Recargar" />
            </p>


    <% Html.EndForm(); %>



</asp:Content>
