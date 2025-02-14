using ReadingTracking.Constants;
using ReadingTracking.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTracking.ViewModels
{

    public class AddBookViewModel : INotifyPropertyChanged
    {
        private Book book;
        private ObservableCollection<Book> books;
        public event PropertyChangedEventHandler PropertyChanged;


        // creating getters and setters 
        private Book _newBook;
        public Book NewBook
        {
            get { return _newBook; }
            set {
                if (_newBook != value) {
                    _newBook = value;
                    OnPropertyChanged(nameof(NewBook));
                }
            }
        }


        public AddBookViewModel(Book book) 
        {
            this.book = book;
        }

        private void onBookAdd(Book book)
        {
            if (validateBook(book)) {
                books.Add(book);
            }

        }

        private bool validateBook(Book book)
        {
            // check if the book hasn't been added yet
            if (books.Contains(book))
            {
                return false;
            }
            else {
                return book != null;
            }

        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
