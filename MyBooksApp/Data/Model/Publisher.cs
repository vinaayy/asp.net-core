using System.Collections.Generic;

namespace MyBooksApp.Data.Model
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation
        public List<Book> Books { get; set; }
    }
}
