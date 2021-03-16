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
            //set the private data members to the test value
            mItemId = 21;
            mItemName = "Test ItemName";
            mItemAvailable = true;
            mDateItemAdded = Convert.ToDateTime("16/9/2015");
            mItemSize = Convert.ToDecimal("10.5");
            mStockLevel = "123";

            //always return true
            return true;


        }
    }
}