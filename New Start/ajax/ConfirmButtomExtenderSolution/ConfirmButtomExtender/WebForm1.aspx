<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="ConfirmButtomExtender.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 213px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>

            <table cellpadding="4" cellspacing="4" class="auto-style1">
                <tr>
                    <td class="auto-style2">Search by Id</td>
                    <td>
                        <asp:TextBox ID="SearchTextBox" runat="server" Height="46px" Width="177px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="SearchButton" runat="server" Height="38px" Text="Search" Width="74px" />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Name</td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Height="46px" Width="177px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Profile</td>
                    <td>
                        <asp:TextBox ID="ProfileTextBox" runat="server" Height="46px" Width="177px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" Height="38px" Text="Update" Width="74px" />
                        <ajaxToolkit:ConfirmButtonExtender ID="UpdateButtonConfirmExtender" runat="server" BehaviorID="UpdateButtonConfirmExtender" ConfirmText="are really want to update a profile" TargetControlID="UpdateButton">

                        </ajaxToolkit:ConfirmButtonExtender>
&nbsp;
                        <asp:Button ID="DeleteButton" runat="server" Height="38px" Text="Delete" Width="74px" />
                        <ajaxToolkit:ConfirmButtonExtender ID="DeleteConfirmButtonExtender1" runat="server" BehaviorID="DeleteButtonConfirmExtender" ConfirmText="are really want to delete a profile" TargetControlID="DeleteButton">

                        </ajaxToolkit:ConfirmButtonExtender>
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
