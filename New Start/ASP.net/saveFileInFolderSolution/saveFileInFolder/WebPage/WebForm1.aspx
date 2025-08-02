<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="saveFileInFolder.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
<%--            <input type="file" id="MultiFileUpload" name="MultiFileUpload" multiple />--%>
            <asp:Button ID="btnUpload" runat="server" Text="Upload File" OnClick="btnUpload_Click" />
            <asp:Label ID="lblStatus" runat="server" />

    </div>
    </form>
</body>
</html>
