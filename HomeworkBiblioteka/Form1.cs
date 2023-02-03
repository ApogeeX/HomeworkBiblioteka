using System.Data;
using System.Data.SqlClient;

namespace HomeworkBiblioteka
{
    public partial class Form1 : Form
    {
        BindingSource bookBindingSource = new BindingSource();
        BindingSource authorBindingSource = new BindingSource();
        BindingSource genreBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            BooksDAO booksDAO = new BooksDAO();

            bookBindingSource.DataSource = booksDAO.getAllBooks();
            dataGridView1.DataSource = bookBindingSource;

            authorBindingSource.DataSource = booksDAO.getAuthors();
            authorsDataGridView.DataSource = authorBindingSource;

            genreBindingSource.DataSource = booksDAO.getGenres();
            genresDataGridView.DataSource = genreBindingSource;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            BooksDAO booksDAO = new BooksDAO();
            
            bookBindingSource.DataSource = booksDAO.getAllBooks();

            dataGridView1.DataSource = bookBindingSource;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            BooksDAO booksDAO = new BooksDAO();

            bookBindingSource.DataSource = booksDAO.searchTitles(searchBox.Text);

            dataGridView1.DataSource = bookBindingSource;
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                BookTitle = bookTitleBox.Text,
                ShortDesc = shortDescBox.Text,
                AuthorID = int.Parse(authorComboBox.SelectedValue.ToString()),
                GenreID = int.Parse(genreComboBox.SelectedValue.ToString()),
                Copies = int.Parse(copiesTextBox.Text)
            };

            BooksDAO booksDAO = new BooksDAO();
            int result = booksDAO.addOneBook(book);
            MessageBox.Show("Book added");
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            Author author = new Author
            {
                AuthorName = addAuthorBox.Text,
            };

            BooksDAO booksDAO = new BooksDAO();
            int result = booksDAO.addAuthor(author);
            MessageBox.Show("Author added");

            authorBindingSource.DataSource = booksDAO.getAuthors();
            authorsDataGridView.DataSource = authorBindingSource;
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            Genre genre = new Genre
            {
                GenreName = addGenreBox.Text,
            };

            BooksDAO booksDAO = new BooksDAO();
            int result = booksDAO.addGenre(genre);
            MessageBox.Show("Genre added");

            genreBindingSource.DataSource = booksDAO.getGenres();
            genresDataGridView.DataSource = genreBindingSource;
        }

        private void deleteSelectedBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            int bookID = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;
            

            BooksDAO booksDAO = new BooksDAO();
            int result = booksDAO.deleteBook(bookID);

            bookBindingSource.DataSource = booksDAO.getAllBooks();

            dataGridView1.DataSource = bookBindingSource;

            MessageBox.Show("Book ID " + bookID + " deleted!");

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=EMIL\\SQLEXPRESS;Initial Catalog=BookLibrary;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("SELECT ID, AUTHOR FROM AUTHORS", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = command;
            DataTable table1 = new DataTable();
            sqlDataAdapter.Fill(table1);

            DataRow itemRow = table1.NewRow();
            itemRow[1] = "Select Author";
            table1.Rows.InsertAt(itemRow, 0);

            authorComboBox.DataSource = table1;
            authorComboBox.DisplayMember = "Author";
            authorComboBox.ValueMember = "id";

            SqlCommand command2 = new SqlCommand("SELECT ID, GENRE FROM GENRES", connection);
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter();
            sqlDataAdapter2.SelectCommand = command2;
            DataTable table2 = new DataTable();
            sqlDataAdapter2.Fill(table2);

            DataRow itemRow2 = table2.NewRow();
            itemRow2[1] = "Select Genre";
            table2.Rows.InsertAt(itemRow2, 0);

            genreComboBox.DataSource = table2;
            genreComboBox.DisplayMember = "Genre";
            genreComboBox.ValueMember = "id";

            BooksDAO booksDAO = new BooksDAO();

            bookBindingSource.DataSource = booksDAO.getAllBooks();

            dataGridView1.DataSource = bookBindingSource;
        }

        private void borrowCopyButton_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            int bookID = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;
            int copies = (int)dataGridView1.Rows[rowClicked].Cells[6].Value;

            BooksDAO booksDAO = new BooksDAO();
            int result = booksDAO.borrowBook(bookID, copies);

            bookBindingSource.DataSource = booksDAO.getAllBooks();

            dataGridView1.DataSource = bookBindingSource;

            MessageBox.Show("Book ID " + bookID + " borrowed!");
        }

        private void returnCopyButton_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            int bookID = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;
            int copies = (int)dataGridView1.Rows[rowClicked].Cells[6].Value;

            BooksDAO booksDAO = new BooksDAO();
            int result = booksDAO.returnBook(bookID, copies);

            bookBindingSource.DataSource = booksDAO.getAllBooks();

            dataGridView1.DataSource = bookBindingSource;

            MessageBox.Show("Book ID " + bookID + " returned!");
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value) == 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleVioletRed;
            }
            else if (Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value) < 4)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Beige;
            }
        }
    }
}