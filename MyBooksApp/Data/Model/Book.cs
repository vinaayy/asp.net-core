using System;

namespace MyBooksApp.Data.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool isRead { get; set; }
        public DateTime? dateTime { get; set; }
        public int? Rate { get; set; }
        public string CoverURL { get; set; }
        public DateTime DateAdded { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public Publisher Publisher { get; set; }

        //Navigation
        public int PublisherId { get; set; }

    }
}
