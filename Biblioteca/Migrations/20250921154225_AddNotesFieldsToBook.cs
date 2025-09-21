using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Biblioteca.Migrations
{
    /// <inheritdoc />
    public partial class AddNotesFieldsToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24853c47-cca4-4785-b926-bb8a48ebc9aa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("27b8af4f-9ac0-4ab2-9f56-bf988fc39190"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7d26be01-7084-43e9-ae70-96d0c033a54f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81a84453-f140-44bf-ac5e-fe139910ecca"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8fd9b7a4-ba65-4db4-ad17-abb28d1b0228"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a48769a7-722b-4615-8c72-a054fd59978b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aac49d5c-22e2-4acc-90f3-76b33485f29a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d361976c-b0b2-4f29-b5a1-dab4c9403493"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e230d0e9-61a7-436b-85ad-5f0537708e88"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f398baf1-26a7-4550-9d3a-4e455eee178a"));

            migrationBuilder.AddColumn<string>(
                name: "FavoriteQuote",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImage", "FavoriteQuote", "Genre", "Notes", "Publisher", "Rating", "Summary", "Title" },
                values: new object[,]
                {
                    { new Guid("15e64535-6436-432b-ada5-4a3076e3e11c"), "Harper Lee", "", "", "Classic", "", "J.B. Lippincott & Co.", 0, "A timeless novel about racial injustice and childhood in the Deep South.", "To Kill a Mockingbird" },
                    { new Guid("2f76010b-51d7-4549-9c8f-c591419cea4b"), "Fyodor Dostoevsky", "", "", "Classic Novel", "", "Penguin Classics", 0, "The story of Raskolnikov, a young man tormented by guilt after committing a murder.", "Crime and Punishment" },
                    { new Guid("5b7b5fdc-80bd-416a-8e9f-5be8a55777f2"), "Orhan Pamuk", "", "", "Historical Novel", "", "Knopf", 0, "A rich tale set in the Ottoman Empire, blending art, religion, and mystery.", "My Name is Red" },
                    { new Guid("90c4e8cb-7698-49a3-9794-cca8a59cbaa0"), "Taylor Jenkins Reid", "", "", "Historical Fiction", "", "Atria Books", 0, "An aging Hollywood icon tells the story of her scandalous life and seven marriages.", "The Seven Husbands of Evelyn Hugo" },
                    { new Guid("ab5c66d8-4cae-49f6-ba9b-468dbe0c3089"), "Antoine de Saint-Exupéry", "", "", "Children / Philosophy", "", "Reynal & Hitchcock", 0, "A poetic tale about love, friendship, and the meaning of life.", "The Little Prince" },
                    { new Guid("abf1ef9e-ffee-481e-bf40-ca6d2a233107"), "Victor Hugo", "", "", "Classic Novel", "", "Random House", 0, "The epic story of Jean Valjean’s struggle for redemption in 19th-century France.", "Les Misérables" },
                    { new Guid("c7ab4a1e-d8fa-46d5-8932-d67bfd69acc9"), "George Orwell", "", "", "Dystopian", "", "Secker & Warburg", 0, "A chilling portrayal of a totalitarian regime and the dangers of absolute power.", "1984" },
                    { new Guid("d775be5a-22b6-44ba-bc00-0ee35ccb427b"), "Oğuz Atay", "", "", "Modern Literature", "", "Everest Publishing", 0, "A cornerstone of modern Turkish literature, exploring alienation and identity.", "The Disconnected" },
                    { new Guid("de170267-eacf-401f-84d8-43f3b31260f8"), "Sabahattin Ali", "", "", "Romance", "", "Penguin Modern Classics", 0, "The unforgettable love story of Raif Efendi and Maria Puder.", "Madonna in a Fur Coat" },
                    { new Guid("f6f120a5-2cb1-4afb-9204-420ef8547ad8"), "Zülfü Livaneli", "", "", "Historical Fiction", "", "Other Press", 0, "A novel intertwining love, tragedy, and history across generations.", "Serenade" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("15e64535-6436-432b-ada5-4a3076e3e11c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2f76010b-51d7-4549-9c8f-c591419cea4b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b7b5fdc-80bd-416a-8e9f-5be8a55777f2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("90c4e8cb-7698-49a3-9794-cca8a59cbaa0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ab5c66d8-4cae-49f6-ba9b-468dbe0c3089"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("abf1ef9e-ffee-481e-bf40-ca6d2a233107"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c7ab4a1e-d8fa-46d5-8932-d67bfd69acc9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d775be5a-22b6-44ba-bc00-0ee35ccb427b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("de170267-eacf-401f-84d8-43f3b31260f8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f6f120a5-2cb1-4afb-9204-420ef8547ad8"));

            migrationBuilder.DropColumn(
                name: "FavoriteQuote",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImage", "Genre", "Publisher", "Summary", "Title" },
                values: new object[,]
                {
                    { new Guid("24853c47-cca4-4785-b926-bb8a48ebc9aa"), "Orhan Pamuk", "", "Historical Novel", "Knopf", "A rich tale set in the Ottoman Empire, blending art, religion, and mystery.", "My Name is Red" },
                    { new Guid("27b8af4f-9ac0-4ab2-9f56-bf988fc39190"), "Fyodor Dostoevsky", "", "Classic Novel", "Penguin Classics", "The story of Raskolnikov, a young man tormented by guilt after committing a murder.", "Crime and Punishment" },
                    { new Guid("7d26be01-7084-43e9-ae70-96d0c033a54f"), "George Orwell", "", "Dystopian", "Secker & Warburg", "A chilling portrayal of a totalitarian regime and the dangers of absolute power.", "1984" },
                    { new Guid("81a84453-f140-44bf-ac5e-fe139910ecca"), "Zülfü Livaneli", "", "Historical Fiction", "Other Press", "A novel intertwining love, tragedy, and history across generations.", "Serenade" },
                    { new Guid("8fd9b7a4-ba65-4db4-ad17-abb28d1b0228"), "Oğuz Atay", "", "Modern Literature", "Everest Publishing", "A cornerstone of modern Turkish literature, exploring alienation and identity.", "The Disconnected" },
                    { new Guid("a48769a7-722b-4615-8c72-a054fd59978b"), "Antoine de Saint-Exupéry", "", "Children / Philosophy", "Reynal & Hitchcock", "A poetic tale about love, friendship, and the meaning of life.", "The Little Prince" },
                    { new Guid("aac49d5c-22e2-4acc-90f3-76b33485f29a"), "Sabahattin Ali", "", "Romance", "Penguin Modern Classics", "The unforgettable love story of Raif Efendi and Maria Puder.", "Madonna in a Fur Coat" },
                    { new Guid("d361976c-b0b2-4f29-b5a1-dab4c9403493"), "Taylor Jenkins Reid", "", "Historical Fiction", "Atria Books", "An aging Hollywood icon tells the story of her scandalous life and seven marriages.", "The Seven Husbands of Evelyn Hugo" },
                    { new Guid("e230d0e9-61a7-436b-85ad-5f0537708e88"), "Victor Hugo", "", "Classic Novel", "Random House", "The epic story of Jean Valjean’s struggle for redemption in 19th-century France.", "Les Misérables" },
                    { new Guid("f398baf1-26a7-4550-9d3a-4e455eee178a"), "Harper Lee", "", "Classic", "J.B. Lippincott & Co.", "A timeless novel about racial injustice and childhood in the Deep South.", "To Kill a Mockingbird" }
                });
        }
    }
}
