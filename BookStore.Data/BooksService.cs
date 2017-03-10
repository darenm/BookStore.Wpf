using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Services
{
    public class BooksService
    {
        private Dictionary<int, Book> _books;

        public BooksService()
        {
            _books = new Dictionary<int, Book>();
        }

        public static BooksService CreatePopulated()
        {
            var booksService = new BooksService()
            {
                _books = new Dictionary<int, Book>
                {
                    {1, new Book{ Id=1, Category="SciFi", Title="I, Robot"} },
                    {2, new Book{ Id=2, Category="Fantasy", Title="Lord of the Rings, The"} },
                    {3, new Book{ Id=3, Category="Thriller", Title="Bourne Identity, The"} },
                    {4, new Book{ Id=4, Category="Non-Fiction", Title="Doomsday Book, The"} },
                }
            };
            return booksService;
        }

        public Book[] GetAll()
        {
            return _books.Values.ToArray();
        }

        public Book GetById(int id)
        {
            if (_books.ContainsKey(id))
            {
                return _books[id];
            }

            throw new KeyNotFoundException($"{id} not found");
        }

        public int AddBook(Book book)
        {
            if (_books.ContainsValue(book))
            {
                throw new ArgumentException($"Id: {book.Id}, Title: {book.Title} already exists ");
            }

            var newId = _books.Any() ? _books.Keys.Max() + 1 : 1;
            book.Id = newId;
            _books.Add(newId, book);
            return newId;
        }

        public void DeleteBook(Book book)
        {
            _books.Remove(book.Id);
        }

        public void DeleteBookById(int id)
        {
            _books.Remove(id);
        }

        public Book[] TitleContains(string searchString)
        {
            return _books.Values.Where(b => b.Title.Contains(searchString)).ToArray();
        }
    }
}
