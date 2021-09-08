using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {

        //fields

        //props
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        //ctors
        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public Book()
        {

        }

        //methods
        public override string ToString()
        {
            //return base.ToString();
            return $"Title: {Title}\n" +
                $"Author: {Author}\n" +
                $"Number of Pages: {NumberOfPages}\n";
        }

    }//end class
}//end namespace
