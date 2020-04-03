<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebFormBegin.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <div runat="server" id="divMessage" class="message">Welcome to the Contact page</div>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>
    <div>
        <label>Name</label>
        <asp:TextBox ID="txtName" runat="server" CssClass="Text-Box"/>
        <asp:RequiredFieldValidator runat="server" ID="rfvName" ControlToValidate="txtName" ErrorMessage="Required" Display="Dynamic" />

    </div>
     <div>
        <label>Email</label>
        <asp:TextBox ID="textEmail" runat="server" />
         <asp:RegularExpressionValidator runat="server" ID="revEmail" ControlToValidate="textEmail" ErrorMessage="Valid Email address is required" ValidationExpression="^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$" Display="Dynamic"/>
         <asp:RequiredFieldValidator runat="server" ID="rfvEmail" ControlToValidate="textEmail" ErrorMessage="Required" Display="Dynamic" />
    </div>
     <div>
        <label>Age</label>
        <asp:TextBox ID="txtAge" runat="server" />
    </div>
    <div>
        <label>Favourite Color</label>
        <asp:DropDownList ID="ddlColor" runat="server">
            <asp:ListItem Text="Please Choose a Color" Value="" />
             <asp:ListItem Text="Blue" Value="Blue"/>
             <asp:ListItem Text="Red" Value="Red" />
             <asp:ListItem Text="Pink" Value="Pink" />
             <asp:ListItem Text="Black" Value="Black" />
        </asp:DropDownList>
        <asp:RequiredFieldValidator runat="server" ID="rfvColor" ControlToValidate="ddlColor" ErrorMessage="Color Required" />
    </div>
    <div>
        <asp:Button ID ="btnSubmit" runat="server" Text ="Submit Info" OnClick="btnSubmit_Click" />
    </div>
    <div class="message">
         <asp:Literal ID="ltMessage" runat="server"/>
    </div>   
    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
