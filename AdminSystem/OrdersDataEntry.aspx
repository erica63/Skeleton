﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblOrderId" runat="server" Text="Order ID" width="118px"></asp:Label>
            <asp:TextBox ID="txtOrderId" runat="server" TextMode="Number"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" width="118px"></asp:Label>
        <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblOrderPrice" runat="server" Text="Shipping Address" width="118px"></asp:Label>
            <asp:TextBox ID="txtShippingAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblOrderDesc" runat="server" Text="Order Description" width="118px"></asp:Label>
            <asp:TextBox ID="txtOrderDesc" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblOrderRating" runat="server" Text="Order Quantity" width="118px"></asp:Label>
            <asp:TextBox ID="txtOrderQuantity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkOrderDelivery" runat="server" Text="Order Delivery" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        &nbsp;<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
