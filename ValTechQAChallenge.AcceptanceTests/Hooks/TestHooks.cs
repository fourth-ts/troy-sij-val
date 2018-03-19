using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ValTechQAChallenge.SeleniumFramework.Common;

namespace ValTechQAChallenge.AcceptanceTests.Hooks
{
    [Binding]
    public sealed class TestHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Driver.Instance = new ChromeDriver();
            Driver.Initialize();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Driver.Instance.Quit();
        }
    }
}
