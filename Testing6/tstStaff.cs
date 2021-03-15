using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstStaff
    {
        //good test data 
        //create some test data to pass to the method
        String StaffID = "1";
        String StaffName = "Jay";
        String StaffDOB = "23/03/1999";
        String StaffEmail = "JayEmail@gmail.com";
        String Employer = "true";
        String StaffSalary = "50000";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStaff StaffMember = new clsStaff();
            //test to see that it exists 
            Assert.IsNotNull(StaffMember);
        }

        [TestMethod]
        public void IsEmployerPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            StaffMember.Employer = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(StaffMember.Employer, TestData);
        }

        [TestMethod]
        public void StaffNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property 
            string TestData = "Jay";
            //assign the data to the property 
            StaffMember.StaffName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(StaffMember.StaffName, TestData);

        }

        [TestMethod]
        public void StaffDOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Parse("23/03/1999");
            //assign the data to the property
            StaffMember.StaffDOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.StaffDOB, TestData);

        }

        [TestMethod]
        public void StaffEmailAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            string TestData = "p2577997@my365.dmu.ac.uk";
            //assign the data to the property
            StaffMember.StaffEmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.StaffEmailAddress, TestData);
        }

        [TestMethod]
        public void StaffIDOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 21;
            //assign the data to the property
            StaffMember.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.StaffID, TestData);
        }

        [TestMethod]
        public void StaffSalaryPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaff StaffMember = new clsStaff();
            //create some test data to assign to the property
            decimal TestData = 35000;
            //assign to data to the property 
            StaffMember.StaffSalary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(StaffMember.StaffSalary, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = StaffMember.Find(StaffID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of the class we want to create 
            clsStaff StaffMember = new clsStaff();
            //boolean variable to stor ethe results of the search 
            Boolean Found = false;
            //boolean variable to record if the data is 'OK' (assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 1;
            //invoke the method 
            Found = StaffMember.Find(StaffID);
            //check the staff ID 
            if (StaffMember.StaffID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffID = 1;
            //invoke the method
            Found = StaffMember.Find(StaffID);
            //check the property
            if (StaffMember.StaffName != "Jay ")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmployerFound()
        {
            //create an instance of the class we want to create 
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 1;
            //invoke the method
            Found = StaffMember.Find(StaffID);
            //check the property 
            if (StaffMember.Employer != true)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDOBFound()
        {
            //create an instance of the class we want to create 
            clsStaff StaffMember = new clsStaff();
            //Boolean vairable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK(assume it is) 
            Boolean OK = true;
            //create some  test data to use with the method 
            Int32 StaffID = 1;
            //invoke the method 
            Found = StaffMember.Find(StaffID);
            //check the property
            if (StaffMember.StaffDOB != Convert.ToDateTime("23/03/1999"))
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStaffEmailAddressFound()
        {
            //create an instance of the class we want to create 
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if the data is OK(assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 1;
            //invoke the method 
            Found = StaffMember.Find(StaffID);
            //check the property 
            if (StaffMember.StaffEmailAddress != "JayEmail@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStaffSalaryFound()
        {
            //create an instance of the class we want to create 
            clsStaff StaffMember = new clsStaff();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean variable to record if the data is OK(Assume it is) 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffID = 1;
            //invoke the method 
            Found = StaffMember.Find(StaffID);
            //check the property 
            if (StaffMember.StaffSalary != 50000)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error messages 
            String Error = "";
            //invoke the method 
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffName = "";
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMin()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffName = "J";
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "Ja"; //this should be ok
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            StaffName = StaffName.PadRight(49, 'J');
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "jaaaaaaaaaaaaaaaaaaaaaaaaaaaay"; //this should be ok
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            StaffName = StaffName.PadRight(25, 'J');
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffName = "jaaaaaaaaaaaaaaaaaaaaaaaaaaaayy"; //this should fail
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtreme()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            StaffName = StaffName.PadRight(500, 's');
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDOB;
            //set the date 
            TestDOB = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDOB = TestDOB.AddYears(-100);
            //convert the date variable to a string variable
            string StaffDOB = TestDOB.ToString();
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDOB;
            //set staff dob
            TestDOB = DateTime.Parse("23/03/1999");
            //change the date to whatever the date is less 100 years
            TestDOB = TestDOB.AddYears(-1);
            //convert the date variable to a string variable
            string StaffDOB = TestDOB.ToString();
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMin()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDOB;
            //set staff dob
            TestDOB = DateTime.Parse("23/03/1999");
            //convert the date variable to a string variable
            string StaffDOB = TestDOB.ToString();
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDOB;
            //set Staff DOB 
            TestDOB = DateTime.Parse("23/03/1999");
            //change the date to whatever the date is less 100 years
            TestDOB = TestDOB.AddYears(1);
            //convert the date variable to a string variable
            string StaffDOB = TestDOB.ToString();
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffDOBExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDOB;
            //set staff dob
            TestDOB = DateTime.Parse("23/03/1999");
            //change the date to whatever the date is plus 100 years
            TestDOB = TestDOB.AddYears(100);
            //convert the date variable to a string variable
            string staffDOB = TestDOB.ToString();
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDOBInvalidData()
        {
            //create an instance of the class we want to create 
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error messages 
            String Error = "";
            //set the Staff DOB to a non date value 
            string StaffDOB = "random date!";
            //invoke the method 
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error messages 
            string Error = "";
            //this should fail 
            string StaffSalary = "";
            //invoke the method 
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StaffSalaryMin()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffSalary = "10000";
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffSalary = "10001";
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffSalary = "99999";
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMax()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffSalary = "100000";
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StaffSalary = "100001";
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMid()
        {
            //create an instance of the class we want to create
            clsStaff StaffMember = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffSalary = "50000";
            //invoke the method
            Error = StaffMember.Valid(StaffID, StaffName, StaffEmail, StaffDOB, Employer, StaffSalary);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
         






    }

}
