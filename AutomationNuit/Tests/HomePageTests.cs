using AutomationNunit.Pages;

namespace AutomationNunit.Tests
{
    public class HomePageTests: SetupPage
    {

        [Test]
        public void TestHomePageTitle()
        {
            loginPage.ClickOnSkipSignInButton();
            var actualTitle = homePage.GetHomePageTitle();
            Assert.That(actualTitle, Is.EqualTo("Automation Demo Site"));
        }
        
    }
}
