<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<BancMobile.Models.Modelos.UsuarioModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Registro
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Registro</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Usuario</legend>
            
            <div class="editor-label">Rut
                <%: Html.LabelFor(model => model.rutUsuario)%>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.rutUsuario)%>
                <%: Html.ValidationMessageFor(model => model.rutUsuario)%>
            </div>
            
            <div class="editor-label">Nombre
                <%: Html.LabelFor(model => model.nombreUsuario)%>
            </div>

            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.nombreUsuario)%>
                <%: Html.ValidationMessageFor(model => model.nombreUsuario)%>
            </div>

             <div class="editor-label">Dirección
                <%: Html.LabelFor(model => model.direccionUsuario)%>
            </div>

            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.direccionUsuario)%>
                <%: Html.ValidationMessageFor(model => model.direccionUsuario)%>
            </div> 

            <div class="editor-label">Email
                <%: Html.LabelFor(model => model.mailUsuario)%>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.mailUsuario)%>
                <%: Html.ValidationMessageFor(model => model.mailUsuario)%>
            </div> 
            
            <div class="editor-label">Contraseña
                <%: Html.LabelFor(model => model.passUsuario)%>
            </div>

            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.passUsuario)%>
                <%: Html.ValidationMessageFor(model => model.passUsuario)%>
            </div>

            <div class="editor-label">Repita la Contraseña
                <%: Html.LabelFor(model => model.passUsuario)%>
            </div>

            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.passUsuario)%>
                <%: Html.ValidationMessageFor(model => model.passUsuario)%>
            </div>

            <legend>Celular</legend>

           


             <p>
                <input type="submit" value="Guardar" />
            </p>
        </fieldset>

    <% } %>
</asp:Content>
