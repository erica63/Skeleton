using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteCustomer : System.Web.UI.Page
{
    Int32 CustomerId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer collection
        clsCustomerCollection customerCollection = new clsCustomerCollection();
        //find the record to delete
        customerCollection.ThisCustomer.Find(CustomerId);
        //delete the record
        customerCollection.Delete();
        //redirect back to the main page
        Response.Redirect("CustomersList.aspx");
    }
}