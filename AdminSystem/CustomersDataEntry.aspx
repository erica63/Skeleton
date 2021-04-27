<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" Text=" Customer Id"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" Width="175px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click1" Text="Find" />
        <p>
            <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name" width="96px"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerDOB" runat="server" Text="Customer D.O.B" width="96px"></asp:Label>
            <asp:TextBox ID="txtCustomerDOB" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerEmailAddress" runat="server" Text="Customer Email Address" width="96px"></asp:Label>
            <asp:TextBox ID="txtCustomerEmailAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerAddress" runat="server" Text="Customer Address" width="96px"></asp:Label>
            <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkMember" runat="server" Text="Member" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="height: 22px" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
