using ReadingApp.Constants;
using ReadingApp.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ReadingApp.ViewModels
{
    public class AddBookViewModel : INotifyPropertyChanged
    {
        private Book _newBook;
        private ObservableCollection<Book> books;

        public Book NewBook
        {
            get => _newBook;
            set
            {
                _newBook = value;
                OnPropertyChanged(nameof(NewBook));
            }
        }

        public System.Windows.Input.ICommand AddBookCommand { get; }

        public AddBookViewModel()
        {
            NewBook = new Book();
            AddBookCommand = new RelayCommand(AddBook);
        }

        private void AddBook(object parameter)
        {
            // Add your logic to save the book
            if (validateBook(parameter))
            {
            Console.WriteLine($"Book Added: {NewBook.Title}");
            NewBook = new Book(); // Reset form after adding

            }
        }

        private bool validateBook(Book book)
        {
            // check if the book hasn't been added yet
            if (books.Contains(book))
            {
                return false;
            }
            else
            {
                return book != null;
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
