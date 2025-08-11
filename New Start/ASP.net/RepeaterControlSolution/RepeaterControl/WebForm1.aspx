<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="RepeaterControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 236px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                
            
                
            <table cellpadding="4" cellspacing="4" class="auto-style2">
                <tr>
                    <td class="auto-style3">
                        <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" GridLines="None" ShowHeader="False">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                         <table border="1" width="500" height="250">
                                    <tr>
                                        <td>
                                            <h3>ID</h3>
                                        </td>
                                        <td>
                                            <asp:Label runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <h3>NAME</h3>
                                        </td>
                                        <td>
                                            <asp:Label runat="server" Text='<%# Eval("name") %>'></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td><h3>GENDER</h3></td>
                                        <td><asp:Label runat="server" Text='<%# Eval("gender") %>'></asp:Label></td>
                                    </tr>

                                    <tr>
                                        <td><h3>CITY</h3></td>
                                        <td><asp:Label runat="server" Text='<%# Eval("city") %>'></asp:Label></td>
                                    </tr>
                                </table>
                                        <br />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                    <td>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate>
                                <table border="1" width="500" height="250">
                                    <tr>
                                        <td>
                                            <h3>ID</h3>
                                        </td>
                                        <td>
                                            <asp:Label runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td>
                                            <h3>NAME</h3>
                                        </td>
                                        <td>
                                            <asp:Label runat="server" Text='<%# Eval("name") %>'></asp:Label>
                                        </td>
                                    </tr>

                                    <tr>
                                        <td><h3>GENDER</h3></td>
                                        <td><asp:Label runat="server" Text='<%# Eval("gender") %>'></asp:Label></td>
                                    </tr>

                                    <tr>
                                        <td><h3>CITY</h3></td>
                                        <td><asp:Label runat="server" Text='<%# Eval("city") %>'></asp:Label></td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                            <SeparatorTemplate>
                                <br />
                            </SeparatorTemplate>
                        </asp:Repeater>
                    </td>
                </tr>
            </table>
                   
        </div>
    </form>
</body>
</html>
