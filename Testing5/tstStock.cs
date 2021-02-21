using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);

        }

            [TestMethod]
        public void ItemIdOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.ItemId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.ItemId, TestData);
        }

        [TestMethod]
        public void ItemNameOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AStock.ItemName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.ItemName, TestData);
        }

        [TestMethod]
        public void ItemAvailableOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStock.ItemAvailable = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.ItemAvailable, TestData);
        }

        [TestMethod]
        public void DateItemAddedOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStock.DateItemAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.DateItemAdded, TestData);
        }

        


        }
    }

