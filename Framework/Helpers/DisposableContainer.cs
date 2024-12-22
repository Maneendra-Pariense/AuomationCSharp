
namespace Framework.Helpers
{
    public class DisposableContainer
    {
        private readonly List<IDisposable> disposables = new List<IDisposable>();

        public void AddDisposableObject(IDisposable disposable) => disposables.Add(disposable);
        public void Dispose()
        {
            foreach (IDisposable disposable in disposables) { disposable.Dispose(); }
        }
    }
}