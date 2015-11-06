<%@ Page Language="C#" Theme="First_Themes" AutoEventWireup="true" CodeBehind="SkinDemo.aspx.cs" Inherits="UsingSkinFile.SkinDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Buttons</h1>
        <asp:Button ID="Button1" runat="server" Text="Button" /><br />
        <asp:Button ID="Button2" runat="server" Text="Button" SkinID="RedButton" /><br />
        <asp:Button ID="Button3" runat="server" Text="Button" /><br />
        <h1>TextBoxes</h1>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="TextBox2" SkinID="GoldText" runat="server">Nothing</asp:TextBox><br />
    </div>
    </form>
</body>
</html>
