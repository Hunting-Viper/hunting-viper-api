using System;
using Hunting.Viper.Domain.Catalog;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hunting.Viper.Domain.Tests;

[TestClass]
public sealed class RatingTests
{
    [TestMethod]
    public void Can_Create_New_Rating()
    {
        // Arrange
        var rating = new Rating(1, "Mike", "Great fit!");

        // Act (empty)

        // Assert
        Assert.AreEqual(1, rating.Stars);
        Assert.AreEqual("Mike", rating.UserName);
        Assert.AreEqual("Great fit!", rating.Review);
    }

    //Code from instructions kept giving me an error
    [TestMethod]
    public void Cannot_Create_Rating_With_Invalid_Stars()
    {
        try
        {
            var rating = new Rating(0, "Mike", "Great fit!");
            Assert.Fail("The constructor should have crashed with 0 stars!");
        }
        catch (System.ArgumentException)
        {
        }
    }
}
