
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {

        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member this customer
        clsStaff mThisStaff = new clsStaff();

        //public property for the address list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }


        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
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
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmailAddress);
            DB.AddParameter("@StaffDOB", mThisStaff.StaffDOB);
            DB.AddParameter("@EmployerEmployee", mThisStaff.Employer);
            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisAddress
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmailAddress);
            DB.AddParameter("@StaffDOB", mThisStaff.StaffDOB);
            DB.AddParameter("@EmployerEmployee", mThisStaff.Employer);
            //execture the stored procedure 
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisStaff
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameterss for the stored procedure
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");

        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff member 
                clsStaff StaffMember = new clsStaff();
                //read in the fields from the current record
                StaffMember.Employer = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmployerEmployee"]);
                StaffMember.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                StaffMember.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                StaffMember.StaffEmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                StaffMember.StaffDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDOB"]);
                StaffMember.StaffSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffSalary"]);
                //add the record to the private data member
                mStaffList.Add(StaffMember);
                //point at the next record
                Index++;
            }
        }

        public clsStaffCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        public void ReportByStaffName(string StaffName)
        {
            //filterss the records based on Staff Name.
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //send the name parameter to the database
            DB.AddParameter("@StaffName", StaffName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffName");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }

}