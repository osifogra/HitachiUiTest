using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HitachiUiTest.PageObjects
{
    public class HomePage : BasePage
    {
        public IWebElement GlobalSearchBtn => Driver.FindElement(By.Id("open-global-search"));
        public IWebElement SearchTextField => Driver.FindElement(By.Id("site-search-keyword"));
        public IWebElement SearchBtn => Driver.FindElement(By.CssSelector("[class='search-form-submit']"));

        public void EnterSearchText(string searchText)
        {
            GlobalSearchBtn.Click();
            SearchTextField.SendKeys(searchText);
            SearchBtn.Click();
        }
    }
}
