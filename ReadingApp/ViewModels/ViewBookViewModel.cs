using ReadingApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingApp.ViewModels
{
    public class ViewBookViewModel
    {
        private Book book;

        public ViewBookViewModel(Book book)
        {
            this.book = book;
        }
    }
}
