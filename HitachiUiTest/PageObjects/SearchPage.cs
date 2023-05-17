using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitachiUiTest.PageObjects
{
    public class SearchPage : BasePage
    {
        public IWebElement ResultsHeaderText => Driver.FindElement(By.CssSelector("[class='results-header']"));

        public void SelectSearchResult(string textValue)
        {
            Driver.FindElement(By.LinkText(textValue)).Click();
        }
    }
}
