using Framework.Helpers;
using Unity;

namespace AutomationNunit.Pages
{
    public class SetupPage
    {
        public SetupPage() {
           
        }
        protected LoginPage loginPage => GetPage<LoginPage>();
        public T GetPage<T>() where T : BasePage, new()
        {
            return BasePage.GetPage<T>();
        }

        [SetUp]
        public static void TestInit()
        {
            var unityContainer = UnityContainerFactory.GetContainer();
            unityContainer.RegisterType<ConfigHelper>(TypeLifetime.Singleton);
            unityContainer.RegisterType<DisposableContainer>(TypeLifetime.Singleton);
            unityContainer.RegisterType<DriverFacade>(TypeLifetime.PerThread);
        }

        
    }
}
