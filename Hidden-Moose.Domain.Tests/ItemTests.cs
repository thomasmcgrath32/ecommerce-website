using System;
using Hidden.Moose.Domain.Catalog;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hidden_Moose.Domain.Tests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void Can_Create_New_Item()
        {
            var item = new Item("Name","Description", "Brand","/images/d1.jpg",10.00m);

            Assert.AreEqual("Name",item.Name);
            Assert.AreEqual("Description", item.Description);
            Assert.AreEqual("/images/d1.jpg",item.ImageUrl);
            Assert.AreEqual("Brand", item.Brand);
            Assert.AreEqual(10.00m, item.Price);
        }
    }
}