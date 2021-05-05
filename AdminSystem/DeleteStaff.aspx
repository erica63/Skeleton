<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStaff.aspx.cs" Inherits="DeleteStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?
            <br />
            <br />
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 20px; top: 44px; position: absolute; width: 75px; margin-bottom: 0px" Text="Yes" />
        </div>
        <asp:Button ID="btnNO" runat="server" style="z-index: 1; left: 111px; top: 44px; position: absolute; width: 68px" Text="No" OnClick="btnNO_Click" />
    </form>
</body>
</html>
