<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="QueryStringDemo.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 822px;
            height: 183px;
        }
        .auto-style2 {
            width: 207px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table cellpadding="4" cellspacing="4" class="auto-style1">
                <tr>
                    <td class="auto-style2">EMPLOYEE ID</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Height="35px" Width="265px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">EMPLOYEE NAME</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Height="35px" Width="265px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">EMPLOYEE AGE</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Height="35px" Width="265px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
