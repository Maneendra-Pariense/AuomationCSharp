using Framework.Helpers;
using Unity;

namespace AutomationNunit.Pages
{
    public class SetupPage
    {
        #region Pages 
        protected LoginPage loginPage => GetPage<LoginPage>();
        protected HomePage homePage => GetPage<HomePage>();
        protected RegisterPage registerPage => GetPage<RegisterPage>();

        #endregion

        public T GetPage<T>() where T : BasePage, new()
        {
            return BasePage.GetPage<T>();
        }

        #region Setup and TearDown

        [SetUp]
        public static void TestInit()
        {
            var unityContainer = UnityContainerFactory.GetContainer();
            unityContainer.RegisterType<ConfigHelper>(TypeLifetime.Singleton);
            unityContainer.RegisterType<DisposableContainer>(TypeLifetime.Singleton);
            unityContainer.RegisterType<DriverFacade>(TypeLifetime.PerThread);
        }

        [TearDown]
        public void TearDown()
        {
            var driverFacade = UnityContainerFactory.GetContainer().Resolve<DriverFacade>();
            driverFacade.CloseDriver();
            driverFacade.Dispose();
        }

        #endregion

    }
}
