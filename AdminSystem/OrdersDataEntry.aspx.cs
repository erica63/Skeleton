﻿using System;
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
        AnOrder.OrderId = int.Parse(txtOrderId.Text);

        //Capture order date
        String DateAdded = txtOrderDate.Text;

        //Capture order price
        AnOrder.TotalPrice = decimal.Parse(txtOrderPrice.Text);

        //Capture order description
        String Description = txtOrderDesc.Text;

        //Capture order rating
        AnOrder.Rating = int.Parse(txtOrderRating.Text);

        //Variable to store any error messages
        string Error = "";

        //Validate the data
        Error = AnOrder.Valid(DateAdded, Description);
        if (Error == "")
        {
            //Capture Description
            AnOrder.Description = Description;
            //Capture Date added
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);



            //Store the address in the session object
            Session["AnOrder"] = AnOrder;
            //Navigate to the viewer page
            //Response.Redirect("OrdersViewer.aspx");
            Response.Write("OrdersViewer.aspx");
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
            txtOrderId.Text = AnOrder.OrderId.ToString();
            txtOrderDate.Text = AnOrder.DateAdded.ToString();
            txtOrderPrice.Text = AnOrder.TotalPrice.ToString();
            txtOrderDesc.Text = AnOrder.Description;
            txtOrderRating.Text = AnOrder.Rating.ToString();

        }
    }
}