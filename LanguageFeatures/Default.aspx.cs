using System;
using System.Collections.Generic;

namespace LanguageFeatures
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 《精通asp.net4.5》书40页之前的内容
        /// </summary>
        /// <returns></returns>
        protected string GetMessage1()
        {
            #region 构建和初始化包含属性的对象

            //Product myProduct = new Product();
            //myProduct.Name = "Young";
            //myProduct.ProductID = 100;
            //myProduct.Description = "a BOAT FOR one person";
            //myProduct.Price = 247;
            //myProduct.Category = "watersports";

            #endregion 构建和初始化包含属性的对象

            #region //使用对象初始化器功能

            //Product myProduct1 = new Product { Name = "YOUNG1", Category = "hotsports", Price = 120, ProductID = 525 };
            // return string.Format("Product name:{0}", myProduct1.Category);

            #endregion //使用对象初始化器功能

            #region 对集合和数组进行初始化

            //string[] stringArray = { "apple", "orange", "plum" };
            //List<int> intList = new List<int> { 10, 20, 30, 40 };
            //Dictionary<string, int> myDict = new Dictionary<string, int> { { "apple", 10 }, { "orange", 20 }, { "plum", 30 } };
            //return string.Format("{0}", intList[2]);

            #endregion 对集合和数组进行初始化

            #region 应用拓展方法

            //已一个集合的形式传递给shoppingcart
            List<Product> lisr = new List<Product>();
            lisr.Add(new Product { Name = "Tom,", Price = 125 });
            lisr.Add(new Product { Name = "Tom,", Price = 125 });
            lisr.Add(new Product { Name = "Tom,", Price = 125 });
            ShoppingCart cart11 = new ShoppingCart();
            cart11.Products = lisr;

            ShoppingCart cart = new ShoppingCart { Products = new List<Product> { new Product { Name = "Tom,", Price = 125 }, new Product { Name = "Kayak", Price = 256 }, new Product { Name = "Young", Price = 120 } } };

            decimal cartTotal = cart.TotalPrices();

            return string.Format("Total:{0}", cartTotal);

            #endregion 应用拓展方法
        }

        public string GetMessage()
        {
            IEnumerable<Product> products = new ShoppingCart { Products = new List<Product> { new Product { Name = "Young", Price = 245, Category = "watersports" }, new Product { Name = "wang", Price = 165, Category = "watersports" }, new Product { Name = "san", Price = 621, Category = "Soccer" } } };
            Product[] productArray = { new Product { Name = "XING", Price = 120 }, new Product { Name = "EDASS", Price = 1120 }, new Product { Name = "XVEDD", Price = 120 } };
            decimal cartTotal = products.TotalPrices();
            decimal arrayTotal = productArray.TotalPrices();
            decimal yieldCartTotal = products.FilterByCategory("Soccer").TotalPrices(); ;
            //过滤方法一
            //Func<Product, bool> categoryFiler = delegate(Product prod)
            //{
            //    return prod.Category == "Soccer";
            //};
            //过滤方法2 ：lambda 替换委托定义
            // Func<Product, bool> categoryFiler = prod => prod.Category == "Soccer";
            // decimal total= products.Filter(categoryFiler).TotalPrices();
            //过滤方法2 ：lambda 没有Func
            decimal total = products.Filter(prod => prod.Category == "Soccer"||prod.Price>20).TotalPrices();

            return string.Format("Cart Total:{0},Array Total:{1},yield  Soccer Total:{2},filer Total:{3}", cartTotal, arrayTotal, yieldCartTotal, total);
        }
    }
}