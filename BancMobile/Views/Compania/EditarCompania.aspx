<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<BancMobile.Models.Modelos.CompaniaModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	EditarCompania
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>EditarCompania</h2>

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.idCompania) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.idCompania) %>
                <%: Html.ValidationMessageFor(model => model.idCompania) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.nombreCompania) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.nombreCompania) %>
                <%: Html.ValidationMessageFor(model => model.nombreCompania) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

