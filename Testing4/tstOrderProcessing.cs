﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrderProcessing
    {
  
        //Create some test data to pass to the method
        string Description = "FILA";
        string DateAdded = DateTime.Now.Date.ToString();


        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderDeliveryPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            AnOrder.Delivery = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.Delivery, TestData);
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            AnOrder.DateAdded = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }

        [TestMethod]
        public void OrderRatingPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test data to assign to the property
            int TestData = 1;
            //Assign the data to the property
            AnOrder.Rating = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.Rating, TestData);
        }

        [TestMethod]
        public void OrderDescriptionPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test data to assign to the property
            string TestData = "FILA";
            //Assign the data to the property
            AnOrder.Description = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.Description, TestData);
        }
        [TestMethod]
        public void OrderPriceOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Create some test data to assign to the property
            decimal TestData = 23.99m;
            //Assign the data to the property
            AnOrder.TotalPrice = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 OrderId = 7;
            //Invoke the method
            Found = AnOrder.Find(OrderId);
            //Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderId = 7;
            //Invoke the method
            Found = AnOrder.Find(OrderId);
            //Check the Order Id
            if (AnOrder.OrderId != 7)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

       [TestMethod]
       public void TestDateAddedFound()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderId = 7;
            //Invoke the method
            Found = AnOrder.Find(OrderId);
            //Check the Order Id
            if (AnOrder.DateAdded != Convert.ToDateTime("30/01/2021")) 
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDeliveryFound()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderId = 7;
            //Invoke the method
            Found = AnOrder.Find(OrderId);
            //Check the Order Id
            if (AnOrder.Delivery != true)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDescriptionFound()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderId = 7;
            //Invoke the method
            Found = AnOrder.Find(OrderId);
            //Check the Order Id
            if (AnOrder.Description != "FILA")
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderRatingFound()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderId = 7;
            //Invoke the method
            Found = AnOrder.Find(OrderId);
            //Check the Order Id
            if (AnOrder.Rating != 5)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMinLessOne()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass the method
            string Description = ""; //This should trigger an error
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMin()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass the method
            string Description = "A"; //This should be ok
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass the method
            string Description = "AD"; //This should be ok
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMaxLessOne()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass the method
            string Description = "0123456789012345678"; //This should be ok
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMax()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass the method
            string Description = "01234567890123456789"; //This should be ok
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMaxPlusOne()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass the method
            string Description = "012345678901234567890"; //This should trigger an error
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMid()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass the method
            string Description = "0123456789"; //This should be ok
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionExtremeMax()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass the method
            string Description = "";
            Description = Description.PadRight(200, 'a'); //This should fail
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date to today's date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //Convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinnLessOne()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date to today's date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //Convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date to today's date
            TestDate = DateTime.Now.Date;
            //Convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date to today's date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //Convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Create a variable to store the test date data
            DateTime TestDate;
            //Set the date to today's date
            TestDate = DateTime.Now.Date;
            //Change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //Convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Set the date to a non date value
            string DateAdded = "This is not a date!";
            //Invoke the method
            Error = AnOrder.Valid(DateAdded, Description);
            //Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
