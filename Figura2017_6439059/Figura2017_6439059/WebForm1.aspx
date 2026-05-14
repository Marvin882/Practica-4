<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Figura2017_6439059.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Type Product"></asp:Label>
        </div>
    <asp:SqlDataSource ID="sdsListBoxProduct" runat="server" 
    ConnectionString="<%$ ConnectionStrings:SportsPlay_BD %>" 
    SelectCommand="SELECT productID, Product FROM Product ORDER BY Product;">
</asp:SqlDataSource>
&nbsp;<asp:ListBox ID="ListBox1" runat="server" DataSourceID="sdsListBoxProduct" DataTextField="Product" DataValueField="ProductID" Rows="7"></asp:ListBox>
    </form>
</body>
</html>
