namespace AutomationNunit.Pages
{
    public class HomePage: BasePage
    {

        #region Locators

        IWebElement homePageTitle => driverFacade.GetDriver().FindElement(By.TagName("h1"));

        #endregion


        #region Methods

        public string GetHomePageTitle()
        {
            return homePageTitle.Text;
        }

        #endregion
    }
}
