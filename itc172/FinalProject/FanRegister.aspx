<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FanRegister.aspx.cs" Inherits="FanRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <link href="VenueStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Register Your Venue!</h1>
    <table>
        <tr>
            <td>Your Name</td>
            <td>
                <asp:TextBox ID="txtFanName" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Your Email Address</td>
            <td>
                <asp:TextBox ID="txtFanEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Username</td>
            <td>
                <asp:TextBox ID="txtFanLoginUsername" runat="server">
                </asp:TextBox></td>
        </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="txtFanLoginPasswordPlain" runat="server" TextMode="Password">
                </asp:TextBox></td>
        </tr>
        <tr>
            <td>Confirm Password</td>
            <td>
                <asp:TextBox ID="txtConfirm" runat="server" TextMode="Password">
                </asp:TextBox></td>
        </tr>
         <tr>
            <td><asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /></td>
            <td>
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                </td>
        </tr>
    </table>
        <asp:LinkButton ID="lbLogin" runat="server" PostBackURL="~/Default.aspx">Log in</asp:LinkButton>
    </div>
    </form>
</body>
</html>