using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {

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
            //Adds a new record to the 
            throw new NotImplementedException();
        }
    }
}

