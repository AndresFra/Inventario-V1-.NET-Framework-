<%@ page language="C#" autoeventwireup="true" codebehind="ReportViewer.aspx.cs" inherits="Inventario.RDCL_Report.ReportViewer" %>

<%@ register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<%--<%@ script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script %>
<%@ script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%--<div class="row" style="text-align:right;padding:5px;">
            <a href="~/RDCL_Report/ReportViewer.aspx" class="btn btn-outline-dark">PDF</a>
        </div>--%>
        <div style="height: 642px; width: 1847px; margin-top: 0px">
            <br />
            <br />
            <asp:ScriptManager runat="server"></asp:ScriptManager>
            <rsweb:reportviewer id="reportviewerEquipo" runat="server" height="524px" width="1821px">
            </rsweb:reportviewer>
        </div>
    </form>
   <%-- <div class="col-md-12">
        <asp:HyperLink NavigateUrl="~/CRUD/EquipoIndex" class="btn btn-primary" runat="server" CssClass="button" Text="Volver al menu" Width="165px"></asp:HyperLink>
    </div>--%>
</body>
</html>

<style type="text/css">
    .button {
        display: block;
        background: #F3F000;
        padding: 10px;
        text-align: center;
        border-radius: 5px;
        border: 1px solid #e1e1e2;
        color: #000;
        font-weight: bold;
    }
</style>
