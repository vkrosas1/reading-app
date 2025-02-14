using ReadingTracking.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingTracking.Objects
{
    public class Book
    {
        private string title;
        private Status status;
        private BookFormat bookformat;
        private Ownership ownership;

        public Book(string title, Status status, BookFormat bookformat, Ownership ownership)
        {
            this.title = title;
            this.status = status;
            this.bookformat = bookformat;
            this.ownership = ownership;
        }
    }
}
