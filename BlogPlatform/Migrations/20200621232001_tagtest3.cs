using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class tagtest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ContentTag",
                columns: new[] { "ContentId", "TagId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 21, 19, 20, 0, 496, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 21, 19, 20, 0, 499, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 6, 21, 19, 20, 0, 499, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Backyard adventures await", "Pools" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Tag1");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Tag2");

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Tag3" });

            migrationBuilder.InsertData(
                table: "ContentTag",
                columns: new[] { "ContentId", "TagId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "ContentTag",
                columns: new[] { "ContentId", "TagId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "ContentId", "Author", "Body", "GenreId", "PublishDate", "Title" },
                values: new object[] { 4, "Ron Wynn", "this is body", 3, new DateTime(2020, 6, 21, 19, 20, 0, 499, DateTimeKind.Local).AddTicks(3524), "Swimming" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ContentTag",
                keyColumns: new[] { "ContentId", "TagId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ContentTag",
                keyColumns: new[] { "ContentId", "TagId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ContentTag",
                keyColumns: new[] { "ContentId", "TagId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ContentTag",
                keyColumns: new[] { "ContentId", "TagId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 21, 19, 14, 37, 130, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 21, 19, 14, 37, 134, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 6, 21, 19, 14, 37, 134, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Tag One");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Tag two");
        }
    }
}
