//using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace BookStore.Models.Tests
//{
//    [TestClass]
//    public class BookTests
//    {
//        [TestMethod]
//        public void Equals_Book_Same()
//        {
//            var book = CreateBook();
//            Assert.AreEqual(book, book);
//        }

//        [TestMethod]
//        public void Equals_Book_Not_Same()
//        {
//            var book0 = CreateBook();
//            var book1 = CreateBook(1);
//            Assert.AreNotEqual(book0, book1);
//        }

//        [TestMethod]
//        public void Equals_Object_Not_Book()
//        {
//            var book0 = CreateBook();
//            Assert.AreNotEqual(book0, "Hello");
//        }

//        [TestMethod]
//        public void Equals_ID_Match_Title_Not()
//        {
//            var book0 = CreateBook();
//            var book1 = CreateBook(1);
//            book1.Id = book0.Id;

//            Assert.AreNotEqual(book0, book1);
//        }

//        public static Book CreateBook(int id = 0)
//        {
//            return new Book { Id = id, Title = $"Title:{id}", Category = $"Category:{id}" };
//        }
//    }
//}
