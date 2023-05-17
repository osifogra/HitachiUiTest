using HitachiUiTest.UtilityHelper;
using OpenQA.Selenium;

namespace HitachiUiTest.PageObjects
{
    public class BasePage : DriverManager
    {
        /// <summary>
        /// Note that this class inherit from DriverManager class
        /// </summary>
        public T CurrentPage<T>() where T : BasePage, new()
        {
            var page = new T { Driver = Driver };
            return page;
        }

        public string GetPageTitle()
        {
            return Driver.Title;
        }

        public string PageHeaderTitle()
        {
            return Driver.FindElement(By.CssSelector("h1")).Text;
        }
    }
}
