using FoodTruckFinder.Models;
using NUnit.Framework;

namespace FoodTruckFinder.Test
{
    [TestFixture]
    public class FoodTrucTests 
    {
        [Test]
        public void ContructorTest()
        {
            FoodTruck truck = new FoodTruck(1, "test1");
            Assert.AreEqual(1, truck.LocationId);
            Assert.AreEqual("test1", truck.LocationDesc);
        }
    }
}
