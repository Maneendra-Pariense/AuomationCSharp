using Framework.Helpers;
using Unity;

namespace AutomationNunit.Pages
{
    public class BasePage
    {
        protected readonly DriverFacade driverFacade;
        protected readonly TestDataManager _testDataManager;
        public BasePage()
        {
            driverFacade = UnityContainerFactory.GetContainer().Resolve<DriverFacade>();
            _testDataManager = UnityContainerFactory.GetContainer().Resolve<TestDataManager>();
        }
        public static T GetPage<T>() where T : BasePage, new() => new();

        public void TearDown()
        {
            driverFacade.Dispose();
        }


    }
}
