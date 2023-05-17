using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace HitachiUiTest.UtilityHelper
{
    [Binding]
    public sealed class Hooks : DriverManager
    {
        private readonly IObjectContainer _objectContaniner;
        //private readonly ScenarioContext scenarioContext;

        public Hooks()
        {
        }

        public Hooks(IObjectContainer objectContaniner, ScenarioContext scenarioContext)
        {
            _objectContaniner = objectContaniner;
            //this.scenarioContext = scenarioContext;
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

                    case "firefox":
                        Console.WriteLine("Opening Firefox Browser");
                        Driver = new FirefoxDriver();
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
    }
}
