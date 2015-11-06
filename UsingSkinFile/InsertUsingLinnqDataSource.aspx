<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertUsingLinnqDataSource.aspx.cs" Inherits="UsingSkinFile.InsertUsingLinnqDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinqDataSource ID="CustomerLinqDataSource" runat="server" ContextTypeName="HomeWorkDB.HomeWorkDBDataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" TableName="Customers">
        </asp:LinqDataSource>
    
    </div>
        <asp:LinqDataSource ID="SuppliersLinqDataSource" runat="server" ContextTypeName="HomeWorkDB.HomeWorkDBDataContext" EnableDelete="True" EnableInsert="True" EnableUpdate="True" EntityTypeName="" TableName="Suppliers">
        </asp:LinqDataSource>
        <br />
        Customers:<asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4" DataKeyNames="cid" DataSourceID="CustomerLinqDataSource" ForeColor="#333333" GridLines="None" Height="50px" Width="125px">
            <AlternatingRowStyle BackColor="White" />
            <CommandRowStyle BackColor="#FFFFC0" Font-Bold="True" />
            <FieldHeaderStyle BackColor="#FFFF99" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="cid" HeaderText="cid" ReadOnly="True" SortExpression="cid" />
                <asp:BoundField DataField="cname" HeaderText="cname" SortExpression="cname" />
                <asp:BoundField DataField="cAddress" HeaderText="cAddress" SortExpression="cAddress" />
                <asp:BoundField DataField="cEmail" HeaderText="cEmail" SortExpression="cEmail" />
                <asp:BoundField DataField="cPhone" HeaderText="cPhone" SortExpression="cPhone" />
                <asp:CommandField ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        </asp:DetailsView>
        <br />
        Suppliers<asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="supID" DataSourceID="SuppliersLinqDataSource" ForeColor="Black" GridLines="Vertical" Height="50px" OnItemInserted="DetailsView2_ItemInserted" Width="125px">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="supID" HeaderText="supID" ReadOnly="True" SortExpression="supID" />
                <asp:BoundField DataField="supName" HeaderText="supName" SortExpression="supName" />
                <asp:BoundField DataField="supAddress" HeaderText="supAddress" SortExpression="supAddress" />
                <asp:CommandField ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        </asp:DetailsView>
    </form>
</body>
</html>
