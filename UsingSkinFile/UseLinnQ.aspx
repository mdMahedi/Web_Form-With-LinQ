<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UseLinnQ.aspx.cs" Inherits="UsingSkinFile.UseLinnQ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="HomeWorkDB.HomeWorkDBDataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" TableName="Products">
        </asp:LinqDataSource>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="pid" DataSourceID="LinqDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="pid" HeaderText="Product ID" ReadOnly="True" SortExpression="pid" />
                <asp:BoundField DataField="pName" HeaderText="Product Name" SortExpression="pName" />
                <asp:BoundField DataField="PQty" HeaderText="Quantity" SortExpression="PQty" />
                <asp:BoundField DataField="pPrice" HeaderText="Price" SortExpression="pPrice" />
                <asp:BoundField DataField="supID" HeaderText="Supplier" SortExpression="supID" />
                <asp:CommandField HeaderText="Insert / Delete" ShowDeleteButton="True" ShowEditButton="True" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </form>
</body>
</html>
