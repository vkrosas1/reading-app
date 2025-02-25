using Microsoft.Extensions.DependencyInjection;
using ReadingApp.ViewModels;
using ReadingApp.Views;
using System.Windows;


namespace ReadingApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; }

        public App()
        {
            this.InitializeComponent();
            ConfigureServices();
        }

       private void ConfigureServices()
        {
            var services = new ServiceCollection();

            // registering the view models 
            services.AddSingleton<AddBookViewModel>();
            services.AddSingleton<ViewBookViewModel>();

            // build the DI container 
            Services = services.BuildServiceProvider();
        }
    }

}
