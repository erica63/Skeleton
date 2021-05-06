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
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; top: 391px; position: absolute; height: 28px; width: 82px; left: 49px;" Text="Add" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 39px; top: 447px; position: absolute; width: 113px; height: 18px; right: 1034px" Text="Enter Staff Name:"></asp:Label>
        <asp:TextBox ID="txtBoxStaffName" runat="server" style="z-index: 1; left: 162px; top: 446px; position: absolute; width: 247px;"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 38px; top: 483px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 106px; top: 482px; position: absolute" Text="Clear" />
        <p>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 160px; top: 390px; position: absolute; width: 82px; height: 28px; right: 1111px;" Text="Edit" OnClick="btnEdit_Click1" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 38px; top: 524px; position: absolute" Text="lblError"></asp:Label>
        </p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 275px; top: 390px; position: absolute; width: 82px; height: 27px" Text="Delete" />
        <asp:Button ID="btnRefresh" runat="server" OnClick="btnRefresh_Click" style="z-index: 1; left: 460px; top: 43px; position: absolute" Text="Refresh" />
    </form>
</body>
</html>
