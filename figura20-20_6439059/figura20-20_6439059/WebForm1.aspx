<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="figura20_20_6439059.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Productos por Sesión</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource runat="server" ID="sdsListBoxProduct"
                ConnectionString="<%$ ConnectionStrings:SportsPlay_DB %>"
                SelectCommand="SELECT ProductID, Product FROM Product WHERE CategoryID = @CategoryID ORDER BY Product;">
                <SelectParameters>
                    <asp:SessionParameter Direction="Input" Name="CategoryID"
                        SessionField="intCategoryID" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:Label runat="server" Text="Product" /><br />
            <asp:ListBox runat="server" ID="libProduct"
                DataSourceID="sdsListBoxProduct"
                DataTextField="Product"
                DataValueField="ProductID"
                Rows="7" />
        </div>
    </form>
</body>
</html>
