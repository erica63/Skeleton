using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerClass
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer testItem = new clsCustomer();
            //set its properties
            testItem.CustomerId = 1;
            testItem.CustomerName = "Suraj";
            testItem.CustomerEmailAddress = "suraj@gmail.com";
            testItem.CustomerDOB = DateTime.Parse("19/7/2000");
            testItem.CustomerAddress = "12, Marydene drive";
            testItem.Member = true;
            //add the item to the test list
            TestList.Add(testItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        //[TestMethod]
        //public void CountPropertyOK()
        //{
        //create an instance of the class we want to create
        //clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //create some test data to assign to the property
        //Int32 Somecount = 3;
        //assing the data to the property
        //AllCustomers.Count = Somecount;
        //Assert.AreEqual(AllCustomers.Count, Somecount);
        //}

        [TestMethod]
        public void ThisCusotmerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Member = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.CustomerName = "Suraj";
            TestCustomer.CustomerDOB = DateTime.Parse("19/7/2000");
            TestCustomer.CustomerEmailAddress = "suraj@gmail.com";
            TestCustomer.CustomerAddress = "12, Marydene drive";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer testItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            testItem.CustomerId = 1;
            testItem.CustomerName = "Suraj";
            testItem.CustomerEmailAddress = "Suraj@gmail.com";
            testItem.CustomerDOB = DateTime.Parse("19/07/2000");
            testItem.CustomerAddress = "12, Marydene drive";
            testItem.Member = true;
            //set this address to the test data
            AllCustomers.ThisCustomer = testItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            testItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, testItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer testItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            testItem.CustomerName = "Thomas";
            testItem.CustomerEmailAddress = "thomas@gmail.com";
            testItem.CustomerDOB = DateTime.Parse("22/07/1995");
            testItem.CustomerAddress = "Downtown, LA";
            testItem.Member = true;
            //set this address to the test data
            AllCustomers.ThisCustomer = testItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            testItem.CustomerId = PrimaryKey;
            //modify the test data
            testItem.CustomerName = "Mason";
            testItem.CustomerEmailAddress = "mason@gmail.com";
            testItem.CustomerDOB = DateTime.Parse("22/02/1995");
            testItem.CustomerAddress = "Wapare Street";
            testItem.Member = false;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = testItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, testItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer testItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            testItem.CustomerId = 1;
            testItem.CustomerName = "Suraj";
            testItem.CustomerEmailAddress = "suraj@gmail.com";
            testItem.CustomerDOB = DateTime.Parse("19/07/2000");
            testItem.CustomerAddress = "12, Marydene drive";
            testItem.Member = true;
            //set this address to the test data
            AllCustomers.ThisCustomer = testItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            testItem.CustomerId = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found 
            Assert.IsFalse(Found);
        }


        [TestMethod]
        public void ReportByNameMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (Should return all records)
            FilteredCustomers.ReportByName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a name that doesnt exist
            FilteredCustomers.ReportByName("blahh");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that doesnt exist
            FilteredCustomers.ReportByName("Thomas");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check the first record id is 22
                if (FilteredCustomers.CustomerList[0].CustomerId != 22)
                {
                    OK = false;
                }
                //check that the second record is id 23
                if (FilteredCustomers.CustomerList[1].CustomerId != 23)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
