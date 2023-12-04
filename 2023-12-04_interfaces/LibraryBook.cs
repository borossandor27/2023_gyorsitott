using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _2023_12_04_interfaces
{
    internal class LibraryBook : IBook
    {
        public string Title;
        public string Author;
        public int PublicationDate;
        private string category;

        public LibraryBook(string title, string author, int publicationDate)
        {
            Title = title;
            Author = author;
            PublicationDate = publicationDate;
        }

        public string Category => category;
         
    
    }
}
