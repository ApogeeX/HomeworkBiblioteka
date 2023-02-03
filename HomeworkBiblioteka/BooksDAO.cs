using System.Data.SqlClient;


namespace HomeworkBiblioteka
{
    internal class BooksDAO
    {
        string connectionString = "Data Source=EMIL\\SQLEXPRESS;Initial Catalog=BookLibrary;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    
        public List<BookJoined> getAllBooks()
        {
            List<BookJoined> returnThese = new List<BookJoined>();

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand command = new SqlCommand("SELECT BOOKS.ID, BOOKTITLE, SHORTDESC, AUTHOR, GENRE, ISAVAIBLE FROM BOOKS INNER JOIN AUTHORS ON BOOKS.AUTHORID = AUTHORS.ID INNER JOIN GENRES ON BOOKS.GENREID = GENRES.ID", connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    BookJoined a = new BookJoined
                    {
                        ID = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Description = reader.GetString(2),
                        Author = reader.GetString(3),
                        Genre = reader.GetString(4),
                        IsAvaible = reader.GetBoolean(5),
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<BookJoined> searchTitles(string searchTerm)
        {
            List<BookJoined> returnThese = new List<BookJoined>();

            SqlConnection connection = new SqlConnection(connectionString);

            var searchWildPhrase = "%" + searchTerm + "%";

            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT BOOKS.ID, BOOKTITLE as TITLE, SHORTDESC as DESCRIPTION, AUTHOR, GENRE, ISAVAIBLE FROM BOOKS INNER JOIN AUTHORS ON BOOKS.AUTHORID = AUTHORS.ID INNER JOIN GENRES ON BOOKS.GENREID = GENRES.ID WHERE BOOKTITLE LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    BookJoined a = new BookJoined
                    {
                        ID = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        Description = reader.GetString(2),
                        Author = reader.GetString(3),
                        Genre = reader.GetString(4),
                        IsAvaible = reader.GetBoolean(5),
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }

        internal int addAuthor(Author author)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO AUTHORS (AUTHOR) VALUES (@author)", connection);

            command.Parameters.AddWithValue("@author", author.AuthorName);

            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
        }

        internal int addGenre(Genre genre)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO GENRES (GENRE) VALUES (@genre)", connection);

            command.Parameters.AddWithValue("@genre", genre.GenreName);

            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
        }

        internal int addOneBook(Book book)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO BOOKS (BOOKTITLE, SHORTDESC, AUTHORID, GENREID, ISAVAIBLE) VALUES (@booktitle, @shortdesc, @authorid, @genreid, 1)", connection);

            command.Parameters.AddWithValue("@booktitle", book.BookTitle);
            command.Parameters.AddWithValue("@shortdesc", book.ShortDesc);
            command.Parameters.AddWithValue("@authorid", book.AuthorID);
            command.Parameters.AddWithValue("@genreid", book.GenreID);

            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
        }

        internal int changeIsAvaible(int bookID)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE BOOKS SET ISAVAIBLE = ISAVAIBLE ^ 1 WHERE ID = @bookID", connection);

            command.Parameters.AddWithValue("@bookID", bookID);


            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
        }

        internal int deleteBook(int bookID)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM BOOKS WHERE ID = @bookid", connection);

            command.Parameters.AddWithValue("@bookid", bookID);

            int result = command.ExecuteNonQuery();

            connection.Close();

            return result;

        }
    }
}
