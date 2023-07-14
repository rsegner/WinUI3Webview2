using System;
using System.Threading.Tasks;
using Types;
using Windows.Foundation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Services
{
    public sealed class MyService
    {
        public IAsyncOperation<MyType> GetMyTypeAsync()  => _getMyType().AsAsyncOperation();

        private async Task<MyType> _getMyType()
        {
            // Simulate some kind of async operation e.g. http call
            await Task.Delay(1);
            var type = new MyType { FirstName = "Foo", LastName = "Bar" };
            return type;
        }

        public IAsyncOperation<MyOtherType> GetMyOtherTypeAsync() => _getMyOtherType().AsAsyncOperation();

        private async Task<MyOtherType> _getMyOtherType()
        {
            // Simulate some kind of async operation e.g. http call
            await Task.Delay(1);
            var type = new MyOtherType { FirstName = "Foo", LastName = "Bar" };
            return type;
        }
    }
}
