using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment5
{
    class Books
    {
        public string BookName;
        public string AuthorName;
        public Books(string name, string author)
        {
            BookName = name;
            AuthorName = author;
        }
        public void Display()
        {
            Console.WriteLine("Book: " + BookName + " | Author: " + AuthorName);
        }
    }
    class BookShelf
    {
        Books[] books = new Books[5];
        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
    }
    internal class Indexer
    {
        static void Main(string[] args)
        {
            BookShelf shelf = new BookShelf();
            shelf[0] = new Books("C# Basics", "Author A");
            shelf[1] = new Books("OOP Concepts", "Author B");
            shelf[2] = new Books("Data Structures", "Author C");
            shelf[3] = new Books("Algorithms", "Author D");
            shelf[4] = new Books("DotNet Guide", "Author E");
            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }
            Console.ReadLine();
        }
    }
}