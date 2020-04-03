<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Validation.aspx.cs" Inherits="WebFormBegin.Validation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Validation Example</h1>
    <div class="form-group">
        <div class="form-text">
            *Fields marked with an asterisk are required
        </div>
    </div>
    <p class="bg-primary">
        <asp:Literal ID="ltMessage" runat="server"/>
           <asp:ValidationSummary ID="valSummaryForm" runat="server" CssClass="bg-error" ValidationGroup="valForm" DisplayMode="BulletList" HeaderText="Please Fix the following errors" Visible="false" />
    </p>
    <div class="form-group">
        <label>*Your Full Name</label>
        <asp:TextBox ID="txtFullName" CssClass="form-control" runat="server"/>
        <asp:RequiredFieldValidator ID="rqFullName" runat="server" ControlToValidate="txtFullName" ValidationGroup="valForm" CssClass="bg-error" ErrorMessage="*Full Name Required" Display="Dynamic" />
    </div>
      <div class="form-group">
        <label>Your Nick Name</label>
        <asp:TextBox ID="txtNickName" CssClass="form-control" runat="server"/>        
    </div>
    <div class="form-group">
        <label>*Your Age</label>
        <asp:TextBox ID="txtAge" CssClass="form-control" runat="server"/>
        <asp:RequiredFieldValidator ID="rqAge" runat="server" ControlToValidate="txtAge" ValidationGroup="valForm" CssClass="bg-error" ErrorMessage="*Age Required" Display="Dynamic" />
        <asp:RangeValidator ID="rvAge" runat="server" ControlToValidate="txtAge" ValidationGroup="valForm" Type="Integer" MinimumValue="4" MaximumValue="120" CssClass="bg-error" ErrorMessage="*Age is not valid" Display="Dynamic" />
    </div>
    <div class="form-group">
        <label>*Name a Price (in USD)</label>
        <asp:TextBox ID="txtPrice" CssClass="form-control" runat="server"/>
        <asp:RequiredFieldValidator ID="rqPrice" runat="server" ControlToValidate="txtPrice" ValidationGroup="valForm" CssClass="bg-error" ErrorMessage="*Price Required" Display="Dynamic" />
        <asp:CompareValidator ID="cvPrice" runat="server" ControlToValidate="txtPrice" Operator="DataTypeCheck" Type="Currency" ValidationGroup="valForm"  CssClass="bg-error" ErrorMessage="Enter a valid Price" Display="Dynamic" />
    </div>
    <div class="form-group">
        <asp:Button ID="btnSubmit" CssClass="btn btn-success" Text="Submit" OnClick="btnSubmit_Click" runat="server" ValidationGroup="valForm" CausesValidation="true" />
    </div>
</asp:Content>
