using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class Author
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString() => $"{Name} ({Country})";

    }
}
