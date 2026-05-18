<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="figura20_19_6439059.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Buscador de Productos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%-- Origen de datos para filtrar el ListBox según el texto escrito --%>
            <asp:SqlDataSource runat="server" ID="sdsListBoxProduct" 
                ConnectionString="<%$ ConnectionStrings:SportsPlay_DB %>" 
                SelectCommand="SELECT ProductID, Product FROM Product WHERE Product LIKE '%' + @Product + '%' ORDER BY Product;">
                <SelectParameters>
                    <asp:ControlParameter ControlID="txtProduct" Direction="Input" Name="Product" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

            <%-- Controles de la interfaz de usuario --%>
            <asp:Label runat="server" Text="Product" /><br />
            <asp:TextBox runat="server" ID="txtProduct" />
            <asp:Button runat="server" ID="btnFilter" Text="Filter" /><br />
            
            <asp:ListBox runat="server" ID="libProduct" 
                DataSourceID="sdsListBoxProduct" DataTextField="Product" 
                DataValueField="ProductID" Rows="7" />
        </div>
    </form>
</body>
</html>
