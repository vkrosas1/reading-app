using Microsoft.Extensions.DependencyInjection;
using ReadingApp.ViewModels;
using ReadingApp.Views;


namespace ReadingApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public App()
        {
            this.InitializeComponent();
            /*Services = new ServiceCollection()
                        .AddSingleton<BookService>()
                        .AddSingleton<AddBookViewModel>()
                        .AddSingleton<ViewBookViewModel>()
                        .BuildServiceProvider();*/
        }

        // public IServiceProvider Services { get; }

        /*protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            var window = new MainWindowView();
            window.Activate();
        }*/
    }

}
