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
            SqlCommand command = new SqlCommand("SELECT BOOKS.ID, BOOKTITLE, SHORTDESC, AUTHOR, GENRE, ISAVAIBLE, COPIES FROM BOOKS INNER JOIN AUTHORS ON BOOKS.AUTHORID = AUTHORS.ID INNER JOIN GENRES ON BOOKS.GENREID = GENRES.ID", connection);

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
                        Copies = reader.GetInt32(6),
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }

        public List<Author> getAuthors()
        {
            List<Author> returnAuthors = new List<Author>();

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand command = new SqlCommand("SELECT ID, AUTHOR FROM AUTHORS", connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Author a = new Author
                    {
                        ID = reader.GetInt32(0),
                        AuthorName = reader.GetString(1),
                    };
                    returnAuthors.Add(a);
                }
            }
            connection.Close();

            return returnAuthors;
        }

        public List<Genre> getGenres()
        {
            List<Genre> returnGenres = new List<Genre>();

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand command = new SqlCommand("SELECT ID, GENRE FROM GENRES", connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Genre a = new Genre
                    {
                        ID = reader.GetInt32(0),
                        GenreName = reader.GetString(1),
                    };
                    returnGenres.Add(a);
                }
            }
            connection.Close();

            return returnGenres;
        }

        public List<BookJoined> searchTitles(string searchTerm)
        {
            List<BookJoined> returnThese = new List<BookJoined>();

            SqlConnection connection = new SqlConnection(connectionString);

            var searchWildPhrase = "%" + searchTerm + "%";

            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT BOOKS.ID, BOOKTITLE as TITLE, SHORTDESC as DESCRIPTION, AUTHOR, GENRE, ISAVAIBLE, COPIES FROM BOOKS INNER JOIN AUTHORS ON BOOKS.AUTHORID = AUTHORS.ID INNER JOIN GENRES ON BOOKS.GENREID = GENRES.ID WHERE BOOKTITLE LIKE @search";
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
                        Copies = reader.GetInt32(6),
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
            SqlCommand command = new SqlCommand("INSERT INTO BOOKS (BOOKTITLE, SHORTDESC, AUTHORID, GENREID, ISAVAIBLE, COPIES) VALUES (@booktitle, @shortdesc, @authorid, @genreid, 1, @copies)", connection);

            command.Parameters.AddWithValue("@booktitle", book.BookTitle);
            command.Parameters.AddWithValue("@shortdesc", book.ShortDesc);
            command.Parameters.AddWithValue("@authorid", book.AuthorID);
            command.Parameters.AddWithValue("@genreid", book.GenreID);
            command.Parameters.AddWithValue("@copies", book.Copies);

            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
        }

        internal int borrowBook(int bookID, int copies)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            int newRows;

            if (copies == 1)
            {
                SqlCommand command = new SqlCommand("UPDATE BOOKS SET ISAVAIBLE = ISAVAIBLE ^ 1, COPIES = 0 WHERE ID = @bookID", connection);
                command.Parameters.AddWithValue("@bookID", bookID);
                newRows = command.ExecuteNonQuery();
            }
            else
            {
                --copies;
                SqlCommand command = new SqlCommand("UPDATE BOOKS SET COPIES = @copies WHERE ID = @bookID", connection);
                command.Parameters.AddWithValue("@bookID", bookID);
                command.Parameters.AddWithValue("@copies", copies);
                newRows = command.ExecuteNonQuery();
            }

            connection.Close();

            return newRows;
        }

        internal int returnBook(int bookID, int copies)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            int newRows;

            if (copies == 0)
            {
                SqlCommand command = new SqlCommand("UPDATE BOOKS SET ISAVAIBLE = ISAVAIBLE ^ 1, COPIES = 1 WHERE ID = @bookID", connection);
                command.Parameters.AddWithValue("@bookID", bookID);
                newRows = command.ExecuteNonQuery();
            }
            else
            {
                ++copies;
                SqlCommand command = new SqlCommand("UPDATE BOOKS SET COPIES = @copies WHERE ID = @bookID", connection);
                command.Parameters.AddWithValue("@bookID", bookID);
                command.Parameters.AddWithValue("@copies", copies);
                newRows = command.ExecuteNonQuery();
            }

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
