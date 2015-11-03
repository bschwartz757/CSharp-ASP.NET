<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
             <tr>
                <td>Enter user name</td>
                <td><asp:TextBox ID="txtUserName" runat="server" TextMode="User Name"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Enter password</td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
             <tr>
                <td></td>
                <td><asp:Button ID="btnLogin" runat="server" TextMode="Log In" OnClick="btnLogin_Click"></asp:Button></td>
            </tr>
             <tr>
                <td></td>
                <td><asp:Label ID="lblResult" runat="server" TextMode=""></asp:Label></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
