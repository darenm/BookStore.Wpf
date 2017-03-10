using BookStore.Models;
using BookStore.Services;

namespace BookStore.Business
{
    public class StoreLogic
    {
        private static StoreLogic _instance;
        private BooksService _booksService;

        public static StoreLogic Instance
        {
            get
            {
                return _instance == null ? _instance = new StoreLogic() : _instance;
            }
        }

        private StoreLogic()
        {
            _booksService = BooksService.CreatePopulated();
        }

        public Book[] GetInventory()
        {
            return _booksService.GetAll();
        }

        public Book[] FindTitle(string title)
        {
            return _booksService.TitleContains(title);
        }

        public void InsertTitle(string title)
        {
            _booksService.AddBook(new Book { Title = title, Category = "Undefined" });
        }
    }
}
