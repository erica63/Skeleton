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
            //set the private data members to the test data value 
            mStaffID = 1;
            mStaffName = "Jay";
            mStaffEmailAddress = "JayEmail@gmail.com";
            mEmployer = true;
            mStaffDOB = Convert.ToDateTime("23/03/1999");
            mStaffSalary = 35000;

            //always return true 
            return true;
        }
    }
}