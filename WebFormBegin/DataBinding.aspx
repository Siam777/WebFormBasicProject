<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DataBinding.aspx.cs" Inherits="WebFormBegin.DataBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Database binding Example</h1>
    <hr />
    <h4>
       <asp:Literal ID="ltError" runat="server" />
    </h4>
    <asp:GridView ID="gvEmployee" CssClass="table table-striped color-table" runat="server" AutoGenerateColumns="false" OnRowDeleting="gvEnployee_RowDeleting" OnRowEditing="gvEnployee_RowEditing" OnRowUpdating="gvEnployee_RowUpdating" OnRowCancelingEdit="gvEnployee_RowCancelingEdit">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:HiddenField ID="hdnEmployeeId" runat="server" Value='<%#DataBinder.Eval(Container.DataItem,"EmployeeId") %>' />                  
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="EmployeeName" HeaderText="EmployeeName" />
            <asp:BoundField DataField="Age" HeaderText="Age" />
            <asp:BoundField DataField="Address" HeaderText="Address" />
            <asp:BoundField DataField="DepartmentId" HeaderText="DepartmentId" />
            <asp:CommandField ShowEditButton="true" />
            <asp:CommandField ShowDeleteButton="true" />
        </Columns>
    </asp:GridView>
    <div class="row color-table">
        <asp:Button ID="btnAddRow" runat="server" Text="Add New Row" CssClass="btn btn-primary" OnClick="btnAddRow_Click"/>
    </div>
</asp:Content>