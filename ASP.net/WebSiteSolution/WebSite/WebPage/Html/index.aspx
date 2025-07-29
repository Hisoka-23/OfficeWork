<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/WebPage/Html/Master.Master" CodeBehind="index.aspx.vb" Inherits="WebSite.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="stylesheet" href="../Css/Style.css" type="text/css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%-- Body Start--%>

    <div id="body">
        
        <div id="left">
            
            <div id="text-center">
                
                <h1>MEET YOUR FUTURE 
                    <br />
                     WITH ZDS Infotect System</h1>
                <br />
                <br />
                <p>At ZDS Infotect, our endeavor is not to sell you yet another employee management product but help you with a completely customized solution and guide you in your management solution journey.</p>
                
                <div id="image">
                    <img src="../Image/investment_icon.png" alt=""/>
                </div>

            </div>

        </div>

        <div id="right">

            <div id="card">

            <%-- login form start --%>

                <div class="login-container">
                    <h2>Login</h2>
                    <form action="#" method="POST">
                        <div class="input-group">
                            <label for="username">Username or Email</label>
                            <input type="text" id="username" name="username" required>
                        </div>
                        <div class="input-group">
                            <label for="password">Password</label>
                            <input type="password" id="password" name="password" required>
                        </div>
                        <div class="options">
                            <label>
                                <input type="checkbox" name="remember"> Remember Me
                            </label>
                            <a href="#">Forgot Password?</a>
                        </div>
                        <button type="submit">Login</button>
                    </form>
                    <p>Don't have an account? <a href="#">Sign Up</a></p>
                </div>

            <%-- login form end --%>

            </div>

        </div>

    </div>

    <%-- Body End--%>

</asp:Content>
