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
        clsOrderCollection Orders = new clsOrderCollection();
        //Set the data source to the list of Shipping Address in the collection
        lstOrders.DataSource = Orders.OrderList;
        //Set the name of the primary key
        lstOrders.DataValueField = "OrderId";
        //Set the data field to display
        lstOrders.DataTextField = "ShippingAddress";
        //Bind the data to the list
        lstOrders.DataBind();
    }
}