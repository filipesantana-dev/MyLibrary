namespace MyLibrary.BLL.Models
{
    public partial class AuthorBook
    {
        //FK e propriedade de navegação para Author
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        //FK e propriedade de navegação para Book
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}