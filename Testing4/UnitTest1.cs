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

        [TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create some test data to assign to the property
            Int32 SomeCount = 2;
            //Assign the data to the property
            AllOrders.Count = SomeCount;
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
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

        [TestMethod]
        public void TwoRecordsPreset()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Test to see that the two values are the same
            Assert.AreEqual(AllOrders, 2);
        }
    }
}
