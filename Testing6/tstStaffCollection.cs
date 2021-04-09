﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Testing6
{
    [TestClass]
    class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an insstance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Employer = true;
            TestItem.StaffID = 1;
            TestItem.StaffName = "Name";
            TestItem.StaffSalary = 30000;
            TestItem.StaffEmailAddress = "jayemail@gmail.com";
            TestItem.StaffDOB = DateTime.Parse("23/03/1999"); 
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

        [TestMethod]
        public void CountStaffOK()
        {
            //create an instance of the classs we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign 
            Int32 SomeCount = 0;
            //asssign data to Staff n
            AllStaff.Count = SomeCount;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }

        [TestMethod]
        public void ThisStaffMemberOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some tesst data to assign to staff 
            clsStaff TestStaffMember = new clsStaff();
            //set the properties of test object
            TestStaffMember.Employer = true;
            TestStaffMember.StaffDOB = DateTime.Parse("23/03/1999");
            TestStaffMember.StaffEmailAddress = "jayemail@gmail.com";
            TestStaffMember.StaffID = 1;
            TestStaffMember.StaffSalary = 30000;
            TestStaffMember.StaffName = "Name";
            //assign the data to the property 
            AllStaff.ThisStaff = TestStaffMember;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestStaffMember);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create test data to assign 
            //in this case the data needss to be a list of objects 
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list 
            //create the item of test data 
            clsStaff TestItem = new clsStaff();
            //set its properties 
            TestItem.Employer = true;
            TestItem.StaffID = 1;
            TestItem.StaffName = "Name";
            TestItem.StaffSalary = 30000;
            TestItem.StaffEmailAddress = "jayemail@gmail.com";
            TestItem.StaffDOB = DateTime.Parse("23/03/1999");
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //create an instance of the class 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class 
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key 
            Int32 PrimaryKey = 0;
            //set the propertiess
            TestItem.Employer = true;
            TestItem.StaffID = 1;
            TestItem.StaffName = "Name";
            TestItem.StaffSalary = 30000;
            TestItem.StaffEmailAddress = "jayemail@gmail.com";
            TestItem.StaffDOB = DateTime.Parse("23/03/1999");
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record 
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same 
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
        

    }
}
