<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cv12Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:TextBox ID="operandA" runat="server"></asp:TextBox>
        <asp:DropDownList ID="operatorDropDown" runat="server">
            <asp:ListItem Selected="True">+</asp:ListItem>
            <asp:ListItem>-</asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
            <asp:ListItem>/</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="operandB" runat="server"></asp:TextBox>
        <asp:Button ID="spocti" runat="server" Text="Spočti" OnClick="spocti_Click" style="height: 26px" />
        </div>
    </form>
</body>
</html>
