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

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            Int32 Somecount = 2;
            //assing the data to the property
            AllCustomers.Count = Somecount;
            Assert.AreEqual(AllCustomers.Count, Somecount);
        }

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

    }
}
