using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key
    Int32 CustomerId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }
    }

        void DisplayCustomers()
        {
            //create an instance of the address book
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            //find the record to update
            CustomerBook.ThisCustomer.Find(CustomerId);
            //display the data for this record
            txtCustomerId.Text = CustomerBook.ThisCustomer.CustomerId.ToString();
            txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName;
            txtCustomerDOB.Text = CustomerBook.ThisCustomer.CustomerDOB.ToShortDateString();
            txtCustomerEmailAddress.Text = CustomerBook.ThisCustomer.CustomerEmailAddress;
            txtCustomerAddress.Text = CustomerBook.ThisCustomer.CustomerAddress;
            chkMember.Checked = CustomerBook.ThisCustomer.Member;

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
            //capture the customerId
            ACustomer.CustomerId = CustomerId;
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

            //if this is a new record i.e CustomerId = -1 then add the data
            if (CustomerId == -1)
            {
                //set the this address property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the this address property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Update();
            }
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
            txtCustomerDOB.Text = ACustomer.CustomerDOB.ToShortDateString();
            txtCustomerEmailAddress.Text = ACustomer.CustomerEmailAddress;
            txtCustomerAddress.Text = ACustomer.CustomerAddress;
        }
    }
}