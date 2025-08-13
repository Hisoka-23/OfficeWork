<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="ListBoxAsp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:ListBox ID="ListBox1" runat="server"  Rows="3" Width="109px" BackColor="#99FF33" Font-Bold="True" Font-Italic="True" Font-Size="Large" ForeColor="#9900FF" SelectionMode="Multiple">
                <%--<asp:ListItem Value="1">India</asp:ListItem>
                <asp:ListItem Value="2">USA</asp:ListItem>
                <asp:ListItem Value="3">Frances</asp:ListItem>
                <asp:ListItem Value="4">China</asp:ListItem>
                <asp:ListItem Value="5">Japan</asp:ListItem>
                <asp:ListItem Value="6">UK</asp:ListItem>--%>
            </asp:ListBox>
            
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="35px" Text="Submit" Width="104px" />
            
        </div>
    </form>
</body>
</html>
