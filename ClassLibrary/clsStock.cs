using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the address no property
        private Int32 mItemId;

        public clsStock()
        {
        }

        //itemId private member variable
        private Int32 mItemId;
        //itemId public property
        public Int32 ItemId
        {
            get
            {
                //this line of code sends data out of the property
                return mItemId;
            }
            set
            {
                //this line of code allows data into the property
                mItemId = value;
            }
        }

        //private data member for the address no property
        private string mItemName;

        public clsStock()
        {
        }

        //itemName private member variable
        private string mItemName;
        //itemId public property
        public string ItemName
        {
            get
            {
                //this line of code sends data out of the property
                return mItemName;
            }
            set
            {
                //this line of code allows data into the property
                mItemName = value;
            }
        }

        //private data member for ItemAvailable
        private Boolean mItemAvailable;
        //public property for ItemAvailable
        public bool ItemAvailable
        {
            get
            {
                //return the private data
                return mItemAvailable;
            }
            set
            {
                //set the private data
                mItemAvailable = value;
            }
        }

        //private date item added data member
        private DateTime mDateItemAdded;
        //public property for date item added
        public DateTime DateItemAdded
        {
            get
            {
                //return the private data
                return mDateItemAdded;
            }
            set
            {
                //set the private data
                mDateItemAdded = value;
            }
        }

        //private item size data member
        private Decimal mItemSize;
        //public property for date item added
        public Decimal ItemSize
        {
            get
            {
                //return the private data
                return mItemSize;
            }
            set
            {
                //set the private data
                mItemSize = value;
            }
        }

        //private stock level data member
        private Int32 mStockLevel;
        //public property for date item added
        public Int32 StockLevel
        {
            get
            {
                //return the private data
                return mStockLevel;
            }
            set
            {
                //set the private data
                mStockLevel = value;
            }
        }

        public bool Find(int ItemId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@ItemId", ItemId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByItemId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mItemId = Convert.ToInt32(DB.DataTable.Rows[0]["ItemId"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mItemAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Item Available"]);
                mDateItemAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateItemAdded"]);
                mItemSize = Convert.ToDecimal(DB.DataTable.Rows[0]["ItemSize"]);
                mStockLevel = Convert.ToInt32(DB.DataTable.Rows[0]["StockLevel"]);
                //return that everything worked OK
                return true;

            }
            //if no record was found
            else
            {
                //return false indicating problem
                return false;
            }
        }
    }
}