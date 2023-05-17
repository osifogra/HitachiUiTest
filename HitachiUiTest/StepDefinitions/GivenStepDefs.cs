using HitachiUiTest.PageObjects;
using HitachiUiTest.UtilityHelper;
using OpenQA.Selenium;

namespace HitachiUiTest.StepDefinitions
{
    [Binding]
    public sealed class GivenStepDefs : BasePage
    {
        private readonly ScenarioContext _scenarioContext;

        public GivenStepDefs(IWebDriver driver, ScenarioContext scenarioContext)
        {
            Driver = driver;
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to Hitachi site")]
        public void GivenINavigateToHitachiSite()
        {
            Driver.Navigate().GoToUrl(ConfigManager.WebSiteUrl);
        }




    }
}