using AutomationNunit.Pages;

namespace AutomationNunit.Tests
{
    public class LoginTest: SetupPage
    {
        [Test]
        public void Login()
        {

            //LoginPage page = new LoginPage();
            //page.GetTitle();
            //page.ClickOnSearch();
            //page.EnterInSearch("Adaps");
            loginPage.ClickOnSearch();
            //loginPage.EnterInSearch("Adaps");
            //loginPage.EnterInSearch("Adaps");


        }
    }
}
