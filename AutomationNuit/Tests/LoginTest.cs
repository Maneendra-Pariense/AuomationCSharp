using AutomationNunit.Pages;

namespace AutomationNunit.Tests
{
    [Parallelizable(scope:ParallelScope.All)]

    public class LoginTest: SetupPage
    {
        [Test]
        public void ClickSkipSignInButtonShouldNavigateToRegisterScreen()
        {
            loginPage.ClickOnSkipSignInButton();
            var actualTitle = registerPage.GetRegisterPageTitle();
            Assert.That(actualTitle, Is.EqualTo("Register"));            
            registerPage.EnterFirstName("Maneendra");

        }       
        
    }
}
