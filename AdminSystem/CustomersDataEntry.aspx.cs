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
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customer name
        ACustomer.CustomerName = txtCustomerName.Text;
        //ACustomer.CustomerId = txtCustomerId.Text;
        ACustomer.CustomerEmailAddress = txtCustomerEmailAddress.Text;
        ACustomer.CustomerAddress = txtCustomerAddress.Text;
        //ACustomer.DateAdded = txtCustomerDOB.Text.ToString;
        //store the customer in the session object
        Session["ACustomer"] = ACustomer;
        //navigate to the viewer page
        Response.Redirect("CustomersViewer.aspx");

        
    }

    
}