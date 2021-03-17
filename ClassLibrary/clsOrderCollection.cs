﻿using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        /** public clsOrderCollection()
        {
            //Private data member for the list
            List<clsOrder> mOrderList = new List<clsOrder>();
            //Private data member thisOrder
            clsOrder mThisOrder = new clsOrder();

            //Var for the index
            Int32 Index = 0;
            //Var to store the record count
            Int32 RecordCount = 0;
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //Get the count of records
            RecordCount = DB.Count;
            //While there are records to process
            while (Index < RecordCount*/
            /**
                //Create a blank order
                clsOrder AnOrder = new clsOrder();
                //Read in the fields from the current record
                AnOrder.Delivery = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderDelivery"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                AnOrder.Description = Convert.ToString(DB.DataTable.Rows[Index]["OrderDesc"]);
                AnOrder.OrderQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderQuantity"]);
                //Add the record to the private data member
                mOrderList.Add(AnOrder);
                //Point at the next record
                Index++;
            } */

        //Private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //Private data member thisOrder
        clsOrder mThisOrder = new clsOrder();

        //Public property for the order list
        public List<clsOrder> OrderList
        {
            get
            {
                //Return the private data member
                return mOrderList;
            }
            set
            {
                //Set the private data
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                //Return the count of the list
                return mOrderList.Count;
            }
            set
            {

            }
        }

        //Public property for ThisOrder
        public clsOrder ThisOrder
        {
            get
            {
                //Return the private data
                return mThisOrder;
            }
            set
            {
                //Set the private data
                mThisOrder = value;
            }
        }

        public int Add()
        {
            //Adds a new record to the database based on the values of mThisOrder
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@OrderDate", mThisOrder.DateAdded);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@OrderDelivery", mThisOrder.Delivery);
            DB.AddParameter("@OrderDesc", mThisOrder.Description);
            DB.AddParameter("@OrderQuantity", mThisOrder.OrderQuantity);
            //Execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }
    }
}

