using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Biblioteca.Migrations
{
    /// <inheritdoc />
    public partial class AddGenreToBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("37428ad1-2d05-467f-a038-636679e23394"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3d927fda-89ac-4ad4-ad3d-4e65b7833b67"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("709ed0eb-5143-434b-8a73-e7bf72bda2d8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7483ea7a-9bba-484b-a893-b6067058fb57"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("873e2667-9efe-4c02-bee1-4143181f1fc8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("94317ded-7cad-4f73-aacf-541960a9a375"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b7a81886-2055-43e7-8475-a44772a6ebbc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c2a2fae5-28e1-4521-97e8-85c5bc416460"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d49d0dbb-074d-49cd-8968-3647a38b1013"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("debff881-f93c-4d51-ac6c-dad48fa4231d"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImage", "Genre", "Publisher", "Summary", "Title" },
                values: new object[,]
                {
                    { new Guid("37428ad1-2d05-467f-a038-636679e23394"), "George Orwell", "", "Dystopian", "Secker & Warburg", "A chilling portrayal of a totalitarian regime and the dangers of absolute power.", "1984" },
                    { new Guid("3d927fda-89ac-4ad4-ad3d-4e65b7833b67"), "Fyodor Dostoevsky", "", "Classic Novel", "Penguin Classics", "The story of Raskolnikov, a young man tormented by guilt after committing a murder.", "Crime and Punishment" },
                    { new Guid("709ed0eb-5143-434b-8a73-e7bf72bda2d8"), "Antoine de Saint-Exupéry", "", "Children / Philosophy", "Reynal & Hitchcock", "A poetic tale about love, friendship, and the meaning of life.", "The Little Prince" },
                    { new Guid("7483ea7a-9bba-484b-a893-b6067058fb57"), "Zülfü Livaneli", "", "Historical Fiction", "Other Press", "A novel intertwining love, tragedy, and history across generations.", "Serenade" },
                    { new Guid("873e2667-9efe-4c02-bee1-4143181f1fc8"), "Harper Lee", "", "Classic", "J.B. Lippincott & Co.", "A timeless novel about racial injustice and childhood in the Deep South.", "To Kill a Mockingbird" },
                    { new Guid("94317ded-7cad-4f73-aacf-541960a9a375"), "Oğuz Atay", "", "Modern Literature", "Everest Publishing", "A cornerstone of modern Turkish literature, exploring alienation and identity.", "The Disconnected" },
                    { new Guid("b7a81886-2055-43e7-8475-a44772a6ebbc"), "Sabahattin Ali", "", "Romance", "Penguin Modern Classics", "The unforgettable love story of Raif Efendi and Maria Puder.", "Madonna in a Fur Coat" },
                    { new Guid("c2a2fae5-28e1-4521-97e8-85c5bc416460"), "Taylor Jenkins Reid", "", "Historical Fiction", "Atria Books", "An aging Hollywood icon tells the story of her scandalous life and seven marriages.", "The Seven Husbands of Evelyn Hugo" },
                    { new Guid("d49d0dbb-074d-49cd-8968-3647a38b1013"), "Orhan Pamuk", "", "Historical Novel", "Knopf", "A rich tale set in the Ottoman Empire, blending art, religion, and mystery.", "My Name is Red" },
                    { new Guid("debff881-f93c-4d51-ac6c-dad48fa4231d"), "Victor Hugo", "", "Classic Novel", "Random House", "The epic story of Jean Valjean’s struggle for redemption in 19th-century France.", "Les Misérables" }
                });
        }
    }
}
