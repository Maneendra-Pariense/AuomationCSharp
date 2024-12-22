using Framework.Enums;
using Framework.Helpers;

namespace AutomationNunit.Pages
{
    public class LoginPage: BasePage
    {

        public LocatorHelper Search = new LocatorHelper("q", LocatorType.Name);
        public LocatorHelper SkipSignInButton = new LocatorHelper("btn2", LocatorType.Id);
       

        private IWebElement search => driverFacade.WaitUntilElementVisible(Search.GetBy());
        private IWebElement skipSignInButton => driverFacade.WaitUntilElementVisible(SkipSignInButton.GetBy());


        public void GoToUrl()
        {          
            driverFacade.GoToUrl("https://www.google.com");
        }

        public string GetTitle()
        {
            return driverFacade.GetDriver().Title;
        }

        public void ClickOnSearch()
        {
            //search.Click();
            skipSignInButton.Click();
        }

        public void EnterInSearch(string searchTearm)
        {
            search.SendKeys(searchTearm);
        }
        
    }
}