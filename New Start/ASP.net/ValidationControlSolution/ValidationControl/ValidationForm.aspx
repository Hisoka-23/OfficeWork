<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ValidationForm.aspx.vb" Inherits="ValidationControl.ValidationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 337px;
            margin-top: 0px;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 212px;
        }
        .auto-style4 {
            width: 212px;
            height: 42px;
        }
        .auto-style5 {
            height: 42px;
        }
    </style>
</head>
<body style="height: 439px">
    <form id="form1" runat="server">
        
        <div style="height: 396px">
            <h2>Employee registration form</h2>

            <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="Silver" Font-Size="Large" ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Eymployee NAME</td>
                <td>
                    <asp:TextBox ID="NameTextBox" runat="server" Height="31px" Width="426px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="NameTextBox" ErrorMessage="Please Enter Name" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Employee EMAIL</td>
                <td>
                    <asp:TextBox ID="EmailTextBox" runat="server" Height="31px" Width="426px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="Pls Enter Email" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="EmailTextBox" Display="Dynamic" ErrorMessage="Email invalid" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">RE-ENTER EMAIL</td>
                <td>
                    <asp:TextBox ID="ReEnterEmailTextBox" runat="server" Height="31px" Width="426px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ReEnterEmailTextBox" Display="Dynamic" ErrorMessage="Pls Re-enter Email" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="ReEnterEmailTextBox" Display="Dynamic" ErrorMessage="Invalid email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="EmailTextBox" ControlToValidate="ReEnterEmailTextBox" Display="Dynamic" ErrorMessage="Email is not same " ForeColor="Red" SetFocusOnError="True">*</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">DEPTNMENT</td>
                <td>
                    <asp:TextBox ID="DeptmentTextBox" runat="server" Height="35px" Width="425px"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="DeptmentTextBox" Display="Dynamic" ErrorMessage="Please Enter Deptment" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="DeptmentTextBox" Display="Dynamic" ErrorMessage="Class Should be from 1 to 4" ForeColor="Red" MaximumValue="4" MinimumValue="1" SetFocusOnError="True" Type="Integer">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">SALARY</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox1" runat="server" Height="31px" Width="424px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Please Enter salary amount" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Salary should be in 36000.00 to 56000.00" ForeColor="Red" MaximumValue="56000.00" MinimumValue="36000.00" SetFocusOnError="True" Type="Double">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" Width="183px" />
                </td>
            </tr>
        </table>

        </div>

    </form>
</body>
</html>
