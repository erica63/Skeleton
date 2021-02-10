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
            AnOrder.Active = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
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
            string TestData = "Fila";
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

    }
}
