using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace P06_BookLibraryModification
{
    class P06_BookLibraryModification
    {
        static void Main(string[] args)
        {
            var booksCount = int.Parse(Console.ReadLine());
            Library libraryOfBooks = GetLibraryOfBooks(booksCount);
            var dateFormat = "d.M.yyyy";
            var dateString = Console.ReadLine();
            var targetDate = DateTime.ParseExact(dateString , dateFormat, CultureInfo.InvariantCulture);

            var booksReleasedAfterDate = GetbooksReleasedAfterDate(libraryOfBooks, targetDate);

            PrintTotalBooksPriveByAuthor(booksReleasedAfterDate);
        }

        static void PrintTotalBooksPriveByAuthor(Dictionary<string, DateTime> booksReleasedAfterDate)
        {
            foreach (var date in booksReleasedAfterDate.OrderBy(d => d.Value).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{date.Key} -> {date.Value:dd.MM.yyyy}");
            }
        }

        private static Dictionary<string, DateTime> GetbooksReleasedAfterDate(Library libraryOfBooks, DateTime targetDate)
        {
            var totalBooksPriveByAuthor = new Dictionary<string, DateTime>();
            foreach (var book in libraryOfBooks.Books)
            {
                if (targetDate < book.ReleaseDate)
                {
                    
                        totalBooksPriveByAuthor[book.Title] = book.ReleaseDate;
                    
                    
                }
            }

            return totalBooksPriveByAuthor;
        }

        static Library GetLibraryOfBooks(int booksCount)
        {
            Library libratyOfBooks = new Library();
            var booksList = new List<Book>();
            for (int i = 0; i < booksCount; i++)
            {
                libratyOfBooks.Books.Add(GetBook());
            }

            return libratyOfBooks;
        }

        private static Book GetBook()
        {
            var dateFormat = "d.M.yyyy";
            var bookInfo = Console.ReadLine()
                .Split(' ')
                .ToArray();
            return new Book
            {
                Title = bookInfo.First(),
                //Author = bookInfo.Skip(1).First(),
                //Publisher = bookInfo.Skip(2).First(),
                ReleaseDate = DateTime.ParseExact(
                    bookInfo.Skip(3).First(),
                    dateFormat,
                    CultureInfo.InvariantCulture),
                //Isbn = bookInfo.Skip(4).First(),
                //Price = double.Parse(bookInfo.Skip(5).First())
            };
        }
    }

    class Library
    {
        //public string Name { get; set; } // but why??
        public List<Book> Books = new List<Book>();
    }

    class Book
    {
        public string Title { get; set; }
        //public string Author { get; set; }
        //public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        //public string Isbn { get; set; }
        //public double Price { get; set; }
    }
}
