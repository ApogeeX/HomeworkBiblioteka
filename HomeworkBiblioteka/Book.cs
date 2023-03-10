namespace HomeworkBiblioteka
{
    internal class Book
    {
        public int ID { get; set; }
        public string BookTitle { get; set; }
        public string ShortDesc { get; set; }
        public int AuthorID { get; set; }
        public int GenreID { get; set; }
        public bool IsAvaible { get; set; }
        public int Copies { get; set; }
    }

    internal class BookJoined
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvaible { get; set; }
        public int Copies { get; set; }
    }

}
