using ReadingApp.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.ViewModels
{
    public class ViewBookViewModel
    {
        private Book book;
        private readonly BooksRepository _bookService;

        public ObservableCollection<Book> Books => _bookService.Books;

        public ViewBookViewModel(BooksRepository bookService)
        {
            _bookService = bookService;
        }
    }
}
