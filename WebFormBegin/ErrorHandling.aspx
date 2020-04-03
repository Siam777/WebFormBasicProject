<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ErrorHandling.aspx.cs" Inherits="WebFormBegin.ErrorHandling" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Error Handling</h1>
    <asp:Label ID="lblMessage" CssClass="bg-error" runat="server" Visible="false"></asp:Label>

    <div class="form-group">
        <label>This should be decimal: </label>
        <asp:TextBox ID="txtDecimal" CssClass="form-control" runat="server" />
    </div>
    <div class="form-group">
        <asp:Button ID="btnSubmit" CssClass="btn btn-success" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
    </div>
</asp:Content>