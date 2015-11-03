﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
            <td>First Name</td>
            <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Last Name</td>
            <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Email</td>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>User Name</td>
            <td><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Password</td>
            <td><asp:TextBox ID="txtPassword" runat="server"  TextMode="Password"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Confirm Password</td>
            <td><asp:TextBox ID="txtConfirm" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
         <tr>
            <td>
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /></td>
            <td>
                <asp:Label ID="lblErrorSuccess" runat="server" Text=""></asp:Label></td>
        </tr>
       
    </table>
        <asp:LinkButton ID="LbLogin" runat="server" 
PostBackUrl="~/Default.aspx">Log in</asp:LinkButton>
    </div>
        <asp:RequiredFieldValidator ID="LastNameValidator" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last Name is Required"></asp:RequiredFieldValidator> <br />
        <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="txtEmail" ErrorMessage="You must enter an email address"></asp:RequiredFieldValidator> <br />
        <asp:RegularExpressionValidator ID="emailRegularExpression" runat="server" ControlToValidate="txtEmail" ErrorMessage="Not a valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator> 
    </form>
</body>
</html>
