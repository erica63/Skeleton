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
        string CustomerName = txtCustomerName.Text;
        string CustomerDOB = txtCustomerDOB.Text;
        string CustomerEmailAddress = txtCustomerEmailAddress.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(CustomerName, CustomerDOB, CustomerEmailAddress, CustomerAddress);
        if (Error == "")
        {

            //capture the customer name
            ACustomer.CustomerName = CustomerName;
            //capture the customer email address
            ACustomer.CustomerEmailAddress = CustomerEmailAddress;
            //capture the customer address
            ACustomer.CustomerAddress = CustomerAddress;
            //capture the customer DOB
            ACustomer.CustomerDOB = DateTime.Parse(CustomerDOB);
            //capture the member
            ACustomer.Member = chkMember.Checked;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //set the this address property
            CustomerList.ThisCustomer = ACustomer;
            //add the new record
            CustomerList.Add();
            //navigate to the list page
            Response.Redirect("CustomersList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

        
    }


    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //create an instance of customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        Found = ACustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //display the values of the properites in the form
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerDOB.Text = ACustomer.CustomerDOB.ToString();
            txtCustomerEmailAddress.Text = ACustomer.CustomerEmailAddress;
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
        }
    }
}