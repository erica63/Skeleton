<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffID" runat="server" height="19px" style="z-index: 1; left: 31px; top: 54px; position: absolute" Text="Staff ID Number " width="120px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 139px; top: 53px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 32px; top: 84px; position: absolute; height: 19px; width: 120px" Text="Staff Name"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 115px; top: 82px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffDOB" runat="server" style="z-index: 1; left: 32px; top: 114px; position: absolute; height: 19px" Text="Staff D.O.B" width="120px"></asp:Label>
        <asp:TextBox ID="txtStaffDOB" runat="server" style="z-index: 1; left: 115px; top: 114px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 31px; top: 143px; position: absolute" Text="Staff Email Address " width="120px"></asp:Label>
        <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 159px; top: 141px; position: absolute; width: 156px"></asp:TextBox>
        <asp:Label ID="lblEmployerEmployee" runat="server" style="z-index: 1; left: 30px; top: 200px; position: absolute; height: 18px" Text="Employer/Employee" width="120px"></asp:Label>
        <asp:Label ID="lblStaffSalary" runat="server" style="z-index: 1; left: 30px; top: 170px; position: absolute; height: 19px" Text="Staff Salary" width="120px"></asp:Label>
        <asp:TextBox ID="txtStaffSalary" runat="server" style="z-index: 1; left: 121px; top: 167px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkEmployerEmployee" runat="server" style="z-index: 1; left: 169px; top: 201px; position: absolute" Text="Check if staff is Employer" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 233px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 52px; top: 282px; position: absolute; height: 28px; width: 64px; right: 1113px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 282px; position: absolute; height: 28px; width: 64px; left: 135px" Text="Cancel" />
    </form>
</body>
</html>
