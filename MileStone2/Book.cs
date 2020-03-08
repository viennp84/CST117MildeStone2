using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone2
{
    class Book
    {
        public int bookId
        { get; set; }
        public string bookTitle
        { get; set; }
        public string isbn
        { get; set; }
        public string authorName
        { get; set; }
        public string publisher
        { get; set; }
        public int edition
        { get; set; }
        public string type
        { get; set; }
        public string category
        { get; set; }

        public Book() { }
        public Book(int bookId, string bookTitle, string isbn, string authorName, string publisher, int edition, string type, string category)
        {
            this.bookId = bookId;
            this.bookTitle = bookTitle;
            this.isbn = isbn;
            this.authorName = authorName;
            this.publisher = publisher;
            this.edition = edition;
            this.type = type;
            this.category = category;
        }
    }
}
