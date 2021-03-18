using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //Var to store the primary key value of the record to be deleted
    Int32 OrderId;

    //Event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //Get the number of the address to be deleted from the session object
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //Create a new instance of the orders
        clsOrderCollection Orders = new clsOrderCollection();
        //Find the record to delete
        Orders.ThisOrder.Find(OrderId);
        //Delete the record
        Orders.Delete();
        //Redirect back to the main page
        Response.Redirect("OrdersList.aspx");
    }
}