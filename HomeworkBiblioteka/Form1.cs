namespace HomeworkBiblioteka
{
    public partial class Form1 : Form
    {
        BindingSource bookBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            BooksDAO booksDAO = new BooksDAO();
            Book a1 = new Book 
            { 
                ID = 1,
                BookTitle = "Book1",
                ShortDesc = "Krótki opis",
                GenreID = 1,
                AuthorID = 2,
                IsAvaible = true
            };

            Book a2 = new Book
            {
                ID = 2,
                BookTitle = "Book2",
                ShortDesc = "Krótki opis2",
                GenreID = 2,
                AuthorID = 1,
                IsAvaible = true
            };

            booksDAO.books.Add(a1);
            booksDAO.books.Add(a2);

            bookBindingSource.DataSource = booksDAO.books;

            dataGridView1.DataSource = bookBindingSource;

        }
    }
}