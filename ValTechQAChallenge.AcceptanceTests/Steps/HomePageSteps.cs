using FluentAssertions;
using System.Linq;
using TechTalk.SpecFlow;
using ValTechQAChallenge.SeleniumFramework.Common;
using ValTechQAChallenge.SeleniumFramework.PageObjects;

namespace ValTechQAChallenge.AcceptanceTests.Steps
{
    [Binding]
    public sealed class HomePageSteps
    {
        private readonly HomePage homePage;
        

        public HomePageSteps()
        {
            homePage = new HomePage(Driver.Instance);
        }

        [Given(@"I am on the valtech Home page")]
        public void GivenIAmOnTheValtechHomePage()
        {
            Driver.Instance.Navigate().GoToUrl(HomePage.Url);
        }

        [When(@"I navigate to the (.*) section")]
        public void WhenINavigateToSection(string section)
        {
            homePage.NavigateToSection(section);
        }

        [When(@"I navigate to the Contact Us page")]
        public void WhenINavigateToContactUsSection()
        {
            homePage.NavigateToSection("about/contact-us");
        }
        

        [Then(@"I should see the (.*) page")]
        public void ThenIShouldSeeTheAboutPage(string expectedHeader)
        {
            var actualHeader = Driver.Instance.FindWebElementByTagName("H1").Text;
            actualHeader.Should().Be(expectedHeader);
        }

        [Then(@"I should see (.*) offices in total")]
        public void ThenIShouldSeeOfficesInTotal(int expectedTotalNoOfOffices)
        {
            int actualTotalNoOfOffices = Driver.Instance.FindWebElementsByCssSelector("header.office__header").ToList().Count;

            actualTotalNoOfOffices.Should().Be(expectedTotalNoOfOffices);
        }

        [Then(@"I should see the Latest News section")]
        public void ThenIShouldSeeTheLatestNewsSection()
        {
            Driver.Instance.PageSource.Should().Contain("Latest news");
        }



    }
}
