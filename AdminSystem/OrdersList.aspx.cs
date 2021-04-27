using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    //This function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //If this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //Update the list box
            DisplayOrders();
        }

    }
    void DisplayOrders()
    {
        //Create an instance of the Shipping Address Collection
        ClassLibrary.clsOrderCollection Addresses = new ClassLibrary.clsOrderCollection();
        //Set the data source to the list of Shipping Address in the collection
        lstOrders.DataSource = Addresses.OrderList;
        //Set the name of the primary key
        lstOrders.DataValueField = "OrderId";
        //Set the data field to display
        lstOrders.DataTextField = "ShippingAddress";
        //Bind the data to the list
        lstOrders.DataBind();
    }




    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Var to store the primary key value of the record to be edited
        Int32 OrderId;
        //If a record has been selected from the list
        if (lstOrders.SelectedIndex != -1)
        {
            //Get the primary key value of the record to edit
            OrderId = Convert.ToInt32(lstOrders.SelectedValue);
            //Store the data in the session object
            Session["OrderId"] = OrderId;
            //Redirect to the edit page
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else //If no record has been selected 
        {
            //Display an error
            lblError.Text = "Please select a record to edit from the list";

        }
    }


    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Var to store the primary key value of the record to be deleted
        Int32 OrderId;
        //If a record has been selected from the list
        if (lstOrders.SelectedIndex != -1)
        {
            //Get the primary key value of the record to delete
            OrderId = Convert.ToInt32(lstOrders.SelectedValue);
            //Store the data in the session object
            Session["OrderId"] = OrderId;
            //Redirect to the delete page
            Response.Redirect("OrdersConfirmDelete.aspx");
        }
        else //If no record has been selected
        {
            //Display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //Create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByShippingAddress(txtFilter.Text);
        lstOrders.DataSource = Orders.OrderList;
        //Set the name of the primary key
        lstOrders.DataValueField = "OrderId";
        //Set the name of the field to display
        lstOrders.DataTextField = "ShippingAddress";
        //Bind the data to the list
        lstOrders.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //Create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByShippingAddress("");
        //Clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstOrders.DataSource = Orders.OrderList;
        //Set the name of the primary key
        lstOrders.DataValueField = "OrderId";
        //Set the name of the field to display
        lstOrders.DataTextField = "ShippingAddress";
        //Bind the data to the list
        lstOrders.DataBind();
    }



    //Event handler for the add button
    protected void btnAdd_Click1(object sender, EventArgs e)
    {
            //Store -1 into the session object to indicate this is a new record
            Session["OrderId"] = -1;
            //Redirect to the data entry page
            Response.Redirect("OrdersDataEntry.aspx");
        }
    
}