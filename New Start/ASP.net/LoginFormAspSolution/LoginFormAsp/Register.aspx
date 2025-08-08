<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Register.aspx.vb" Inherits="LoginFormAsp.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            border: 5px black solid;
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

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="#999999" Font-Size="Large" ForeColor="Red" />
            
            <table cellpadding="3" cellspacing="3"  class="auto-style1">
                <tr>
                    <td class="auto-style2"  colspan="2">SINGUP FORM</td>
                </tr>
                <tr>
                    <td class="auto-style3">FIRST NAME</td>
                    <td>
                        <asp:TextBox ID="FirstName" runat="server" Height="35px" Width="206px"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" Display="Dynamic" ErrorMessage="Please Enter First Name" ForeColor="Red" SetFocusOnError="True" ControlToValidate="FirstName">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">LAST NAME</td>
                    <td>
                        <asp:TextBox ID="LastName" runat="server" Height="35px" Width="206px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ErrorMessage="Please Enter Last Name" ForeColor="Red" SetFocusOnError="True" ControlToValidate="LastName">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">GENDER</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="35px" Width="213px">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator InitialValue="Select" ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ErrorMessage="Please Enter Select Gender" ForeColor="Red" SetFocusOnError="True" ControlToValidate="DropDownList1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">EMAIL</td>
                    <td>
                        <asp:TextBox ID="Email" runat="server" Height="35px" Width="206px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic" ErrorMessage="Please Enter Email" ForeColor="Red" SetFocusOnError="True" ControlToValidate="Email">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Email" Display="Dynamic" ErrorMessage="Please Enter Valid Email" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">ADDRESS</td>
                    <td>
                        <asp:TextBox ID="Address" runat="server" Height="35px" Width="206px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic" ErrorMessage="Please Enter Address" ForeColor="Red" SetFocusOnError="True" ControlToValidate="Address">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">USERNAME</td>
                    <td>
                        <asp:TextBox ID="UserName" runat="server" Height="35px" Width="206px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="UserName" Display="Dynamic" ErrorMessage="Please Enter User Name" ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">PASSWORD</td>
                    <td>
                        <asp:TextBox ID="Password" runat="server" Height="35px" Width="206px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Display="Dynamic" ErrorMessage="Please Enter Password" ForeColor="Red" SetFocusOnError="True" ControlToValidate="Password">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Password" Display="Dynamic" ErrorMessage="Please Enter Strong Password" ForeColor="Red" SetFocusOnError="True" ValidationExpression="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">CONFIRM PASSWORD</td>
                    <td>
                        <asp:TextBox ID="ConfirmPassword" runat="server" Height="35px" Width="206px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Display="Dynamic" ErrorMessage="Please Enter Confirm Password" ForeColor="Red" SetFocusOnError="True" ControlToValidate="ConfirmPassword">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="Password is not identical" ForeColor="Red" SetFocusOnError="True">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Height="39px" Text="Register" Width="91px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>
                        <a href="Login.aspx">Go To Login Form</a>
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
