using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstStaff
    {
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
            if (StaffMember.StaffID !=1)
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
            if (StaffMember.StaffName != "Jay")
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
            if (StaffMember.StaffSalary != 35000)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);
        }

    }

}
