using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrderProcessing
    {
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
    }
}
