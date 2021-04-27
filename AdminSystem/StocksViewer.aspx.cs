using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;



public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //get the data from the session object
        AStock = (clsStock)Session["AStock"];
        //display the item id for this entry
        Response.Write(AStock.ItemId);
        //display the item name for this entry
        Response.Write(AStock.ItemName);
        //display the item available for this entry

        //display the date item added for this entry
        Response.Write(AStock.DateItemAdded);
        //display the item size for this entry
        Response.Write(AStock.ItemSize);
        //display the stock level for this entry
        Response.Write(AStock.StockLevel);




    }
}