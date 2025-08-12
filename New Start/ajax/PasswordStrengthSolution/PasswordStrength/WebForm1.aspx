<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="PasswordStrength.WebForm1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 171px;
        }

        .BarBorder{
            border: 2px black ridge;
            width: 120px;
        }
        
        .Poor{
            background-color: darkred;
        }
        .weak{
            background-color: red;
        }
        .Average{
            background-color: yellow;
        }
        .Strong{
            background-color: blue;
        }
        .very{
            background-color: green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <table cellpadding="3" cellspacing="3" class="auto-style1">
                <tr>
                    <td class="auto-style2">Enter Passsword</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Height="37px" Width="179px"></asp:TextBox>
                        <ajaxToolkit:PasswordStrength ID="PasswordStrength1" runat="server" TargetControlID="TextBox1" MinimumLowerCaseCharacters="3" MinimumNumericCharacters="2" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="3" PreferredPasswordLength="8" PrefixText="Password Strength: " RequiresUpperAndLowerCaseCharacters="True" HelpStatusLabelID="Label1" TextStrengthDescriptions="Poor; weak,; Average; Strong: very Strong" StrengthIndicatorType="BarIndicator" BarBorderCssClass="BarBorder" TextCssClass="Poor; weak,; Average; Strong: very" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
