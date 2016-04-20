using System;
using System.Collections.Generic;

namespace LanguageFeatures
{
    public static class MyExtensionMethods
    {
        #region 该方法为拓展方法（this 本类），class必须为静态，方法也为静态

        /// <summary>
        /// 该方法为拓展方法（this ），class必须为静态，方法也为静态
        /// </summary>
        /// <param name="cartParam">购物的种类</param>
        /// <returns>总价格</returns>
        public static decimal TotalPrices1(this ShoppingCart cartParam, int a)
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod.Price;
            }
            return total * a;
        }

        #endregion 该方法为拓展方法（this ），class必须为静态，方法也为静态

        /// <summary>
        ///    ShoppingCart继承了 IEnumerable接口
        /// </summary>
        /// <param name="productEnum"></param>
        /// <returns></returns>
        public static decimal TotalPrices(this IEnumerable<Product> productEnum)
        {
            decimal total = 0;
            foreach (Product prod in productEnum)
            {
                total += prod.Price;
            }
            return total;
        }

        /// <summary>
        ///   ShoppingCart继承了 IEnumerable<Product>接口,该接口拓展了方法了FilterByCategory，返回的参数为IEnumerable<Product>，还可以调用TotalPrices方法 
        /// </summary>
        /// <param name="productEnum">拓展方法的类</param>
        /// <param name="cataoryParam"></param>
        /// <returns>cataoryParam过滤掉的数据</returns>
        public static IEnumerable<Product> FilterByCategory(this IEnumerable<Product> productEnum, string cataoryParam)
        {
            foreach (Product prod in productEnum)
            {
                if (prod.Category == cataoryParam)
                {
                    yield return prod;
                }
            }


        }

        public static IEnumerable<Product> Filter(this IEnumerable<Product> productEnum,Func<Product,bool> selectorParam)
        {
            foreach (Product prod in productEnum)
            {
                if (selectorParam(prod))
                {
                    yield return prod;
                }
            }


        }
    }
}