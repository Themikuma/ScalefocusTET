using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public long ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int ReleaseYear { get; set; }
        public string Publisher { get; set; }
        public bool IsHardcover { get; set; }
        public Genre Genre { get; set; }
        public bool IsAvailable
        {
            get
            {
                if (Count > 0)
                {
                    return true;
                }
                return false;
            }
        }
        public DateTime CheckoutDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Count { get; set; }

        public Book(long isbn, string name, string author, int count = 0)
        {
            this.ISBN = isbn;
            this.Name = name;
            this.Author = author;
            this.Count = count;
        }
    }
}
