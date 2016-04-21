using System;

namespace LanguageFeatures
{
    public class MyInterfaces
    {
    }

    public interface IMonthProvider
    {
        string GetCurrent1();
    }

    public interface IYearProvider
    {
        string GetCurrent();
    }

    public class TimeProvider : IMonthProvider, IYearProvider
    {
        private DateTime now = DateTime.Now;

         string IMonthProvider.GetCurrent1()
        {
            return now.ToString("MM");
        }

         string IYearProvider.GetCurrent()
        {
            return now.ToString();
        }
    }
}