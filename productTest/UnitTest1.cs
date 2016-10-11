using Microsoft.VisualStudio.TestTools.UnitTesting;
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

            List<Product> products = GetProductList();

            #endregion 假資料

            #region 期望值

            List<int> expected = new List<int>() { 5,6,6,4};

            #endregion 期望值

            #region 結果

            ProductCore productCoreObj = new ProductCore();
            List<int> actual = productCoreObj.Sum<Product>(products, "Cost", 3);

            #endregion 結果

            #region 比較結果

            CollectionAssert.AreEqual(expected, actual);

            #endregion 比較結果
        }

        [TestMethod]
        public void 按照四組總合Cost值()
        {
            #region 假資料

            List<Product> products = GetProductList();

            #endregion 假資料

            #region 期望值
            
            List<int> expected = new List<int>() { 7, 8, 6 };

            #endregion 期望值

            #region 結果

            ProductCore productCoreObj = new ProductCore();
            List<int> actual = productCoreObj.Sum<Product>(products, "Cost", 4);

            #endregion 結果

            #region 比較結果

            CollectionAssert.AreEqual(expected, actual);

            #endregion 比較結果
        }

        private static List<Product> GetProductList()
        {
            var products = new List<Product>()
            {
                        new Product() { Id=1 ,Cost=1 ,Revenue=11,SellPrice=21 },
                        new Product() { Id=2 ,Cost=2 ,Revenue=12,SellPrice=22 },
                        new Product() { Id=3 ,Cost=2 ,Revenue=12,SellPrice=22 },
                        new Product() { Id=4 ,Cost=2 ,Revenue=12,SellPrice=22 },
                        new Product() { Id=5 ,Cost=2 ,Revenue=12,SellPrice=22 },
                        new Product() {Id=6 ,Cost=2 ,Revenue=12,SellPrice=22 },          new Product() { Id=7 ,Cost=2 ,Revenue=12,SellPrice=22 },
                        new Product() { Id=8 ,Cost=2 ,Revenue=12,SellPrice=22 },
                        new Product() { Id=9 ,Cost=2 ,Revenue=12,SellPrice=22 },
                        new Product() { Id=10 ,Cost=2 ,Revenue=12,SellPrice=22 },
                        new Product() { Id=11 ,Cost=2 ,Revenue=12,SellPrice=22 },
            };
            return products;
        }
    }
}