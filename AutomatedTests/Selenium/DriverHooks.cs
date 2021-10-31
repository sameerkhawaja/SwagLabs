using BoDi;
using OpenQA.Selenium;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AutomatedTests.Selenium
{
    [Binding]
    public class DriverHooks
    {
        private readonly IObjectContainer _objectContainer;

        public DriverHooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            var driver = Setup.ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(driver, Constants.WEBDRIVER);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver = _objectContainer.Resolve<IWebDriver>(Constants.WEBDRIVER);
            Cleanup.Webdriver(driver);
        }
    }
}
