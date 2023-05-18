using HitachiUiTest.PageObjects;
using HitachiUiTest.UtilityHelper;
using OpenQA.Selenium;

namespace HitachiUiTest.StepDefinitions
{
    [Binding]
    public sealed class GivenStepDefs : BasePage
    {
        public GivenStepDefs(IWebDriver driver)
        {
            Driver = driver;
        }

        [Given(@"I navigate to Hitachi site")]
        public void GivenINavigateToHitachiSite()
        {
            Driver.Navigate().GoToUrl(ConfigManager.WebSiteUrl);
        }
    }
}