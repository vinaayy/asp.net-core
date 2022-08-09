using System;

namespace MyBooksApp.Data.ViewModels
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool isRead { get; set; }
        public DateTime? dateRead { get; set; }
        public int? Rate { get; set; }
        public string CoverURL { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
    }
}
