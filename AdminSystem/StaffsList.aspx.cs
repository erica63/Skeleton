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

            //update the list box 
            DisplayStaff();
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
}