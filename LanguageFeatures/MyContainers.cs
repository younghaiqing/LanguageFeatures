using System;

namespace LanguageFeatures
{
    public class MyContainers
    {
    }

    #region 使用通用类来替换下面的类
    public class StringContainer
    {
        public string Value { get; set; }

        public bool HasValue
        {
            get { return Value != null; }
        }
    }

    public class DateTimeContainer
    {
        public DateTime Value { get; set; }

        public bool HasValue
        {
            get { return Value != null; }
        }
    }
    #endregion


    public class BaseContainer
    {
        public object Value { get; set; }
        public bool HasValue {
            get { return Value != null; }
        }
    }

    //使用泛型参数，解决了重复使用的问题，避免转换问题带来了风险，可以简化代码，提高维护性和稳定性。
    public class ValueContainer<T> 
    {
        public T Value { get; set; }
        public bool HasValue {
            get { return Value != null; }
        }
    }

}