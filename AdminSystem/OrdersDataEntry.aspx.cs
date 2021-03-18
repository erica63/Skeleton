using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //Variable to store the primary key with page level scope
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the number of the order to be processed
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            //If this is not a new record
            if (OrderId != 1)
            {
                //Display the current data for the record
                DisplayOrders();
            }
        }
    }
    void DisplayOrders()
    {
        //Create an instance of the orders
        clsOrderCollection Orders = new clsOrderCollection();
        //Find the record to update
        Orders.ThisOrder.Find(OrderId);
        //Display the data for this record
        txtOrderId.Text = Orders.ThisOrder.OrderId.ToString();
        txtOrderDate.Text = Orders.ThisOrder.DateAdded.ToString();
        txtOrderDesc.Text = Orders.ThisOrder.Description.ToString();
        txtOrderQuantity.Text = Orders.ThisOrder.OrderQuantity.ToString();
        txtShippingAddress.Text = Orders.ThisOrder.ShippingAddress.ToString();
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        //Capture the order id
        AnOrder.OrderId = int.Parse(txtOrderId.Text);

        //Capture order date
        String DateAdded = txtOrderDate.Text;

        //Capture shipping address
        String ShippingAddress = txtShippingAddress.Text;

        //Capture order description
        String Description = txtOrderDesc.Text;

        //Capture order quantity
        int OrderQuantity = int.Parse(txtOrderQuantity.Text);

        //Variable to store any error messages
        string Error = "";

        //Validate the data
        Error = AnOrder.Valid(DateAdded, Description, ShippingAddress, OrderQuantity);
        if (Error == "")
        {
            //Capture the Order Id
            AnOrder.OrderId = OrderId;
            //Capture Description
            AnOrder.Description = Description;
            //Capture Date
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
            //Capture ShippingAddress
            AnOrder.ShippingAddress = ShippingAddress;
            //Capture OrderQuantity
            AnOrder.OrderQuantity = OrderQuantity;
            //Capture OrderDelivery (Boolean)
            AnOrder.Delivery = chkOrderDelivery.Checked;

            //Create a new instance of the order collection
            clsOrderCollection OrdersList = new clsOrderCollection();

            //If this is a new record i.e OrderId = -1 then add the data
            if (OrderId == -1)
            {
                //Set the ThisOrder property
                OrdersList.ThisOrder = AnOrder;
                //Add the new record
                OrdersList.Add();
            }
            //Otherwise it must be an update
            else
            {
                //Find the record to update
                OrdersList.ThisOrder.Find(OrderId);
                //Set the ThisOrder property
                OrdersList.ThisOrder = AnOrder;
                //Update the record
                OrdersList.Update();
            }
            //Redirect back to the listpage
            Response.Redirect("OrdersList.aspx");
        }
        else
        {
            //Display the error message
            lblError.Text = Error;

        }

        }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an instance of the address class
        clsOrder AnOrder = new clsOrder();
        //Variable to store the primary key
        Int32 OrderId;
        //Variable to store the result of the find operation
        Boolean Found = false;
        //Get the primary key entered by the user
        OrderId = Convert.ToInt32(txtOrderId.Text);
        //Find the record
        Found = AnOrder.Find(OrderId);
        //If found
        if (Found == true)
        {
            //Display the values of the properties in the form
            //txtOrderId.Text = AnOrder.OrderId.ToString();
            txtOrderDate.Text = AnOrder.DateAdded.ToString();
            txtShippingAddress.Text = AnOrder.ShippingAddress.ToString();
            txtOrderDesc.Text = AnOrder.Description;
            txtOrderQuantity.Text = AnOrder.OrderQuantity.ToString();

        }
    }
}