using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileStone2
{
    public partial class BookInventory : Form
    {

        BookManager bookManager = new BookManager();
        int count = 0;
       
        public BookInventory()
        {
            InitializeComponent();
            bookManager.addBook(new Book(0,"Essential Mathematics","Jack Bynum","123134234","GCU",3,"Book","Math1"));
            bookManager.addBook(new Book(1, "Psychology", "Jack Bynum", "167546234", "GCU", 2, "Ebook", "Math2"));
            bookManager.addBook(new Book(2, "Chemistry", "Jack Bynum", "134234", "GCU", 5, "Book", "Math3"));
            bookManager.addBook(new Book(3, "Java", "Jack Bynum", "125664234", "GCU", 1, "Ebook", "Math4"));
            bookManager.addBook(new Book(4, "Calculus", "Vin ", "12236764", "GCU", 8, "Book", "Math5"));
            bookManager.addBook(new Book(5, "C#", "JaJa Bynum", "12898734", "GCU", 7, "Ebook", "Math6"));
            dataGridView1.DataSource = bookManager.getBookList();
            
            
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (txtBookTitle.Text != "" && txtISBN.Text!="" && txtAuthorName.Text!="" && txtPublisher.Text!="") 
            {
                count = Int32.Parse(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value.ToString());
                int bookId = ++count;
                string bookTitle = txtBookTitle.Text;
                string isbn = txtISBN.Text;
                string authorName = txtAuthorName.Text;
                string publisher = txtPublisher.Text;
                int edition = Int32.Parse(cbEdition.Text);
                string type = cbType.Text;
                string category = cbCategory.Text;
                Book book = new Book(bookId, bookTitle, isbn, authorName, publisher, edition, type, category);
                bookManager.addBook(book);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bookManager.getBookList();
            }
            else
            {
                MessageBox.Show("Book information must to be entered!");
            }
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bookManager.removeBook(dataGridView1.CurrentRow.Index);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bookManager.getBookList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine(dataGridView1.CurrentRow.Index);
            
            txtBookTitle.Text = dataGridView1.CurrentRow.Cells["bookTitle"].FormattedValue.ToString();
            txtAuthorName.Text = dataGridView1.CurrentRow.Cells["authorName"].FormattedValue.ToString();
            txtISBN.Text = dataGridView1.CurrentRow.Cells["isbn"].FormattedValue.ToString();
            txtPublisher.Text = dataGridView1.CurrentRow.Cells["publisher"].FormattedValue.ToString();
            cbEdition.Text = dataGridView1.CurrentRow.Cells["edition"].FormattedValue.ToString();
            cbType.Text = dataGridView1.CurrentRow.Cells["type"].FormattedValue.ToString();
            cbCategory.Text = dataGridView1.CurrentRow.Cells["category"].FormattedValue.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Book> listB = new List<Book>();
           Book b = bookManager.searchBook(txtBookTitle.Text);
            if (b!=null)
            {
                listB.Add(b);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listB;
            }
            else
            {
                dataGridView1.DataSource = null;
                Console.WriteLine("No data found!");
            }

        }

        private void btnLoadAllBooks_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bookManager.getBookList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int bookId = Int32.Parse(dataGridView1.CurrentRow.Cells["bookId"].FormattedValue.ToString());
            string bookTitle = txtBookTitle.Text;
            string isbn = txtISBN.Text;
            string authorName = txtAuthorName.Text;
            string publisher = txtPublisher.Text;
            int edition = Int32.Parse(cbEdition.Text);
            string type = cbType.Text;
            string category = cbCategory.Text;

            bookManager.updateBook(bookId,bookTitle,isbn,authorName,publisher,edition,type,category);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bookManager.getBookList();
        }
    }
}
