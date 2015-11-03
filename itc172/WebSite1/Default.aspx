<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="BookKey" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
            <Columns>
                <asp:BoundField DataField="BookKey" HeaderText="BookKey" ReadOnly="True" SortExpression="BookKey" />
                <asp:BoundField DataField="BookTitle" HeaderText="BookTitle" SortExpression="BookTitle" />
                <asp:BoundField DataField="BookEntryDate" HeaderText="BookEntryDate" SortExpression="BookEntryDate" />
                <asp:BoundField DataField="BookISBN" HeaderText="BookISBN" SortExpression="BookISBN" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BookReviewDbConnectionString1 %>" DeleteCommand="DELETE FROM [Book] WHERE [BookKey] = @BookKey" InsertCommand="INSERT INTO [Book] ([BookTitle], [BookEntryDate], [BookISBN]) VALUES (@BookTitle, @BookEntryDate, @BookISBN)" ProviderName="<%$ ConnectionStrings:BookReviewDbConnectionString1.ProviderName %>" SelectCommand="SELECT [BookKey], [BookTitle], [BookEntryDate], [BookISBN] FROM [Book]" UpdateCommand="UPDATE [Book] SET [BookTitle] = @BookTitle, [BookEntryDate] = @BookEntryDate, [BookISBN] = @BookISBN WHERE [BookKey] = @BookKey">
            <DeleteParameters>
                <asp:Parameter Name="BookKey" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="BookTitle" Type="String" />
                <asp:Parameter Name="BookEntryDate" Type="DateTime" />
                <asp:Parameter Name="BookISBN" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="BookTitle" Type="String" />
                <asp:Parameter Name="BookEntryDate" Type="DateTime" />
                <asp:Parameter Name="BookISBN" Type="String" />
                <asp:Parameter Name="BookKey" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
