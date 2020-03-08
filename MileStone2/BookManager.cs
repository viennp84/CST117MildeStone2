using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone2
{


    class BookManager
    {
        List<Book> bookList;
       
        public BookManager()
        {
            bookList = new List<Book>();
        }
        public void addBook(Book book)
        {

            bookList.Add(book);
        }
        public void removeBook(int index)
        {
             bookList.RemoveAt(index);
        }

        public Book searchBook(string bookTitle)
        {
            Book book = null;
           
            foreach (Book b in bookList)
            {
                if (b.bookTitle == bookTitle)
                {
                    book = b;
                }
            }
            return book;
        }

        public void updateBook(int bookId, string bookTitle, string isbn, string authorName, string publisher, int edition, string type, string category)
        {
            foreach(Book b in bookList)
            {
                if (b.bookId == bookId)
                {
                    b.bookTitle = bookTitle;
                    b.isbn = isbn;
                    b.authorName = authorName;
                    b.publisher = publisher;
                    b.edition = edition;
                    b.type = type;
                    b.category = category;
                }
            }
        }

        public List<Book> getBookList()
        {
            return bookList;
        }
    }
}
