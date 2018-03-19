using OpenQA.Selenium;

namespace ValTechQAChallenge.SeleniumFramework.PageObjects
{
    public class HomePage
    {
        private IWebDriver WebDriver;

        public static string Url
        {
            get { return "http://www.valtech.com/"; }
        }

        public HomePage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public void NavigateToSection(string section)
        {
            WebDriver.Navigate().GoToUrl(Url+section);
        }
    }
}
