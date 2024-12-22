using AutomationNunit.Pages;

namespace AutomationNunit.Tests
{
    [Parallelizable(scope:ParallelScope.Self)]

    public class LoginTest: SetupPage
    {
        [Test]
        public void Login()
        {
            Console.WriteLine(loginPage.GetTitle());            
            loginPage.ClickOnSearch(); 
        }

        [Test]
        public void LoginTest1()
        {
            var dir = TestContext.CurrentContext;
            Console.WriteLine(dir);
            Console.WriteLine(loginPage.GetTitle());
            loginPage.ClickOnSearch();
        }
        [Test]        
        public void Login1()
        {
            loginPage.GoToUrl();
        }
        [Test]
        public void Login2()
        {
            Console.WriteLine(loginPage.GetTitle());
            loginPage.ClickOnSearch();
        }
        

        [TearDown]
        public void TearDown()
        {
            loginPage.TearDown();
        }
    }
}
