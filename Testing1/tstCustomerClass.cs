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
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, testItem);

        }

        }
}
