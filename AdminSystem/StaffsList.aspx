<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 45px; top: 32px; position: absolute; height: 347px; width: 393px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 30px; top: 391px; position: absolute; height: 28px; width: 82px;" Text="Add" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 260px; top: 393px; position: absolute; width: 82px; height: 27px" Text="Delete" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 38px; top: 510px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>
