using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HitachiUiTest.UtilityHelper
{
    [Binding]
    public class DriverManager
    {
        public IWebDriver Driver { get; set; }

        public void WaitUntilElementIsVisible(By locator, int waitDuration = 30)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitDuration));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public bool IsElementPresent(By locator)
        {
            try
            {
                Driver.FindElement(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}