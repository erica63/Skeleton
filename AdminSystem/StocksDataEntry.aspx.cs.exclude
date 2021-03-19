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
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the item id
        AStock.ItemId = int.Parse(txtItemId.Text);
        //capture the item name
        AStock.ItemName = txtItemName.Text;
        //capture item available

        //capture date item added
        AStock.DateItemAdded = txtDateItemAdded.Text;
        //capture item size
        AStock.ItemSize = decimal.Parse(txtItemSize.Text);
        //capture stock level
        AStock.StockLevel = int.Parse(txtStockLevel.Text);
        //store the data in the session object
        Session["AStock"] = AStock;
        //navigate to the viewer page
        Response.Redirect("StocksViewer.aspx");

    }
}

