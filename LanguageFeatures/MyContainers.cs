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

}