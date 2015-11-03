<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <h1>Time of Day</h1>
    <form id="form1" runat="server">              
        <asp:Image ID="Image1" runat="server" ImageUrl="~/IMG_2161.JPG" Height="500px" Width="500px"/>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Timer ID="Timer1" runat="server" Enabled="true" OnTick="Timer1_Tick" Interval="1000" ></asp:Timer>
            <asp:Label ID="lblTime" runat="server" Text="Label"></asp:Label>
        </contenttemplate>
    </asp:UpdatePanel>
    </form>
    </div>
</body>
</html>
