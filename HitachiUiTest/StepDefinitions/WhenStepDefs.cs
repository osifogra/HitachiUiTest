using HitachiUiTest.PageObjects;
using OpenQA.Selenium;

namespace HitachiUiTest.StepDefinitions
{
    [Binding]
    public sealed class WhenStepDefs : BasePage
    {

        public WhenStepDefs(IWebDriver driver)
        {
            Driver = driver;
        }

        [When(@"I choose to enter '([^']*)' as my search text")]
        public void WhenIChooseToEnterAsMySearchText(string searchText)
        {
            CurrentPage<HomePage>().EnterSearchText(searchText);
        }

        [When(@"I choose to select '([^']*)'")]
        public void WhenIChooseToSelect(string searchText)
        {
            CurrentPage<SearchPage>().SelectSearchResult(searchText);
        }


    }
}