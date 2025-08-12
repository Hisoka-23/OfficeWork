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
                <asp:listitem value="-1" selected="true">Select City</asp:listitem>
				<asp:listitem value="1">Gura City</asp:listitem>
                <asp:listitem value="2">delhi</asp:listitem>
                <asp:listitem value="3">noida</asp:listitem>
                <asp:listitem value="4" text="hyderabad"></asp:listitem>
                <asp:listitem value="5" enabled="false">japan</asp:listitem>
            </asp:DropDownList>
            
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="39px" Text="Submit" Width="91px" />
            
        </div>
    </form>
</body>
</html>
