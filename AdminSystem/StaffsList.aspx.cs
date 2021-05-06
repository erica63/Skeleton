using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //this handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed 
        if (IsPostBack == false)
        {
            //update the list box 
            DisplayStaff();
        }

    }
    void DisplayStaff()
    {
        //create an instance of the county collection 
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to the list of staffId in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key 
        lstStaffList.DataValueField = "StaffID";
        //sset the data field to display 
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the lisst
        lstStaffList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the sesssion object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffsDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited 
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != 1)
        {
            //get the priamry key value of the record to edit 
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("StaffsDataEntry.aspx");
        }
        else // if no record has been selected
        {
            //display an error 
            lblError.Text = "Please select a record to edit from the list";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to sstore the primary key value of the record to be deleted 
        Int32 StaffID;
        //if a record  has been selected from the list 
        if (lstStaffList.SelectedIndex != -1) //ensures entry has been clicked 
        {
            //get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("DeleteStaff.aspx");
        }
        else //if no record has been selected
        {
            //display an error 
            lblError.Text = "please select a record to delete from the list";
        }
    }


    protected void btnApply_Click(object sender, EventArgs e)
    {
        {
            {
                //create an instance of the staff collection 
                clsStaffCollection Staff = new clsStaffCollection();
                Staff.ReportByStaffName(txtBoxStaffName.Text);
                lstStaffList.DataSource = Staff.StaffList;
                //set the name of the primary key 
                lstStaffList.DataValueField = "StaffID";
                //set the name of the field to display
                lstStaffList.DataTextField = "StaffName";
                //bind the data to the list 
                lstStaffList.DataBind();
            }
            if (String.IsNullOrEmpty(txtBoxStaffName.Text))
                {
                lblError.Text = "No filter was applied, please refresh and try again";
            }

        }
    }


    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection 
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByStaffName("");
        //clear any existing filter to tidy up the interface 
        txtBoxStaffName.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of primary key 
        lstStaffList.DataValueField = "StaffID";
        //set the name of the field to display 
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list 
        lstStaffList.DataBind();

    }

    protected void btnEdit_Click1(object sender, EventArgs e)
    {
        {
            //var to store the primary key value of the record to be edited
            Int32 StaffID;
            //if a record has been selected from the list
            if (lstStaffList.SelectedIndex != -1)
            {
                //get the primary key value of the record to edit
                StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
                Session["StaffID"] = StaffID;
                //redirect to the edit page
                Response.Redirect("StaffsDataEntry.aspx");
            }
            else // if no record has been selected
            {
                //display an error 
                lblError.Text = "Please select a record to edit from the list";
            }

        }
    }

    protected void btnRefresh_Click(object sender, EventArgs e)
    {
        //refresh button to bring back list of staff after clearing a filter
        //create an instance of the county collection 
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to the list of staffId in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key 
        lstStaffList.DataValueField = "StaffID";
        //sset the data field to display 
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the lisst
        lstStaffList.DataBind();
    }
}