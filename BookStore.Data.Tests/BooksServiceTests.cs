//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using BookStore.Services;
//using System.Collections.Generic;
//using BookStore.Models.Tests;
//using System.Linq;

//namespace BookStore.Data.Tests
//{
//    [TestClass]
//    public class BooksServiceTests
//    {
//        [TestMethod]
//        public void GetById()
//        {
//            var svc = new BooksService();
//            var book = BookTests.CreateBook();
//            svc.AddBook(book);
//            Assert.IsNotNull(svc.GetById(1));
//        }

//        [TestMethod]
//        public void GetAll()
//        {
//            var svc = new BooksService();
//            var book = BookTests.CreateBook();
//            svc.AddBook(book);
//            Assert.IsTrue(svc.GetAll().Length == 1);
//        }

//        [TestMethod]
//        public void CreatePopulatedTest()
//        {
//            var svc = BooksService.CreatePopulated();
//            var book = BookTests.CreateBook();
//            Assert.IsTrue(svc.GetAll().Length == 4);
//        }

//        [TestMethod, ExpectedException(typeof(KeyNotFoundException))]
//        public void GetById_Invalid_Id_Throws()
//        {
//            var svc = new BooksService();
//            svc.GetById(-1);
//        }

//        [TestMethod]
//        public void AddBook()
//        {
//            var svc = new BooksService();
//            var book = BookTests.CreateBook();
//            var id1 = svc.AddBook(book);
//            Assert.IsNotNull(svc.GetById(id1));
//            var book2 = BookTests.CreateBook(1);
//            var id2 = svc.AddBook(book2);
//            Assert.IsTrue(id2 == (id1 + 1));

//        }

//        [TestMethod, ExpectedException(typeof(ArgumentException))]
//        public void AddBook_No_Duplicate_Should_Throw()
//        {
//            var svc = new BooksService();
//            var book0 = BookTests.CreateBook();
//            var book1 = BookTests.CreateBook();
//            svc.AddBook(book0);
//            svc.AddBook(book1);
//        }

//        [TestMethod, ExpectedException(typeof(ArgumentException))]
//        public void AddBook_No_Duplicate_Title_Category_Should_Throw()
//        {
//            var svc = new BooksService();
//            var book0 = BookTests.CreateBook();
//            var book1 = BookTests.CreateBook(1);
//            book1.Title = book0.Title;
//            book1.Category = book0.Category;
//            svc.AddBook(book0);
//            svc.AddBook(book1);
//        }

//        [TestMethod, ExpectedException(typeof(ArgumentException))]
//        public void AddBook_Add_Duplicate_Throws()
//        {
//            var svc = new BooksService();
//            var book = BookTests.CreateBook();
//            var id1 = svc.AddBook(book);
//            var id2 = svc.AddBook(book);
//        }

//        [TestMethod, ExpectedException(typeof(KeyNotFoundException))]
//        public void DeleteBookTest()
//        {
//            var svc = new BooksService();
//            var book = BookTests.CreateBook();
//            var id = svc.AddBook(book);
//            svc.DeleteBook(book);
//            var book2 = svc.GetById(id);
//        }

//        [TestMethod, ExpectedException(typeof(KeyNotFoundException))]
//        public void DeleteBookByIdTest()
//        {
//            var svc = new BooksService();
//            var book = BookTests.CreateBook();
//            var id = svc.AddBook(book);
//            svc.DeleteBookById(id);
//            var book2 = svc.GetById(id);
//        }

//        [TestMethod]
//        public void TitleContains()
//        {
//            var svc = new BooksService();
//            var searchString = "Search";
//            Enumerable.Range(1, 10)
//                .Select(i => BookTests.CreateBook(i))
//                .Select(b =>
//                {
//                    b.Title += $"Search{b.Id}";
//                    return svc.AddBook(b);
//                }).ToArray();
//            Assert.IsTrue(svc.TitleContains(searchString).Length == 10);
//            Assert.IsTrue(svc.TitleContains(searchString + "1").Length == 2);
//        }

//    }
//}
