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

        //ShippingAddress private member variable
        private String mShippingAddress;
        //ShippingAddress public property
        public String ShippingAddress
        {
            get
            {
                //This line of code sends data out of the property
                return mShippingAddress;
            }
            set
            {
                //This line of code allows data into the property
                mShippingAddress = value;
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

        //OrderQuantity private member variable
        private Int32 mOrderQuantity;
        //OrderQuantity public property
        public Int32 OrderQuantity
        {
            get
            {
                //This line of code sends data out of the property
                return mOrderQuantity;
            }
            set
            {
                //This line of code allows data into the property
                mOrderQuantity = value;
            }
        }

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
                mShippingAddress = Convert.ToString(DB.DataTable.Rows[0]["ShippingAddress"]);
                mDelivery = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderDelivery"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["OrderDesc"]);
                mOrderQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["OrderQuantity"]);
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
        public string Valid(string DateAdded, string Description, string ShippingAddress, int Quantity)
        {
            //Create a string variable to store the error
            String Error = "";
            //Create a temporary variable to store date values
            DateTime DateTemp;
            //Create a temporary variable to store integer values
            int QuantityTemp;

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

            //If Shipping Address is blank
            if (ShippingAddress.Length == 0)
            {
                //Record the error
                Error = Error + "The shipping address may not be blank : ";
            }

            //If Shipping Address is greater than 50 characters
            if (ShippingAddress.Length > 50)
            {
                //Record the error
                Error = Error + "The shipping address must be less than 50 characters : ";
            }

            try
            {
                //Copy the orderQuantity value to the QuantityTemp variable
                QuantityTemp = Convert.ToInt32(Quantity);
                //If the Order Quantity is less than 0
                if (QuantityTemp < 0)
                {
                    //Record the error
                    Error = Error + "The order quantity may not be less than 0 : ";
                }

                //If the Order Quantity is blank/zero
                if (QuantityTemp == 0)
                {
                    //Record the error
                    Error = Error + "The order quantity may not be blank/zero : ";
                }

                //If the order quantity is largest integer value + 1
                /** if (Quantity > int.MaxValue)
                {
                    //Record the error
                    Error = Error + "The order quantity may not be larger than 2147483648 : ";
                }*/

            } catch
            {
                //Record the error
                Error = Error + "The order quantity was not a valid integer : ";
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