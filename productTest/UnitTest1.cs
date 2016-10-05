using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using productTest;
using System.Collections.Generic;

namespace productTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void 按照三組總合Cost的值()
        {
            #region 假資料
            List<Product> productList = new List<Product>();
            productList.Add(new Product()
            {
                id = 1,
                cost = 100,
                revenue = 120,
                sellPrice = 220
            });

            productList.Add(new Product()
            {
                id = 2,
                cost = 100,
                revenue = 120,
                sellPrice = 220
            });

            productList.Add(new Product()
            {
                id = 3,
                cost = 100,
                revenue = 120,
                sellPrice = 220
            });

            productList.Add(new Product()
            {
                id = 4,
                cost = 100,
                revenue = 120,
                sellPrice = 220
            });

            productList.Add(new Product()
            {
                id = 5,
                cost = 100,
                revenue = 120,
                sellPrice = 220
            });
            #endregion

            #region 期望值
            List<int> expected = new List<int>() {
                300,
                200
            };
            #endregion

            #region 結果
            IProductCore productCoreObj = new ProductCore();
            List<int> actual = productCoreObj.Sum<Product>(productList, "cost", 3);

            #endregion

            #region 比較結果
            Assert.AreEqual(expected[0], actual[0]);

            #endregion
        }

        [TestMethod]
        public void 按照四組總合Cost值()
        {
            #region 假資料
            List<Product> productList = new List<Product>();
            productList.Add(new Product()
            {
                id = 1,
                cost = 100,
                revenue = 120,
                sellPrice = 220
            });

            productList.Add(new Product()
            {
                id = 2,
                cost = 100,
                revenue = 120,
                sellPrice = 220
            });

            productList.Add(new Product()
            {
                id = 3,
                cost = 100,
                revenue = 120,
                sellPrice = 220
            });

            productList.Add(new Product()
            {
                id = 4,
                cost = 100,
                revenue = 120,
                sellPrice = 220
            });

            productList.Add(new Product()
            {
                id = 5,
                cost = 100,
                revenue = 120,
                sellPrice = 220
            });
            #endregion

            #region 期望值
            List<int> expected = new List<int>() {
                400,
                100
            };
            #endregion

            #region 結果
            IProductCore productCoreObj = new ProductCore();
            List<int> actual = productCoreObj.Sum<Product>(productList, "cost", 4);

            #endregion

            #region 比較結果
            Assert.AreEqual(expected[1], actual[1]);

            #endregion
        }

    }
}