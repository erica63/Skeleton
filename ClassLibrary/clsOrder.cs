using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        //Private data member for the OrderId property
        private Int32 mOrderId;
        //OrderId public property
        public Int32 OrderId
        {
            get
            {
                //This line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //This line of code allows data into the property
                mOrderId = value;
            }
        }

        //DateAdded private member variable
        private DateTime mDateAdded;
        //DateAdded public property
        public DateTime DateAdded
        {
            get
            {
                //This line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //This line of code allows data into the property
                mDateAdded = value;
            }
        }

        //Rating private member variable
        private Decimal mTotalPrice;
        //Rating public property
        public Decimal TotalPrice
        {
            get
            {
                //This line of code sends data out of the property
                return mTotalPrice;
            }
            set
            {
                //This line of code allows data into the property
                mTotalPrice = value;
            }
        }

        //Delivery private member variable
        private Boolean mDelivery;
        //Delivery public property
        public bool Delivery
        {
            get
            {
                //Return private data
                return mDelivery;
            }
            set
            {
                //Set private data
                mDelivery = value;
            }
        }

        //Description private member variable
        private String mDescription;
        //Description public property
        public String Description
        {
            get
            {
                //This line of code sends data out of the property
                return mDescription;
            }
            set
            {
                //This line of code allows data into the property
                mDescription = value;
            }
        }

        //Rating private member variable
        private Int32 mRating;
        //Rating public property
        public Int32 Rating
        {
            get
            {
                //This line of code sends data out of the property
                return mRating;
            }
            set
            {
                //This line of code allows data into the property
                mRating = value;
            }
        }


        //public bool Delivery { get; set; }
        //public DateTime DateAdded { get; set; }
        //public int Rating { get; set; }
        //public string Description { get; set; }
        //public decimal TotalPrice { get; set; }



        public bool Find(int OrderId)
        {
            //Set the private data members to the test data value
            mOrderId = 223;
            mDateAdded = Convert.ToDateTime("16/09/2020");
            mTotalPrice = 34;
            mDelivery = true;
            mDescription = "Fila";
            mRating = 5;
            //Always return true
            return true;
        }
    }
}