using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Biblioteca.Migrations
{
    /// <inheritdoc />
    public partial class SeedEnglishBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("042eda71-25ab-48e3-9667-eaf0ef25cbee"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f7496ed5-606d-4494-9ddb-0e24b979fca8"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("042eda71-25ab-48e3-9667-eaf0ef25cbee"), "Fyodor Dostoyevski", "covers/sucveceza.jpg", "Roman", "İletişim Yayınları", "Raskolnikov’un vicdan azabı ve suç psikolojisini konu alan klasik.", "Suç ve Ceza" },
                    { new Guid("f7496ed5-606d-4494-9ddb-0e24b979fca8"), "George Orwell", "covers/1984.jpg", "Distopya", "Can Yayınları", "Totaliter rejimlerin tehlikelerini anlatan klasik eser.", "1984" }
                });
        }
    }
}
