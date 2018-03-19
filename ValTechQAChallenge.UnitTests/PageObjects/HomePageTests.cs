using FluentAssertions;
using NUnit.Framework;
using System;
using ValTechQAChallenge.SeleniumFramework.PageObjects;

namespace ValTechQAChallenge.UnitTests.PageObjects
{
   
    [TestFixture]
    public class HomePageTests
    {
        private readonly Driver _driver = new Driver();

        [SetUp]
        public void SetUp()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            string htmlFile = $"file://{dir}\\HtmlTestPages\\HomePage.html";
            var baseUrl = new Uri(htmlFile);
            _driver.Instance.Navigate().GoToUrl(baseUrl);
        }

        [OneTimeSetUp]
        public void SetupFixture()
        {
            _driver.Initialise();
        }

        [OneTimeTearDown]
        public void TearDownFixture()
        {
            _driver.Instance.Quit();
        }

        [Test]
        public void Launch_DisplaysTheHomePage()
        {
            const string expectedPageTitle = "";

            var loginPage = new HomePage(_driver.Instance);
            //loginPage.Launch();


            var actualPageTitle = _driver.Instance.Title;

            actualPageTitle.Should().Be(expectedPageTitle);
        }

        


    }
}
