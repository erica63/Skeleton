using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tstOrderClass
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the list
            //Create the item of the test data
            clsOrder TestItem = new clsOrder();
            //Set its properties
            TestItem.Delivery = true;
            TestItem.OrderId = 1;
            TestItem.OrderQuantity = 1;
            TestItem.ShippingAddress = "22 New Park St";
            TestItem.Description = "ADIDAS";
            TestItem.DateAdded = DateTime.Parse("03/01/2021");

            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllOrders.OrderList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }
        /**
                [TestMethod]
                public void CountPropertyOK()
                {
                    //Create an instance of the class we want to create
                    clsOrderCollection AllOrders = new clsOrderCollection();
                    //Create some test data to assign to the property
                    Int32 SomeCount = 0;
                    //Assign the data to the property
                    AllOrders.Count = SomeCount;
                    //Test to see that the two values are the same
                    Assert.AreEqual(AllOrders.Count, SomeCount);
                }*/

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the list
            //Create the item of test data
            clsOrder TestItem = new clsOrder();
            //Set its properties
            TestItem.OrderId = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ShippingAddress = "22 New Park St";
            TestItem.Delivery = true;
            TestItem.Description = "ADIDAS";
            TestItem.OrderQuantity = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllOrders.OrderList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //Set the properties of the test object
            TestOrder.Delivery = true;
            TestOrder.OrderId = 1;
            TestOrder.OrderQuantity = 1;
            TestOrder.ShippingAddress = "22 New Park St";
            TestOrder.Description = "ADIDAS";
            TestOrder.DateAdded = DateTime.Parse("03/01/2021");
            //Assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);

        }

        /**
        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the list
            //Create the item of test data
            clsOrder TestItem = new clsOrder();
            //Set its properties
            TestItem.Delivery = true;
            TestItem.OrderId = 1;
            TestItem.OrderQuantity = 1;
            TestItem.ShippingAddress = "22 New Park St";
            TestItem.Description = "ADIDAS";
            TestItem.DateAdded = DateTime.Parse("03/01/2021");
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllOrders.OrderList = TestList;
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }*/

        /**
           [TestMethod]
           public void TwoRecordsPreset()
           {
               //Create an instance of the class we want to create
               clsOrderCollection AllOrders = new clsOrderCollection();
               //Test to see that the two values are the same
               Assert.AreEqual(AllOrders, 2);
           }*/

        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create the item of test data
            clsOrder TestItem = new clsOrder();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.Delivery = true;
            TestItem.OrderId = 1;
            TestItem.OrderQuantity = 1;
            TestItem.ShippingAddress = "22 New Park St";
            TestItem.Description = "ADIDAS";
            TestItem.DateAdded = DateTime.Parse("03/01/2021");
            //Set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //Add the record
            PrimaryKey = AllOrders.Add();
            //Set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create the item of test data
            clsOrder TestItem = new clsOrder();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.Delivery = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ShippingAddress = "18 Lala St";
            TestItem.Description = "FILA";
            TestItem.OrderQuantity = 1;
            //Set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //Add the record
            PrimaryKey = AllOrders.Add();
            //Set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //Modify the test data
            TestItem.Delivery = false;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ShippingAddress = "17 Lala St";
            TestItem.Description = "ADIDAS, FILA";
            TestItem.OrderQuantity = 2;
            //Set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //Update the record
            AllOrders.Update();
            //Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //Test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create the item of test data
            clsOrder TestItem = new clsOrder();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.Delivery = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ShippingAddress = "18 Lala St";
            TestItem.Description = "FILA";
            TestItem.OrderQuantity = 1;
            //Set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //Add the record
            PrimaryKey = AllOrders.Add();
            //Set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //Delete the record
            AllOrders.Delete();
            //Now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //Test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByShippingAddressMethodOK()
        {
            //Create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //Apply a blank string (should return all records)
            FilteredOrders.ReportByShippingAddress("");
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByShippingAddressNoneFound()
        {
            //Create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //Apply a description that doesn't exist
            FilteredOrders.ReportByShippingAddress("xxxx");
            //Test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByShippingAddressTestDataFound()
        {
            //Create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //Var to store outcome
            Boolean OK = true;
            //Apply a shipping address that doesn't exist
            FilteredOrders.ReportByShippingAddress("yyy");
            //Check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                //Check that the first record is ID 57
                if (FilteredOrders.OrderList[0].OrderId != 57)
                {
                    OK = false;
                }
                //Check that the second record is ID 58
                if (FilteredOrders.OrderList[1].OrderId != 58)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //Test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}

    

