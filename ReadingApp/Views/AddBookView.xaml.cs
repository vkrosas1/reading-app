using Microsoft.Extensions.DependencyInjection;
using ReadingApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Application = System.Windows.Application;

namespace ReadingApp.Views
{
    /// <summary>
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBookView : System.Windows.Controls.UserControl
    {
        public AddBookView()
        {
            InitializeComponent();
            //DataContext = new AddBookViewModel(((App)Application.Current).Services.GetService<BookService>());

        }
    }
}
