<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="QueryStringDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        .auto-style1 {
            width: 839px;
            height: 265px;
        }
        .auto-style2 {
            width: 314px;
        }
        .auto-style3 {
            width: 821px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table cellpadding="5" cellspacing="5" class="auto-style1">
                <tr>
                    <td class="auto-style2">EMPLOYEE ID</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="IdTextBox" runat="server" Height="29px" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">EMPLOYEE NAME</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="NameTextBox" runat="server" Height="29px" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">EMPLOYEE AGE</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="AgeTextBox" runat="server" Height="29px" Width="240px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Button ID="Button1" runat="server" Height="41px" Text="Send" Width="112px" />
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
