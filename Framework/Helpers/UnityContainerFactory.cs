using Unity;

namespace Framework.Helpers
{
    public static class UnityContainerFactory
    {
        private static readonly UnityContainer container = new UnityContainer();

        public static UnityContainer GetContainer() { return container; }
    }
}
