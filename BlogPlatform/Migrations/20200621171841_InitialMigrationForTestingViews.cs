using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class InitialMigrationForTestingViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    ContentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.ContentId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "ContentId", "Author", "Body", "GenreID", "PublishDate", "Title" },
                values: new object[] { 1, "Jay Bowen", "Rons super wood", 1, new DateTime(2020, 6, 21, 13, 18, 41, 385, DateTimeKind.Local).AddTicks(7889), "My first candle boat" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Build furniture today!", "Woodworking" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
