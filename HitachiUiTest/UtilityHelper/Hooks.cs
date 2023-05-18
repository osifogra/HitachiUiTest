﻿using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HitachiUiTest.UtilityHelper
{
    [Binding]
    public sealed class Hooks : DriverManager
    {
        private readonly IObjectContainer _objectContaniner;

        public Hooks(IObjectContainer objectContaniner)
        {
            _objectContaniner = objectContaniner;
        }

        public void InitializeBrowser()
        {
            if (Driver == null)
            {
                switch (ConfigManager.BrowsersType)
                {
                    case "chrome":
                        Console.WriteLine("Opening Chrome Browser");
                        Driver = new ChromeDriver();
                        break;

                    default:
                        Assert.Fail("Wrong browser specified");
                        break;
                }
                _objectContaniner.RegisterInstanceAs<IWebDriver>(Driver);
                Driver.Manage().Window.Maximize();
            }
            else
            {
                Console.WriteLine(ConfigManager.BrowsersType + " browser is already opened");
            }
        }

        public void CloseBrowser()
        {
            if (Driver != null)
            {
                Console.WriteLine("\r\n" + "Close Browser" + "\r\n");
                Driver.Quit();
                Driver = null;
            }
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            InitializeBrowser();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();
        }
    }
}
