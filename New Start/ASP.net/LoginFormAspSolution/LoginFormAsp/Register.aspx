<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Register.aspx.vb" Inherits="LoginFormAsp.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            border: 2px black solid;
            margin: 75px auto;
        }
       
        .auto-style2 {
            text-align: center;
        }

        .auto-style3 {
            width: 218px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <table cellpadding="3" cellspacing="3"  class="auto-style1">
                <tr>
                    <td class="auto-style2"  colspan="2">SINGUP FORM</td>
                </tr>
                <tr>
                    <td class="auto-style3">FIRST NAME</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Height="35px" Width="206px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">LAST NAME</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Height="35px" Width="206px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">GENDER</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="35px" Width="213px">
                            <asp:ListItem>Selected</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">EMAIL</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Height="35px" Width="206px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">ADDRESS</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" Height="35px" Width="206px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">PASSWORD</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server" Height="35px" Width="206px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">CONFIRM PASSWORD</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server" Height="35px" Width="206px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Height="39px" Text="Register" Width="91px" />
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
