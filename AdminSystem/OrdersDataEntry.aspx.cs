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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        //Capture the order id
        AnOrder.OrderId = txtOrderId.Text;
        //Capture order date
        AnOrder.DateAdded = DateTime.Parse(txtOrderDate.Text);
        //Capture order price
        AnOrder.TotalPrice = decimal.Parse(txtOrderPrice.Text);
        //Capture order description
        AnOrder.Description = txtOrderDesc.Text;
        //Capture order rating
        AnOrder.Rating = int.Parse(txtOrderRating.Text);

        //Store the address in the session object
        Session["AnOrder"] = AnOrder;
        //Navigate to the viewer page
        Response.Redirect("OrdersViewer.aspx");

    }
}