using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class AddedTags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreID",
                table: "Contents",
                newName: "GenreId");

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContentTag",
                columns: table => new
                {
                    ContentId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTag", x => new { x.ContentId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ContentTag_Contents_ContentId",
                        column: x => x.ContentId,
                        principalTable: "Contents",
                        principalColumn: "ContentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 22, 19, 22, 40, 367, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 22, 19, 22, 40, 370, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 6, 22, 19, 22, 40, 370, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Backyard adventures await", "Pools" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tag1" },
                    { 2, "Tag2" },
                    { 3, "Tag3" }
                });

            migrationBuilder.InsertData(
                table: "ContentTag",
                columns: new[] { "ContentId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 3, 2 },
                    { 2, 3 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "ContentId", "Author", "Body", "GenreId", "PublishDate", "Title" },
                values: new object[] { 4, "Ron Wynn", "this is body", 3, new DateTime(2020, 6, 22, 19, 22, 40, 370, DateTimeKind.Local).AddTicks(2502), "Swimming" });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_GenreId",
                table: "Contents",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentTag_TagId",
                table: "ContentTag",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Genres_GenreId",
                table: "Contents",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Genres_GenreId",
                table: "Contents");

            migrationBuilder.DropTable(
                name: "ContentTag");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Contents_GenreId",
                table: "Contents");

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Contents",
                newName: "GenreID");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 21, 13, 26, 25, 485, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 21, 13, 26, 25, 488, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 6, 21, 13, 26, 25, 488, DateTimeKind.Local).AddTicks(6261));
        }
    }
}
