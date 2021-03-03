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
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the Order Id to search for
            DB.AddParameter("@OrderId", OrderId);
            //Execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //If one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["OrderPrice"]);
                mDelivery = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderDelivery"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["OrderDesc"]);
                mRating = Convert.ToInt16(DB.DataTable.Rows[0]["OrderRating"]);
                //Always return true
                return true;
            }
            //If no record was found
            else
            {
                //Return false indicating a problem
                return false;
            }
        }


        //Function for the public validation
        public string Valid(string DateAdded, string Description) //Do I include decimals or integers? What about primary key?
        {
            //Create a string variable to store the error
            String Error = "";
            //Create a temporary variable to store date values
            DateTime DateTemp;

            //If the Description is blank
            if (Description.Length == 0)
            {
                //Record the error
                Error = Error + "The description may not be blank : ";
            }

            //If the Description is greater than 20 characters
            if (Description.Length > 20)
            {
                //Record the error
                Error = Error + "The description must be less than 20 characters : ";
            }
            try
            {
                //Copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //Record the error
                    Error = Error + "The date cannot be in the past : ";
                }

                //Check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //Record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }

            catch
            {
                //Record the error
                Error = Error + "The date was not a valid date : ";
            }

            //Return any error messages
            return Error;
        }
        
    }
}