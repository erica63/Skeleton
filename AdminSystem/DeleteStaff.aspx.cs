using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteStaff : System.Web.UI.Page
{
    //var to store the pimary key value of the record to be deleted
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of Staff to be deleted from the session object
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new insstance of the addresss book 
        clsStaffCollection staffCollection = new clsStaffCollection();
        //find the record to delete
        staffCollection.ThisStaff.Find(StaffID);
        //delete the record 
        staffCollection.Delete();
        //redirect back to the main page
        Response.Redirect("StaffsList.aspx");
    }

    protected void btnNO_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffsList.aspx");
    }
}