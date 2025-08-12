<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="AutoCompleteExtenderControl.WebForm1" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 400px;
        }
        .auto-style2 {
            width: 99px;
        }
        .AutoExtenderList{
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: .8em;
            margin: 0px;
            font-weight: normal;
            line-height: 20px;
            padding: 0px;
            background-color: white;
        }
        .AutoExtenderListItem{
            border-bottom:dotted 1px #006699;
            cursor: pointer;
            color: maroon;
            left: auto;
            margin: 0px;
        }
        .AutoExtenderHighlight{
            color:white;
            background-color: #006699;
            cursor: pointer;
            margin: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <table cellpadding="4" cellspacing="4" class="auto-style1">
                <tr>
                    <td class="auto-style2">Select City</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Height="33px" Width="175px"></asp:TextBox>
                        <ajaxToolkit:AutoCompleteExtender CompletionListCssClass="AutoExtenderList" CompletionListItemCssClass="AutoExtenderListItem" CompletionListHighlightedItemCssClass="AutoExtenderHighlight" ID="TextBox1_AutoCompleteExtender" runat="server" BehaviorID="TextBox1_AutoCompleteExtender" CompletionInterval="100" DelimiterCharacters="" MinimumPrefixLength="1" ServicePath="" TargetControlID="TextBox1" ServiceMethod="GetCompletional">
                        </ajaxToolkit:AutoCompleteExtender>
                    </td>
                </tr> 
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Height="37px" Text="Submit" Width="95px" />
                    </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
