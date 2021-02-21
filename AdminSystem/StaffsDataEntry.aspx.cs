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
        //capture Employer/employee
       
        //store the ID in the session object 
        Session["StaffMember"] = StaffMember;
        //navigate to the viewer page 
        Response.Redirect("StaffsViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff class 
        clsStaff StaffMember = new clsStaff();
        //variable to store the primary key 
        Int32 StaffID;
        //variable to store the result of the find operation 
        Boolean Found = false;
        //get the primary key entered by the user 
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record 
        Found = StaffMember.Find(StaffID);
        //if found 
        if (Found == true)
        {
            //display the values of the properties in the form 
            txtStaffName.Text = StaffMember.StaffName;
            txtStaffID.Text = StaffMember.StaffID.ToString();
            txtStaffEmail.Text = StaffMember.StaffEmailAddress;
            txtStaffSalary.Text = StaffMember.StaffSalary.ToString();
            txtStaffDOB.Text = StaffMember.StaffDOB.ToString();

        }

       
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}