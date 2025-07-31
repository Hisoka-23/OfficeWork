<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/WebPage/HTML/Master.Master" CodeBehind="Index.aspx.vb" Inherits="Z_Pay.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../CSS/Index.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div id="center">

        <div id="card">
            <%-- login form start --%> 
            <form>
                <div id="div1">
                    <img src="../Image/zds_logo.png" />
                </div>
                <div id="div2">
                    <input name="UserId" type="text" placeholder="User Id" id="userId" />
                </div>
                <div id="div3">
                    <input name="Password" type="Password" placeholder="Password" id="passWord" />
                </div>
                <div id="div4">
                    <input name="Captue" type="Capture" placeholder="Capture" id="Capture" />
                </div>
                <div id="div5">
                    <input type="submit" name="btnLogin" value="Log In" onclick="return submititsEncry();" id="btnLogin"/>
                </div>
            </form>
            <%-- login form end --%>
       </div>

    </div>

</asp:Content>
