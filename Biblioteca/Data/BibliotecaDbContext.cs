using Microsoft.EntityFrameworkCore;
using Biblioteca.Models;

namespace Biblioteca.Data
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "Crime and Punishment",
                    Author = "Fyodor Dostoevsky",
                    Genre = "Classic Novel",
                    Publisher = "Penguin Classics",
                    Summary = "The story of Raskolnikov, a young man tormented by guilt after committing a murder.",
                    CoverImage = string.Empty
                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "1984",
                    Author = "George Orwell",
                    Genre = "Dystopian",
                    Publisher = "Secker & Warburg",
                    Summary = "A chilling portrayal of a totalitarian regime and the dangers of absolute power.",
                    CoverImage = string.Empty
                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "Madonna in a Fur Coat",
                    Author = "Sabahattin Ali",
                    Genre = "Romance",
                    Publisher = "Penguin Modern Classics",
                    Summary = "The unforgettable love story of Raif Efendi and Maria Puder.",
                    CoverImage = string.Empty
                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "Les Misérables",
                    Author = "Victor Hugo",
                    Genre = "Classic Novel",
                    Publisher = "Random House",
                    Summary = "The epic story of Jean Valjean’s struggle for redemption in 19th-century France.",
                    CoverImage = string.Empty
                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "The Little Prince",
                    Author = "Antoine de Saint-Exupéry",
                    Genre = "Children / Philosophy",
                    Publisher = "Reynal & Hitchcock",
                    Summary = "A poetic tale about love, friendship, and the meaning of life.",
                    CoverImage = string.Empty
                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "The Disconnected",
                    Author = "Oğuz Atay",
                    Genre = "Modern Literature",
                    Publisher = "Everest Publishing",
                    Summary = "A cornerstone of modern Turkish literature, exploring alienation and identity.",
                    CoverImage = string.Empty
                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "My Name is Red",
                    Author = "Orhan Pamuk",
                    Genre = "Historical Novel",
                    Publisher = "Knopf",
                    Summary = "A rich tale set in the Ottoman Empire, blending art, religion, and mystery.",
                    CoverImage = string.Empty
                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "Serenade",
                    Author = "Zülfü Livaneli",
                    Genre = "Historical Fiction",
                    Publisher = "Other Press",
                    Summary = "A novel intertwining love, tragedy, and history across generations.",
                    CoverImage = string.Empty
                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "The Seven Husbands of Evelyn Hugo",
                    Author = "Taylor Jenkins Reid",
                    Genre = "Historical Fiction",
                    Publisher = "Atria Books",
                    Summary = "An aging Hollywood icon tells the story of her scandalous life and seven marriages.",
                    CoverImage = string.Empty
                },
                new Book
                {
                    Id = Guid.NewGuid(),
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    Genre = "Classic",
                    Publisher = "J.B. Lippincott & Co.",
                    Summary = "A timeless novel about racial injustice and childhood in the Deep South.",
                    CoverImage = string.Empty
                }
            );
        }

    }
}
