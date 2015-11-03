<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<link href="Assignment1.css" rel="stylesheet" />
<head runat="server">
    <title>Age Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="myCalendar" runat="server"></asp:Calendar>
        <p>Enter your name<asp:TextBox ID="txtName" runat="server" CssClass="textback"></asp:TextBox></p>
        <p>Enter your birth date (month/day/year):
            <asp:TextBox ID="txtDate" runat="server" CssClass="textback" type="Date"></asp:TextBox>
        </p>
        <asp:Button ID="btnCalculate" runat="server" Text="Get Age" OnClick="btnCalculate_Click" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
