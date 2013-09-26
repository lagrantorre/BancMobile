<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<BancMobile.Models.Modelos.ConsultaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ConsultaCelular
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

  <h2>ConsultaCelular</h2>

    <% Html.BeginForm(); %>
   
   <div class="editor-label">Número</div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.numCelular)%>
                <%: Html.ValidationMessageFor(model => model.numCelular)%>
            </div>

<div class="editor-label">Compañia</div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.nombreCompania)%>
                <%: Html.ValidationMessageFor(model => model.nombreCompania)%>
            </div>

 <div class="editor-label">Tipo</div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.tipo)%>
                <%: Html.ValidationMessageFor(model => model.tipo)%>
            </div>

<div class="editor-label">Plan</div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.nombre_plan)%>
                <%: Html.ValidationMessageFor(model => model.nombre_plan)%>
            </div>

<div class="editor-label">Última Recarga</div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.valorRecarga)%>
                <%: Html.ValidationMessageFor(model => model.valorRecarga)%>
            </div>


<% Html.EndForm(); %>


</asp:Content>

