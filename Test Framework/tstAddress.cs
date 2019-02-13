using System;
using Class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of our class clsAddress
            clsAddress AnAddress = new clsAddress();
            //check to see what the class is not null
            Assert.IsNotNull(AnAddress);
        }
    }
}
