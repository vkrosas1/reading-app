using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadingApp.Constants;
using ReadingApp.Objects;

public class BookService
{
    public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>();
}
