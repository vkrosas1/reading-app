using ReadingApp.Constants;
using ReadingApp.Objects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Reflection.Metadata.BlobBuilder;

namespace ReadingApp.ViewModels
{
    public class AddBookViewModel : INotifyPropertyChanged
    {
        private BooksRepository _booksRepository;

        public event PropertyChangedEventHandler? PropertyChanged;

        private Book _newBook;

        public Book NewBook
        {
            get => _newBook;
            set
            {
                _newBook = value;
                OnPropertyChanged(nameof(NewBook));
            }
        }

        public ICommand AddBookCommand { get; }
        public ObservableCollection<Status> BookStatuses { get; }
        public ObservableCollection<BookFormat> BookFormats { get; }
        public ObservableCollection<Ownership> BookOwnerships { get; }

        public AddBookViewModel(BooksRepository booksRepository)
        {
            _booksRepository = booksRepository;

            _newBook = new Book(); 

            BookStatuses = new ObservableCollection<Status>(
                Enum.GetValues(typeof(Status)).Cast<Status>()
                );
            BookFormats = new ObservableCollection<BookFormat>(
                Enum.GetValues(typeof(BookFormat)).Cast<BookFormat>()
                );
            BookOwnerships = new ObservableCollection<Ownership>(
                Enum.GetValues(typeof(Ownership)).Cast<Ownership>()
                );
            
            AddBookCommand = new RelayCommand(AddBook);
        }

        private void AddBook(object parameter)
        {
            // Add your logic to save the book
            if (validateBook(_newBook))
            {
            Console.WriteLine($"Book Added: {_newBook.Title}");
                _booksRepository.Books.Add(new Book
                {
                    Title = _newBook.Title,
                    Status = _newBook.Status,
                    BookFormat = _newBook.BookFormat,
                    Ownership = _newBook.Ownership,
                });
            }
            _newBook = new Book(); // Reset form after adding
            OnPropertyChanged(nameof(NewBook));

        }

        private bool validateBook(Book book)
        {
            // check if the book hasn't been added yet
            return book != null && !_booksRepository.Books.Contains(book);

        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
