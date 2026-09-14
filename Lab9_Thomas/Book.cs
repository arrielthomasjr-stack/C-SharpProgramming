using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class Book
    {
        public string Title { get; set; }
        public Author BookAuthor { get; set; }
        public decimal Price { get; set; }

        public override string ToString() =>
            $"{Title} by {BookAuthor} - {Price:C}";
    }
}

