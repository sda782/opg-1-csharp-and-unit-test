using Microsoft.VisualStudio.TestTools.UnitTesting;
using opg_1_csharp_and_unit_test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg_1_csharp_and_unit_test.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        /// <summary>
        /// Testing Id
        /// </summary>
        [TestMethod()]
        public void IdTest()
        {
            FootballPlayer player = new FootballPlayer(1, "andy", 1, 55);
            Assert.AreEqual(player.Id, 1);
        }
        /// <summary>
        /// Testing Name cannot be shorter than 4 characters
        /// </summary>
        [TestMethod()]
        public void NameTest()
        {
            FootballPlayer player = new FootballPlayer(1, "andy", 1, 55);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                player.Name = "bob";
            });
            Assert.AreEqual(player.Name, "andy");
        }
        /// <summary>
        /// Testing price must be larger than 0
        /// </summary>
        [TestMethod()]
        public void PriceTest()
        {
            FootballPlayer player = new FootballPlayer(1, "andy", 1, 55);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                player.Price = 0;
            });
            Assert.AreEqual(player.Price, 1);
        }
        /// <summary>
        /// Testing shirtnumber must be >=1 and <=100
        /// </summary>
        [TestMethod()]
        public void ShirtNumberTest()
        {
            FootballPlayer player = new FootballPlayer(1, "andy", 1, 55);
            // Test for lower number
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                player.Shirt_number = 0;
            });
            // Test for higher number
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                player.Shirt_number = 101;
            });
            Assert.AreEqual(player.Shirt_number, 55);
        }
    }
}
