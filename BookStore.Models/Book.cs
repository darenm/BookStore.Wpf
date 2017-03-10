namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }


        //public override bool Equals(object obj)
        //{
        //    if (!(obj is Book))
        //    {
        //        return false;
        //    }

        //    var book = obj as Book;

        //    if (book.Title == this.Title && book.Category == this.Category)
        //    {
        //        return true;
        //    }

        //    return false;
        //}
    }
}