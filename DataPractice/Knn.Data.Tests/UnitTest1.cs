using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Knn.Data.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanLoadAdultsFromFile()
        {
            var myLoader = new FileDataLoader("Data\\adult.data.txt");
            var adults = myLoader.LoadAdults();

            Assert.AreEqual(39, adults.First().Age);
            Assert.AreEqual(32561, adults.Count());
        }
    }
}
