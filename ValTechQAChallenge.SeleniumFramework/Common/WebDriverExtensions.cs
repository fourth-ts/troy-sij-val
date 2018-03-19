using OpenQA.Selenium;
using System.Collections.Generic;

namespace ValTechQAChallenge.SeleniumFramework.Common
{
    public static class WebDriverExtensions
    {
        public static IWebElement FindWebElementByTagName(this IWebDriver webDriver, string elementTagName)
        {
            return webDriver.FindElement(By.TagName(elementTagName));
        }

        public static IEnumerable<IWebElement> FindWebElementsByCssSelector(this IWebDriver webDriver, string elementCssSelector)
        {
            var webElement = webDriver.FindElements(By.CssSelector(elementCssSelector));
            return webElement;
        }

    }
}
