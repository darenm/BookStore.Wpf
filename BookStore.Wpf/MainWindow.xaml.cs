using BookStore.Business;
using BookStore.Services;
using System.Windows;

namespace BookStore.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StoreLogic _storeLogic;
        private BooksService _booksService;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            _storeLogic = StoreLogic.Instance;
            _booksService = new BooksService();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            BookList.ItemsSource = _storeLogic.GetInventory();
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {
            Models.Book book = new Models.Book();
            book.Title = BookTitle.Text;
            _booksService.AddBook(book);
            BookTitle.Text = string.Empty;
            BookList.ItemsSource = _storeLogic.GetInventory();
        }
    }
}
