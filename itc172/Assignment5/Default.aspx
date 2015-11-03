<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Venue Login</title>
    <link href="VenueStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Log In to Your Account</h1>
    <table>
        <tr>
            <td class="login">Username</td>
            <td class="login">
                <asp:TextBox ID="txtVenueLoginUserName" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td class="login">Password</td>
            <td class="login">
                <asp:TextBox ID="txtVenueLoginPasswordPlain" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </td>
            <td>
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </td>
         </tr>
        </table>
        <p><asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/VenueRegister.aspx">Register</asp:LinkButton> |
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/VenueAddShow.aspx">Add Show</asp:LinkButton> |
        <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/ViewShows.aspx">View Shows</asp:LinkButton></p>    
    </div>
    </form>
</body>
</html>