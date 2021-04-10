using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        //private data member for Employer 
        private Boolean mEmployer;
        //public property for Employer 
        public bool Employer
        {
            get
            {
                //return the private data 
                return mEmployer;
            }

            set
            {
                //set the private data 
                mEmployer = value;
            }
        }
        //private data member for Staff Name 
        private String mStaffName;
        //public property for staff Name 
        public string StaffName
        {
            get
            {
                //return the private data for Staff Name 
                return mStaffName;
            }
            set
            {
                //set the private data value for Staff Name 
                mStaffName = value;
            }
        }

        public string Valid(string staffName, string staffEmailAddress, string staffDOB, string staffSalary)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime TestDOB;
            //if the customer email address is blank
            if (staffName.Length == 0)
            {
                Error = Error + "Staff Name cannot not be blank : ";
            }

            if (staffName.Length > 50)
            {
                Error = Error + "Staff Name must be less than 50 characters : ";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                TestDOB = Convert.ToDateTime(staffDOB);
                if (TestDOB < DateTime.Parse("01/01/1940"))
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }

                if (TestDOB > DateTime.Parse("01/01/1940"))
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

        //private data for Staff DOB
        private DateTime mStaffDOB;

        //public property for date added
        public DateTime StaffDOB
        {
            get
            {
                //return the private data
                return mStaffDOB;
            }
            set
            {
                //set the private data
                mStaffDOB = value;
            }
        }
        //private data member for Staff Email Address 
        private String mStaffEmailAddress;
        //public property for the Staff Email Address 
        public string StaffEmailAddress
        {
            get
            {
                //return the private data 
                return mStaffEmailAddress;
            }
            set
            {
                //set value of private data member of staff email 
                mStaffEmailAddress = value;
            }
        }


        //staffid private member variable 
        private Int32 mStaffID;
        //staffid public property
        public Int32 StaffID
        {
            get
            {
                //this line of code sends data out of the property 
                return mStaffID;
            }
            set
            {
                //this line of code sends data into the property
                mStaffID = value;
            }
        }
        //private data member for staff salary 
        private decimal mStaffSalary;
        //public property for Staff Salary
        public decimal StaffSalary
        {
            get
            {
                return mStaffSalary;
            }
            set
            {
                mStaffSalary = value;
            }
        }

        public bool Find(int StaffID)
        {
            //create an instance of the new data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for 
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDOB"]);
                mStaffEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mEmployer = Convert.ToBoolean(DB.DataTable.Rows[0]["EmployerEmployee"]);
                mStaffSalary = Convert.ToDecimal(DB.DataTable.Rows[0]["StaffSalary"]);
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

        public string Valid(string staffID, string staffName, string staffEmail, string staffDOB, string employer, string staffSalary)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime TestDOB;
            //if the customer email address is blank
            if (staffName.Length == 0)
            {
                Error = Error + "Staff Name cannot not be blank : ";
            }

            if (staffName.Length > 50)
            {
                Error = Error + "Staff Name must be less than 50 characters : ";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                TestDOB = Convert.ToDateTime(staffDOB);
                if (TestDOB < DateTime.Parse("01/01/1940"))
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }

                if (TestDOB > DateTime.Parse("01/01/1940"))
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


               

