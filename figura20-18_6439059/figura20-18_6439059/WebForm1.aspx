<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="figura20_18_6439059.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SportsPlay - Products by Category</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%-- Origen de datos para el DropDownList (Categorías) --%>
            <asp:SqlDataSource runat="server" ID="sdsDropDownListCategory" 
                ConnectionString="<%$ ConnectionStrings:SportsPlay_DB %>" 
                SelectCommand="SELECT CategoryID, Category FROM Category ORDER BY Category;" 
                ProviderName="System.Data.SqlClient" />

            <span class="auto-style1">Category</span><br />
            <asp:DropDownList runat="server" ID="ddlCategory" AutoPostBack="true"
                DataSourceID="sdsDropDownListCategory" DataTextField="Category" 
                DataValueField="CategoryID" /><br />

            <br />

            <%-- Origen de datos para el ListBox (Productos filtrados por Categoría) --%>
            <asp:SqlDataSource runat="server" ID="sdsListBoxProduct" 
                ConnectionString="<%$ ConnectionStrings:SportsPlay_DB %>" 
                SelectCommand="SELECT ProductID, Product FROM Product WHERE CategoryID = @CategoryID ORDER BY Product;" 
                ProviderName="System.Data.SqlClient">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlCategory" Name="CategoryID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>

            <asp:Label runat="server" Text="Product" /><br />
            <asp:ListBox runat="server" ID="libProduct" 
                DataSourceID="sdsListBoxProduct" DataTextField="Product" 
                DataValueField="ProductID" Rows="7" />
        </div>
    </form>
</body>
</html>