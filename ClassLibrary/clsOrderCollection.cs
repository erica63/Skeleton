using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //Constructor for the class
        public clsOrderCollection()
        {
            //Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //Populate the array list with the data table
            PopulateArray(DB);

        }
            

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

        public void Update()
        {
            //Update an existing record based on the values of ThisOrder
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@OrderDate", mThisOrder.DateAdded);
            DB.AddParameter("@ShippingAddress", mThisOrder.ShippingAddress);
            DB.AddParameter("@OrderDelivery", mThisOrder.Delivery);
            DB.AddParameter("@OrderDesc", mThisOrder.Description);
            DB.AddParameter("@OrderQuantity", mThisOrder.OrderQuantity);
            //Execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //Deletes the record pointed to by ThisOrder
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //Execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByDescription(String Description)
        {
            //Filters the records based on a full or partial description
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Send the description parameter to the database
            DB.AddParameter("@OrderDesc", Description);
            //Execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByDescription");
            //Populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //Populates the array list based on the data table in the parameter DB
            //Var for the index
            Int32 Index = 0;
            //Var to store the record count
            Int32 RecordCount;
            //Get the count of records
            RecordCount = DB.Count;
            //Clear the private array list
            mOrderList = new List<clsOrder>();
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create a blank order
                clsOrder AnOrder = new clsOrder();
                //Read in the fields from the current record
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.ShippingAddress = Convert.ToString(DB.DataTable.Rows[Index]["ShippingAddress"]);
                AnOrder.Delivery = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderDelivery"]);
                AnOrder.Description = Convert.ToString(DB.DataTable.Rows[Index]["OrderDesc"]);
                AnOrder.OrderQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderQuantity"]);
                //Add the record to the private data member
                mOrderList.Add(AnOrder);
                //Point to the next record
                Index++;
            }
        }
    }
}

