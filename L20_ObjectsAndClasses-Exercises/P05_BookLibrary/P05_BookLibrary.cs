using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace P05_BookLibrary
{
    class P05_BookLibrary
    {
        static void Main(string[] args)
        {
            var booksCount = int.Parse(Console.ReadLine());
            Library libraryOfBooks = GetLibraryOfBooks(booksCount);

            var authorsBooksTotalPrice = GetTotalBooksPriveByAuthor(libraryOfBooks);

            PrintTotalBooksPriveByAuthor(authorsBooksTotalPrice);
        }

        static void PrintTotalBooksPriveByAuthor(Dictionary<string, double> authorsBooksTotalPrice)
        {
            foreach (var author in authorsBooksTotalPrice.OrderByDescending(p => p.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }

        private static Dictionary<string, double> GetTotalBooksPriveByAuthor(Library libraryOfBooks)
        {
            var totalBooksPriveByAuthor = new Dictionary<string, double>();
            foreach (var book in libraryOfBooks.Books)
            {
                if (!totalBooksPriveByAuthor.ContainsKey(book.Author))
                {
                    totalBooksPriveByAuthor[book.Author] = 0;
                }
                totalBooksPriveByAuthor[book.Author] += book.Price;
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
            //var dateFormat = "d.M.yyyy";
            var bookInfo = Console.ReadLine()
                .Split(' ')
                .ToArray();
            return new Book
            {
                //Title = bookInfo.First(),
                Author = bookInfo.Skip(1).First(),
                //Publisher = bookInfo.Skip(2).First(),
                //ReleaseDate = DateTime.ParseExact(
                //    bookInfo.Skip(3).First(),
                //    dateFormat,
                //    CultureInfo.InvariantCulture),
                //Isbn = bookInfo.Skip(4).First(),
                Price = double.Parse(bookInfo.Skip(5).First())
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
        //public string Title { get; set; }
        public string Author { get; set; }
        //public string Publisher { get; set; }
        //public DateTime ReleaseDate { get; set; }
        //public string Isbn { get; set; }
        public double Price { get; set; }
    }
}
