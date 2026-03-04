using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniKindle501
{
    public class Model
    {
        public Library library { get; set; }
        public Book currBook { get; set; }

        public Model(Library library, Book currBook)
        {
            this.library = library;
            this.currBook = currBook;
        }
    }

}
