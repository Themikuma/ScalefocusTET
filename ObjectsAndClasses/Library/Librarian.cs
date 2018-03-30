using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Librarian
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Librarian(int id, string name)
        {
            this.ID = id;
            this.Name = Name;
        }

        public bool Checkout(long isbn, int months = 1)
        {
            //DO SUPER HARD LOGIC TO FIND BOOK
            Book book = new Book(isbn, "name", "pesho", 2);
            return Checkout(book, months);
        }

        private bool Checkout(Book book, int months)
        {
            if (!book.IsAvailable)
            {
                return false;
            }
            var today = DateTime.Now;
            book.CheckoutDate = today;
            book.DueDate = DateTime.Now.AddMonths(months);
            book.Count--;
            return true;
        }
    }
}
