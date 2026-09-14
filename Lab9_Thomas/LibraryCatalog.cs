using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class LibraryCatalog
    {
        public Book[] Books { get; set; }

        public void DisplayAll()
        {
            Console.WriteLine("--- Library Catalog ---");
            foreach (Book b in Books)
                Console.WriteLine(b);
        }
    }
}

