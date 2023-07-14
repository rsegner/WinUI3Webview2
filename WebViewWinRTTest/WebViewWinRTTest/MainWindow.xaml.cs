using Microsoft.UI.Xaml;
using Services;
using System;
using System.Threading.Tasks;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WebViewWinRTTest
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            _ = this.InitWebView();
        }

        public async Task InitWebView()
        {
            await this.webview.EnsureCoreWebView2Async();

            this.webview.Source = new Uri("https://google.com");

            var dispatchAdapter = new WinRTAdapter.DispatchAdapter();

            var myService = new MyService();
            
            webview.CoreWebView2.AddHostObjectToScript("Services", dispatchAdapter.WrapObject(myService, dispatchAdapter));
        }
    }
}
