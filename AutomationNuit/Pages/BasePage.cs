using Framework.Helpers;
using Unity;

namespace AutomationNunit.Pages
{
    public class BasePage
    {
        protected readonly DriverFacade driverFacade;
        public BasePage()
        {
            driverFacade = UnityContainerFactory.GetContainer().Resolve<DriverFacade>();
        }
        public static T GetPage<T>() where T : BasePage, new() => new();

        

    }
}
