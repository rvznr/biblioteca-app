using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Biblioteca.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CoverImage", "Genre", "Publisher", "Summary", "Title" },
                values: new object[,]
                {
                    { new Guid("042eda71-25ab-48e3-9667-eaf0ef25cbee"), "Fyodor Dostoyevski", "covers/sucveceza.jpg", "Roman", "İletişim Yayınları", "Raskolnikov’un vicdan azabı ve suç psikolojisini konu alan klasik.", "Suç ve Ceza" },
                    { new Guid("f7496ed5-606d-4494-9ddb-0e24b979fca8"), "George Orwell", "covers/1984.jpg", "Distopya", "Can Yayınları", "Totaliter rejimlerin tehlikelerini anlatan klasik eser.", "1984" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
