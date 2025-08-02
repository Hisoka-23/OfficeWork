<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="SaveMultipleFile.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
    <div>
        <h3>Select PDF or CSV files to upload:</h3>
        <input type="file" id="MultiFileUpload" name="MultiFileUpload" multiple="multiple" />
        <br /><br />
        <asp:Button ID="btnUpload" runat="server" Text="Upload Files" OnClick="btnUpload_Click" />
        <br /><br />
        <asp:Label ID="lblStatus" runat="server" EnableViewState="false" />
    </div>
</form>

</body>
</html>
