<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<string>" %>
<fieldset>
    <%=Html.LabelForModel() %>
    <%=Html.TextBox("", Model, new { @class = "text large" } ) %>
    <%=Html.ValidationMessage("", "*") %>
</fieldset>