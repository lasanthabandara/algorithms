using Algorithms.HackerRank.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgorithmTests
{
    [TestClass]
    public class FruitPromotionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var codeList = new List<string>()
            {
                "aaa",
                "bbb ccc",
                "ddd"
            };
            var shoppingCart = new List<string>()
            {
                "aaa",
                "bbb",
                "ccc",
                "ddd"
            };

            //Act
            var result = FruitPromotion.foo(codeList, shoppingCart);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var codeList = new List<string>()
            {
                "aaa",
                "bbb ccc",
                "ddd"
            };
            var shoppingCart = new List<string>()
            {
                "asdfasdfasd",
                "asdfasd",
                "aaa",
                "bbb",
                "ccc",
                "ddd",
                "asdfasdfasd",
                "asdfasd"
            };

            //Act
            var result = FruitPromotion.foo(codeList, shoppingCart);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var codeList = new List<string>()
            {
                "aaa",
                "bbb ccc",
                "ddd"
            };
            var shoppingCart = new List<string>()
            {
                "asdfasdfasd",
                "asdfasd",
                "aaa",
                "asdfasdf",
                "bbb",
                "ccc",
                "asdfasdf",
                "ddd",
                "asdfasdfasd",
                "asdfasd"
            };

            //Act
            var result = FruitPromotion.foo(codeList, shoppingCart);

            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            var codeList = new List<string>()
            {
                "aaa",
                "bbb ccc",
                "ddd"
            };
            var shoppingCart = new List<string>()
            {
                "asdfasdfasd",
                "asdfasd",
                "aaa",
                "asdfasdf",
                "bbb",
                "asdfasd",
                "ccc",
                "asdfasdf",
                "ddd",
                "asdfasdfasd",
                "asdfasd"
            };

            //Act
            var result = FruitPromotion.foo(codeList, shoppingCart);

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            var codeList = new List<string>()
            {
                "aaa",
                "bbb anything ccc",
                "ddd"
            };
            var shoppingCart = new List<string>()
            {
                "asdfasdfasd",
                "asdfasd",
                "aaa",
                "asdfasdf",
                "bbb",
                "asdfasd",
                "ccc",
                "asdfasdf",
                "ddd",
                "asdfasdfasd",
                "asdfasd"
            };

            //Act
            var result = FruitPromotion.foo(codeList, shoppingCart);

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
