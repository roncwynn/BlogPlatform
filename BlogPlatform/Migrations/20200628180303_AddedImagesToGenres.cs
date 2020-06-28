using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class AddedImagesToGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Genres",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 14, 3, 2, 530, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 28, 14, 3, 2, 532, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 3,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "All veggies", new DateTime(2020, 6, 28, 14, 3, 2, 532, DateTimeKind.Local).AddTicks(9812), "Pull Weeds" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 4,
                columns: new[] { "Author", "PublishDate" },
                values: new object[] { "Jay Bowen", new DateTime(2020, 6, 28, 14, 3, 2, 532, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageName",
                value: "Wood.jpg");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageName", "Name" },
                values: new object[] { "Growing Extremely Hot Peppers", "Garden.jpg", "Gardening" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageName",
                value: "Pools.jpg");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Hot Peppers");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Mild Peppers");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Corn");

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Rafting" },
                    { 5, "Oak" },
                    { 6, "Maple" },
                    { 7, "Table Saw" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Genres");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 25, 19, 25, 42, 703, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 25, 19, 25, 42, 706, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 3,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "All rooms", new DateTime(2020, 6, 25, 19, 25, 42, 706, DateTimeKind.Local).AddTicks(7002), "Clean house" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 4,
                columns: new[] { "Author", "PublishDate" },
                values: new object[] { "Ron Wynn", new DateTime(2020, 6, 25, 19, 25, 42, 706, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Husbands who are VolunTOLD by their wives", "Life" });

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

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Tag3");
        }
    }
}
