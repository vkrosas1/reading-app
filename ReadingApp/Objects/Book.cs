using ReadingApp.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.Objects
{
    public class Book : INotifyPropertyChanged
    {
        private string? _title;
        private Status _status;
        private BookFormat _bookFormat;
        private Ownership _ownership;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public Status Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        public BookFormat BookFormat
        {
            get => _bookFormat;
            set
            {
                _bookFormat = value;
                OnPropertyChanged(nameof(BookFormat));
            }
        }

        public Ownership Ownership
        {
            get => _ownership;
            set
            {
                _ownership = value;
                OnPropertyChanged(nameof(Ownership));
            }
        }


        /*public Book(string title, Status status, BookFormat bookformat, Ownership ownership)
        {
            this.title = title;
            this.status = status;
            this.bookformat = bookformat;
            this.ownership = ownership;
        }*/

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
