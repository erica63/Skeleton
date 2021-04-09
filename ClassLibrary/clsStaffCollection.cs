
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<clsStaff> mStafList = new List<clsStaff>();
        //private data member this customer
        clsStaff mThisStaff = new clsStaff();

        //public property for the address list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStafList;
            }
            set
            {
                //set the private data
                mStafList = value;
            }
        }


        public int Count
        {
            get
            {
                //return the count of the list
                return mStafList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //sset the parameterss for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmailAddress);
            DB.AddParameter("@StaffDOB", mThisStaff.StaffDOB);
            DB.AddParameter("@EmployerEmployee", mThisStaff.Employer);
            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblStaff_Insert");
        }
    }

}