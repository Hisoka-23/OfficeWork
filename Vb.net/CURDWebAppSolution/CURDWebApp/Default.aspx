<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="CURDWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="background-color:blueviolet; font-size:xx-large; color:white" align="center">
        CRUD Opervation In Asp.Net VB
    </div>
    <br />
    <div style="padding:15px">

        <table class="nav-justified">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" Text="Product ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtProductID" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    &nbsp;<asp:Button ID="Button5" runat="server" BackColor="#CC00FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="29px" Text="New" Width="109px" />
                &nbsp;<asp:Button ID="Button4" runat="server" BackColor="#CC00FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="29px" Text="Search" Width="109px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="Product Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtItemName" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" Text="Specification"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtSpecification" runat="server" AccessKey="T" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" Text="Unit"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropUnit" runat="server" Font-Size="Medium" Width="200px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>KG</asp:ListItem>
                        <asp:ListItem>PCS</asp:ListItem>
                        <asp:ListItem>DZN</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Medium" Text="Colour"></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="RadioButtom" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>RED</asp:ListItem>
                        <asp:ListItem>GREEN</asp:ListItem>
                        <asp:ListItem>BLACK</asp:ListItem>
                        <asp:ListItem>Yellow</asp:ListItem>
                        <asp:ListItem>Pink</asp:ListItem>
                        <asp:ListItem>White</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Medium" Text="Insert Date"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtDate" runat="server" Font-Size="Medium" TextMode="Date" ValidateRequestMode="Enabled" ViewStateMode="Enabled" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Medium" Text="Quantity"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtOpeningQty" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Medium" Text="Product Status"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="CheckRegular" runat="server" Font-Size="Medium" Text="Regular" />
                    <asp:CheckBox ID="CheckIrregular" runat="server" Font-Size="Medium" Text="Irregular" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" BackColor="#CC00FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="57px" Text="Insert" Width="109px" />
                &nbsp;<asp:Button ID="Button2" runat="server" BackColor="#CC00FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="57px" Text="Update" Width="109px" />
                &nbsp;<asp:Button ID="Button3" runat="server" BackColor="#CC00FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" Height="57px" Text="Delete" Width="109px" OnClientClick="return confirm('Are you sure to delete?')" />
                </td>
            </tr>
        </table>

        <div align="center">
         <hr />
              <asp:GridView ID="GridView1" runat="server" Width="80%">
                  <HeaderStyle BackColor="#9900FF" ForeColor="White" />
              </asp:GridView>
        </div>
    </div>

</asp:Content>
