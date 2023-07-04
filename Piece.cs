using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Piece : IDisposable
    {
        private string title;
        private string author;
        private string genre;
        private int year;
        private bool disposed = false;

        public Piece(string title, string author, string genre, int year)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.year = year;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public void DisplayInformation()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Genre: " + genre);
            Console.WriteLine("Year: " + year);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    
                    Console.WriteLine("Очищення керованих ресурсiв.");
                }
                Console.WriteLine("Очищення некерованих ресурсiв.");
                disposed = true;
            }
        }
        ~Piece()
        {
            Dispose(false);
        }
    }
}
