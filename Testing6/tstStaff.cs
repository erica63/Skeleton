using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing6
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStaff StaffMember = new clsStaff();
            //test to see that it exists 
            Assert.IsNotNull(StaffMember);
        }
    }
}
