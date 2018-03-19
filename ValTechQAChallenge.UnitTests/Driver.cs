using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System;

namespace ValTechQAChallenge.UnitTests
{
    internal class Driver
    {
        public IWebDriver Instance { get; private set; }

        public void Initialise()
        {
            Instance = new PhantomJSDriver();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
    }
}
