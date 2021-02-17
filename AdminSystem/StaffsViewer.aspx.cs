using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of clsStaff 
        clsStaff StaffMember = new clsStaff();
        //get the data from the session object 
        StaffMember = (clsStaff)Session["StaffMember"];
        //display the Staff ID number for this entry 
        Response.Write(StaffMember.StaffID);
    }
}