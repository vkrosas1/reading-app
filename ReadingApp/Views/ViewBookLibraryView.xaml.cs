using Microsoft.Extensions.DependencyInjection;
using ReadingApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ReadingApp.Views
{
    /// <summary>
    /// Interaction logic for ViewBookLibraryView.xaml
    /// </summary>
    public partial class ViewBookLibraryView : Window
    {
        public ViewBookLibraryView()
        {
            InitializeComponent();
            this.DataContext = App.Services.GetService<ViewBookViewModel>();
        }
    }
}
