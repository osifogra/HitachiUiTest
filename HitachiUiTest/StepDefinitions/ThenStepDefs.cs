using HitachiUiTest.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace HitachiUiTest.StepDefinitions
{
    [Binding]
    public sealed class ThenStepDefs : BasePage
    {
        private readonly ScenarioContext _scenarioContext;

        public ThenStepDefs(IWebDriver driver, ScenarioContext scenarioContext)
        {
            Driver = driver;
            _scenarioContext = scenarioContext;
        }

        [Then(@"I should see '([^']*)' search result return")]
        public void ThenIShouldSeeSearchResultReturn(string searchText)
        {
            var actualPageHeaderText = CurrentPage<SearchPage>().ResultsHeaderText.Text;
            Assert.IsTrue(actualPageHeaderText.StartsWith($"Search results for: {searchText}"));
        }

        [Then(@"I should see ""([^""]*)"" message returned")]
        public void ThenIShouldSeeMessageReturned(string message)
        {
            var actualPageHeaderText = CurrentPage<SearchPage>().ResultsHeaderText.Text;
            Assert.AreEqual(message, actualPageHeaderText);
        }

        [Then(@"I should see '([^']*)' page displayed")]
        public void ThenIShouldSeePageDisplayed(string expectedPageHeaderText)
        {
            var actualPageHeaderText = CurrentPage<DataAndAnalyticsPage>().PageHeaderTitle();
            Assert.AreEqual(expectedPageHeaderText, actualPageHeaderText);
        }
    }
}