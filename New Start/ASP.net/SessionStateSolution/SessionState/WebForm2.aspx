<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="SessionState.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 73px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 46px">
            
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/WebForm3.aspx">Go to page 3</asp:LinkButton>
            
        </div>
    </form>
</body>
</html>
