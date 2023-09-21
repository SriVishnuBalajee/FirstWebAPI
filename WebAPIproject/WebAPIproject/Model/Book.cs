using System.Runtime.InteropServices;

namespace WebAPIproject.Model
{
    public class Book
    {
        public int BookID { get; set; }

        public string Title { get; set; }

        public int Cost { get; set; }

        public string AuthorName { get; set; }
    }
}
