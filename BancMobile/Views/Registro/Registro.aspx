<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<BancMobile.Models.Modelos.RegistroModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Registro
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Registro</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Usuario</legend>
            
            <div class="editor-label">Rut</div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.rutUsuario)%>
                <%: Html.ValidationMessageFor(model => model.rutUsuario)%>
            </div>
            
           
           <div class="editor-label">Nombre</div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.nombreUsuario)%>
                <%: Html.ValidationMessageFor(model => model.nombreUsuario)%>
            </div>

             
             <div class="editor-label">Dirección</div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.direccionUsuario)%>
                <%: Html.ValidationMessageFor(model => model.direccionUsuario)%>
            </div> 

          <div class="editor-label">Email</div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.mailUsuario)%>
                <%: Html.ValidationMessageFor(model => model.mailUsuario)%>
            </div> 
            
            
            <div class="editor-label">Ingrese su contraseña</div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.passUsuario)%>
                <%: Html.ValidationMessageFor(model => model.passUsuario)%>
            </div>

            <div class="editor-label">Repita la contraseña</div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.passUsuario)%>
                <%: Html.ValidationMessageFor(model => model.passUsuario)%>
            </div>

            <legend>
                <br />
                Celular</legend>

            <div class="editor-label">Número</div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.numCelular)%>
                <%: Html.ValidationMessageFor(model => model.numCelular)%>
            </div>
           
           <div class="editor-label">Compañia</div>
            <div class="editor-field">
                <%: Html.DropDownListFor(model => model.id_plan,
                new[]
                {
                    new SelectListItem{ Value = "1", Text = "Claro" },
                    new SelectListItem{ Value = "2", Text = "Movistar" },
                    new SelectListItem{ Value = "3", Text = "Nextel" },
                    new SelectListItem{ Value = "4", Text = "Entel" },
                    new SelectListItem{ Value = "5", Text = "Virgin Mobile" }
                },
                "Compañia")
             %>
                <%: Html.ValidationMessageFor(model => model.numCelular)%>
            </div>

            <div class="editor-label">Tipo</div>
               <div class="editor-field">
                <%: Html.DropDownListFor(model => model.tipo,
                new[]
                {
                    new SelectListItem{ Value = "1", Text = "Plan" },
                    new SelectListItem{ Value = "2", Text = "Prepago" }
                },
                "Tipo")
             %>
                <%: Html.ValidationMessageFor(model => model.tipo)%>
            </div>

            <div class="editor-label">Plan</div>
            <div class="editor-field">
            
            <%: Html.DropDownListFor(model => model.id_plan,
                new[]
                {
                    new SelectListItem{ Value = "1", Text = "Plan 1" },
                    new SelectListItem{ Value = "2", Text = "Plan 2" },
                    new SelectListItem{ Value = "3", Text = "Plan 3" }
                },
                "Plan")
             %>
                <%: Html.ValidationMessageFor(model => model.id_plan)%>
            </div>

             <p>
                <input type="submit" value="Guardar" />&nbsp;
            </p>

        </fieldset>

    <% } %>
</asp:Content>
