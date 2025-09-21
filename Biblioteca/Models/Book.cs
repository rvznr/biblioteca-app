namespace Biblioteca.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Publisher { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string CoverImage { get; set; } = string.Empty;
        public int Rating { get; set; } = 0;           
        public string FavoriteQuote { get; set; } = "";
        public string Notes { get; set; } = "";        

    }
}
