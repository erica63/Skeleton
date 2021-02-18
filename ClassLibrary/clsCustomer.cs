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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there shoud be either 1 or 0!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                mCustomerEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmailAddress"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mMember = Convert.ToBoolean(DB.DataTable.Rows[0]["Member"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }

        }

        public string Valid(string CustomerName, string CustomerDOB, string CustomerEmailAddress, string CustomerAddress)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime DateTemp;
            //if the customer email address is blank
            if (CustomerEmailAddress.Length == 0)
            {
                //record the error
                Error = Error + "The customer email address may not be blank : ";
            }

            //if the customer email address is too long
            if (CustomerEmailAddress.Length > 50)
            {
                //record the error
                Error = Error + "The CustomerEmailAddress must be less than 50 characters : ";
            }

            if (CustomerAddress.Length == 0)
            {
                //record the error
                Error = Error + "The customer email address may not be blank : ";
            }

            //if the customer email address is too long
            if (CustomerAddress.Length > 50)
            {
                //record the error
                Error = Error + "The CustomerAddress must be less than 50 characters : ";
            }

            if (CustomerName.Length == 0)
            {
                Error = Error + "The customer Name may not be blank : ";
            }

            if (CustomerName.Length > 50)
            {
                Error = Error + "The customer Name must be less than 50 characters : ";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(CustomerDOB);
                if (DateTemp < DateTime.Parse("19/7/2000"))
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Parse("19/7/2000"))
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }



            //return any error messages
            return Error;
        }
    }
}