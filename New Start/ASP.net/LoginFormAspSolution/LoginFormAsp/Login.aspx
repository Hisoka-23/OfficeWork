<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="LoginFormAsp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            text-align: center;
            font-size: 30px;
        }

        table{
            margin: 75px auto;
            width: 300px;
            border: 5px black ridge;
        }
        .auto-style3 {
            width: 412px;
        }
        .auto-style4 {
            text-align: center;
            font-size: 30px;
            width: 412px;
        }

        #register{
            font-size: 16px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main">
            
            <table cellpadding="4" cellspacing="6">
                <tr>
                    <td class="auto-style2" colspan="2">LOGIN</td>
                </tr>
                <tr>
                    <td class="auto-style3">USERNAME</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Height="34px" Width="270px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserTextBox" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Please Enter User Name" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">PASSWORD</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Height="34px" Width="270px" TextMode="Password"></asp:TextBox>
                        <input type="checkbox" onchange="document.getElementById('TextBox2').type = this.checked ?  'text' : 'password' " />Show Password
                        <asp:RequiredFieldValidator ID="PassTextBox" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Please Enter Password" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Height="37px" Text="Login" Width="116px" />
                    </td>
                </tr>
                <tr>
                    <td id="register" colspan="2">
                        <a href="Register.aspx">Not Registered yet ? click here</h6>
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
