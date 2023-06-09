﻿namespace HIT_Library_Manager_Lib.Models
{
    /// <summary>
    /// Represents a single book
    /// </summary>
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string PublicationYear { get; set; }
        public string Genre { get; set; }
        public string CoverImage { get; set; }
        public string ISBN { get; set; }
        public int IsBorrowed { get; set; }
        public int BookCount { get; set; }

        public BookModel()
        {


        }
        // Constructor for initializing a new Book object by parsing the parameters

        public BookModel(BookModel other)
        {
            this.Id = other.Id;
            this.Title = other.Title;
            this.Author = other.Author;
            this.Genre = other.Genre;
            this.Publisher = other.Publisher;
            this.PublicationYear = other.PublicationYear;
            this.BookCount = other.BookCount;
            this.CoverImage = other.CoverImage;
            this.ISBN = other.ISBN;
        }

        //public BookModel(string title, string author, string publisher, string publicationYear, string coverimage, string genre, string isbn, int bookCount)
        //{

        //    Title = title;
        //    Author = author;
        //    Publisher = publisher;
        //    PublicationYear = publicationYear;
        //    Genre = genre;
        //    CoverImage = coverimage;
        //    ISBN = isbn;
        //    BookCount = bookCount;

        //}
    }

}
