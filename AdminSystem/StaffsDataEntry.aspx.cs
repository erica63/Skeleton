using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to sstore the primary key with page level scope 
    Int32 StaffID; 
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed 
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record 
            if(StaffID != -1)
            {
                //display the current data for the record 
                DisplayStaff();
            }
        }


    }

    private void DisplayStaff()
    {
        //create an instance of the staff lisst 
        clsStaffCollection StaffList = new clsStaffCollection();
        //find the record to update
        StaffList.ThisStaff.Find(StaffID);
        //display the data for this recor 
        txtStaffID.Text = StaffList.ThisStaff.StaffID.ToString();
        txtStaffDOB.Text = StaffList.ThisStaff.StaffDOB.ToShortDateString();
        txtStaffName.Text = StaffList.ThisStaff.StaffName.ToString();
        txtStaffEmail.Text = StaffList.ThisStaff.StaffEmailAddress.ToString();
        chkEmployerEmployee.Checked = StaffList.ThisStaff.Employer;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSaff
        clsStaff StaffMember = new clsStaff();
        //capture the Staff name
        string StaffName = txtStaffName.Text;
        string StaffDOB = txtStaffDOB.Text;
        string StaffEmailAddress = txtStaffEmail.Text;
        string StaffSalary = txtStaffSalary.Text;
       // string StaffID = txtStaffID.Text;
        string Error = "";
        //validate the data
        Error = StaffMember.Valid(StaffName, StaffEmailAddress, StaffDOB, StaffSalary);
        if (Error == "")
        {
            //capture the StaffID
            StaffMember.StaffID = StaffID;
            //capture the StaffName
            StaffMember.StaffName = StaffName;
            //capture the StaffEMail
            StaffMember.StaffEmailAddress = StaffEmailAddress;
            //capture the StaffDOB
            StaffMember.StaffDOB = DateTime.Parse(txtStaffDOB.Text);
            //capture the StaffSalary
            StaffMember.StaffSalary = Decimal.Parse(txtStaffSalary.Text);
            //capture the Staff
            StaffMember.Employer = chkEmployerEmployee.Checked;
            //store staff
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e StaffID = -1 then add the data 
            if (StaffID == -1)
            {
                //set the ThisStaff Property 
                StaffList.ThisStaff = StaffMember;
                //add the record 
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update 
                StaffList.ThisStaff.Find(StaffID);
                //set the ThisStaff property 
                StaffList.ThisStaff = StaffMember;
                //update the record
                StaffList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("StaffsDataEntry.aspx");

        }
        else
        {
            //display error message
            lblError.Text = Error;
        }

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