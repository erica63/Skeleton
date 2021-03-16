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

        [TestMethod]
        public void ItemSizeOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            decimal TestData = decimal.Parse("7.5");
            //assign the data to the property
            AStock.ItemSize = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AStock.ItemSize, TestData);
        }

        [TestMethod]
        public void StockLevelOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.StockLevel = TestData;
            //test to see the two values are the same
            Assert.AreEqual(AStock.ItemSize, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ItemId = 1;
            //invoke the method
            Found = AStock.Find(ItemId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestItemIdFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 21;
            //invoke the method
            Found = AStock.Find(ItemId);
            //check the address no
            if (AStock.ItemId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemName = 21;
            //invoke the method
            Found = AStock.Find(ItemName);
            //check the address no
            if (AStock.ItemName != "Test ItemName") ;
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 21;
            //invoke the method
            Found = AStock.Find(ItemId);
            //check the property
            if (AStock.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateItemAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 21;
            //invoke the method
            Found = AStock.Find(ItemId);
            //check the property
            if (AStock.DateItemAdded != Convert.ToDateTime("16/03/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemSizeFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 21;
            //invoke the method
            Found = AStock.Find(ItemId);
            //check the property
            if (AStock.ItemSize != Convert.ToDecimal("10.5"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockLevelFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ItemId = 21;
            //invoke the method
            Found = AStock.Find(StockLevel);
            //check the address no
            if (AStock.StockLevel != "123") ;
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



    }
}
