<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StocksDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblItemId" runat="server" Text="Item Identification Number"></asp:Label>
        <asp:TextBox ID="txtItemId" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblItemName" runat="server" Text="Item Name"></asp:Label>
            <asp:TextBox ID="txtItemName" runat="server" width="446px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkItemAvailable" runat="server" Text="Item Available" />
        <p>
            <asp:Label ID="lblDateItemAdded" runat="server" Text="Date Item Added"></asp:Label>
            <asp:TextBox ID="txtDateItemAdded" runat="server" width="358px"></asp:TextBox>
        </p>
        <asp:Label ID="lblItemSize" runat="server" Text="ItemSize"></asp:Label>
        <asp:TextBox ID="txtItemSize" runat="server" width="462px"></asp:TextBox>
        <p>
            <asp:Label ID="lblStockLevel" runat="server" Text="Stock Level"></asp:Label>
            <asp:TextBox ID="txtStockLevel" runat="server" width="420px"></asp:TextBox>
        </p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
