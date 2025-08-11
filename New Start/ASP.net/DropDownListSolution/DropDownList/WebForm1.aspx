<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="DropDownList.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:DropDownList ID="DropDownList1" runat="server" Height="36px" Width="132px">
                <%--<asp:ListItem Value="5" Selected="True">Select</asp:ListItem>
                <asp:ListItem Value="3">Delhi</asp:ListItem>
                <asp:ListItem Value="1">Noida</asp:ListItem>
                <asp:ListItem Value="2" Text="Hyderabad"></asp:ListItem>
                <asp:ListItem Value="4" Enabled="false">Japan</asp:ListItem>--%>
            </asp:DropDownList>
            
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="39px" Text="Submit" Width="91px" />
            
        </div>
    </form>
</body>
</html>
