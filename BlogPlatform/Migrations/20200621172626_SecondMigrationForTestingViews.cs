using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class SecondMigrationForTestingViews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 21, 13, 26, 25, 485, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "ContentId", "Author", "Body", "GenreID", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 2, "Ron Wynn", "Ash", 1, new DateTime(2020, 6, 21, 13, 26, 25, 488, DateTimeKind.Local).AddTicks(6145), "My second candle boat" },
                    { 3, "Ron Wynn", "All rooms", 2, new DateTime(2020, 6, 21, 13, 26, 25, 488, DateTimeKind.Local).AddTicks(6261), "Clean house" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Husbands who are VolunTOLD by their wives", "Life" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 21, 13, 18, 41, 385, DateTimeKind.Local).AddTicks(7889));
        }
    }
}
