using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class BookClass
    {
        //encapsulation - private members
        private string m_book;
        private string m_newBook;

        //the default constructor  
        public BookClass()
        {
            m_book = " ";
            m_newBook = " ";
        }

        //properties
        public string BOOK
        {
            //get() function
            get { return m_book; }
            //set() function
            set { m_book = value; }
        }

        public string NEWBook
        {
            get { return m_newBook; }
            set { m_newBook = value; }
        }
    }
}
