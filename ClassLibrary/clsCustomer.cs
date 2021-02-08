using System;

namespace ClassLibrary
{
    public class clsCustomer
    {

        //private data member for the customer id property
        private Int32 mCustomerId;
        
        public Int32 CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        //private data member for CustomerName
        private String mCustomerName;

        //public data member for CustomerName
        public string CustomerName
        {
            get
            {
                //return the private data
                return mCustomerName;
            }
            set
            {
                //set the private data
                mCustomerName = value;
            }
        }

        //private data member for Customer DOB
        private DateTime mCustomerDOB;

        //public property for date added
        public DateTime CustomerDOB
        {
            get
            {
                //return the private data
                return mCustomerDOB;
            }
            set
            {
                //set the private data
                mCustomerDOB = value;
            }
        }

        //private data member for Customer email address
        private String mCustomerEmailAddress;

        //public property for email address added
        public String CustomerEmailAddress
        {
            get
            {
                //return the private data
                return mCustomerEmailAddress;
            }
            set
            {
                //set the private data
                mCustomerEmailAddress = value;
            }
        }

        //private data member for Customer address
        private String mCustomerAddress;

        //public property for address added
        public String CustomerAddress
        {
            get
            {
                //return the private data
                return mCustomerAddress;
            }
            set
            {
                //set the private data
                mCustomerAddress = value;
            }
        }

        //private data member for Member
        private Boolean mMember;

        //public property for address added
        public Boolean Member
        {
            get
            {
                //return the private data
                return mMember;
            }
            set
            {
                //set the private data
                mMember = value;
            }
        }

        public bool Find(int CustomerId)
        {
            //set the private data members to the test data value
            mCustomerId = 1234;
            mCustomerName = "Marcus Rashford";
            mCustomerDOB = Convert.ToDateTime("19/7/2000");
            mCustomerEmailAddress = "Rashford@gmail.com";
            mCustomerAddress = "Marydene drive";
            mMember = true;
            //always return true
            return true;
        }
    }
}