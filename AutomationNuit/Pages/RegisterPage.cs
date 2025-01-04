namespace AutomationNunit.Pages
{
    public class RegisterPage: BasePage
    {

        #region Locators
        //IWebElement registerPageTitleElement => _driver.FindElement(By.TagName("h2"));

        //IWebElement firstNameInput => _driver.FindElement(By.XPath("//input[@placeholder = 'First Name']"));

        IWebElement registerPageTitleElement => driverFacade.GetDriver().FindElement(By.TagName("h2"));
        IWebElement firstNameInput => driverFacade.GetDriver().FindElement(By.XPath("//input[@placeholder = 'First Name']"));
        #endregion

        #region Methods

        public string GetRegisterPageTitle()
        {
            return registerPageTitleElement.Text;
        }

        public void EnterFirstName(string value)
        {
            firstNameInput.SendKeys(value);
        }

        #endregion
    }
}
