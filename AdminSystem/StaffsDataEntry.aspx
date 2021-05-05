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
        <asp:Label ID="lblStaffID" runat="server" height="19px" style="z-index: 1; left: 30px; top: 60px; position: absolute" Text="Staff ID Number " width="120px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" style="z-index: 1; left: 139px; top: 58px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffName" runat="server" style="z-index: 1; left: 30px; top: 95px; position: absolute; height: 19px; width: 120px" Text="Staff Name"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" style="z-index: 1; left: 121px; top: 93px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffDOB" runat="server" style="z-index: 1; left: 29px; top: 125px; position: absolute; height: 19px" Text="Staff D.O.B" width="120px"></asp:Label>
        <asp:TextBox ID="txtStaffDOB" runat="server" style="z-index: 1; left: 124px; top: 124px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStaffEmail" runat="server" style="z-index: 1; left: 28px; top: 156px; position: absolute; right: 1023px; width: 135px;" Text="Staff Email Address "></asp:Label>
        <asp:TextBox ID="txtStaffEmail" runat="server" style="z-index: 1; left: 181px; top: 153px; position: absolute; width: 184px"></asp:TextBox>
        <asp:Label ID="lblEmployerEmployee" runat="server" style="z-index: 1; left: 28px; top: 215px; position: absolute; height: 17px" Text="Employer/Employee" width="120px"></asp:Label>
        <asp:Label ID="lblStaffSalary" runat="server" style="z-index: 1; left: 29px; top: 183px; position: absolute; height: 19px" Text="Staff Salary" width="120px"></asp:Label>
        <asp:TextBox ID="txtStaffSalary" runat="server" style="z-index: 1; left: 119px; top: 182px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkEmployerEmployee" runat="server" style="z-index: 1; left: 169px; top: 215px; position: absolute" Text="Check if staff is Employer" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 44px; top: 256px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 29px; top: 303px; position: absolute; height: 28px; width: 84px; right: 1073px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 303px; position: absolute; height: 28px; width: 81px; left: 127px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 275px; top: 58px; position: absolute; right: 872px; height: 25px;" Text="Find" />
    </form>
</body>
</html>
