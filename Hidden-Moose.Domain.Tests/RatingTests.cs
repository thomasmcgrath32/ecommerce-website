using System;
using Hidden.Moose.Domain.Catalog;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hidden_Moose.Domain.Tests
{
    [TestClass]
    public class RatingTests
    {
        [TestMethod]
        public void Can_Create_New_Rating()
        {
            //Arrange
            var rating = new Rating(1, "Mike","Great Fit!");

            //Act - skip because there isn't action on constructor
            //Assert
            Assert.AreEqual(1,rating.Star);
            Assert.AreEqual("Mike",rating.UserName);
            Assert.AreEqual("Great Fit!",rating.Review);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_With_Bad_Start_Throws_Error()
        {
            var rating = new Rating(0,"Name", "Review");
        }
    }
}
