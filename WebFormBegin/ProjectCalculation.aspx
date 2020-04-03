<%@ Page Language="C#" AutoEventWireup="true"MasterPageFile="~/Site.Master" CodeBehind="ProjectCalculation.aspx.cs" Inherits="WebFormBegin.ProjectCalculation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Get a Quote for your Custom Project</h1>
    <p class="lead">Base Price :<asp:Literal ID="ltBasePrice" runat="server"/></p>
    <p>We Primarily Serve the western half of the united states. East of Colorado we charge a flat state fee rate of $49.99. West Coast rates are less</p>

    <div class="form-group">
        <label>
            Your State
        </label>
        <asp:DropDownList ID="ddlState" CssClass="form-control" OnSelectedIndexChanged="ddlState_SelectedIndexChanged" AutoPostBack="true" runat="server">
            <asp:ListItem Value="">Select Your State</asp:ListItem>
            <asp:ListItem Value="AL">Alabama</asp:ListItem>
            <asp:ListItem Value="AK">Alaska</asp:ListItem>
            <asp:ListItem Value="AZ">Arizoana</asp:ListItem>
            <asp:ListItem Value="AR">Arkansas</asp:ListItem>
            <asp:ListItem Value="CA">California</asp:ListItem>
            <asp:ListItem Value="CO">Colorado</asp:ListItem>
            <asp:ListItem Value="CT">ConnectiCut</asp:ListItem>
            <asp:ListItem Value="DC">District of Columbia</asp:ListItem>
            <asp:ListItem Value="DE">Delware</asp:ListItem>
            <asp:ListItem Value="FL">Florida</asp:ListItem>
            <asp:ListItem Value="GA">Georgia</asp:ListItem>
            <asp:ListItem Value="HI">Hawali</asp:ListItem>
            <asp:ListItem Value="ID">Idaho</asp:ListItem>
            <asp:ListItem Value="IL">Illinois</asp:ListItem>
            <asp:ListItem Value="IN">Indiana</asp:ListItem>
            <asp:ListItem Value="NW">NewYork</asp:ListItem>
            <asp:ListItem Value="WA">Washington</asp:ListItem>
            <asp:ListItem Value="OR">Oregon</asp:ListItem>
            <asp:ListItem Value="NV">Nevada</asp:ListItem>
            <asp:ListItem Value="MT">Montana</asp:ListItem>
            <asp:ListItem Value="WY">Wyoming</asp:ListItem>
            <asp:ListItem Value="UT">Utah</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="jumbotron">
        <h3>Your Custom Price: <asp:Literal ID="ltCustomPrice" runat="server"  Text="(Select Your Text)"/></h3>
    </div>
</asp:Content>