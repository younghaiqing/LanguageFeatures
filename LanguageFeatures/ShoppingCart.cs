using System.Collections;
using System.Collections.Generic;

namespace LanguageFeatures
{
    public class ShoppingCart : IEnumerable<Product>
    {
        /// <summary>
        ///  IEnumerable接口中有个方法，需要返回方法IEnumerator 可以遍历    Product
        /// </summary>
        public List<Product> Products { get; set; }

        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}