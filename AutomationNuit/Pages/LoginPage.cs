using Framework.Enums;
using Framework.Helpers;
using Microsoft.Extensions.Configuration;

namespace AutomationNunit.Pages
{
    public class LoginPage: BasePage
    {
        #region Locators
        public LocatorHelper SkipSignInButton = new LocatorHelper("btn2", LocatorType.Id);
        private IWebElement skipSignInButton => driverFacade.WaitUntilElementVisible(SkipSignInButton.GetBy());
        #endregion

        #region Methods

        public void GoToUrl()
        {           
            driverFacade.GoToUrl("https://www.google.com");
        }

        public string GetTitle()
        {
            return driverFacade.GetDriver().Title;
        }        

        public void GetTestData()
        {
            var testData = _testDataManager.GetTestData("TestData1");
            var test = testData.GetValue<string>("Test");
            Console.WriteLine(test);
        }

        public void ClickOnSkipSignInButton()
        {
            skipSignInButton.Click();
        }

        #endregion

    }
}