using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff 
        clsStaff StaffMember = new clsStaff();
        //capture the staff ID
        StaffMember.StaffID = int.Parse(txtStaffID.Text);
        //capture Staff Name 
        StaffMember.StaffName = txtStaffName.Text;
        //capture Staff Date of Birth 
        StaffMember.StaffDOB = DateTime.Parse(txtStaffDOB.Text);
        //capture Staff Email address 
        StaffMember.StaffEmailAddress = txtStaffEmail.Text;
        //capture staff salary
        StaffMember.StaffSalary = Decimal.Parse(txtStaffSalary.Text); 
        //store the ID in the session object 
        Session["StaffMember"] = StaffMember;
        //navigate to the viewer page 
        Response.Redirect("StaffsViewer.aspx");
    }
}