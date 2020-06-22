using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class ReCreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 22, 19, 24, 45, 495, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 22, 19, 24, 45, 498, DateTimeKind.Local).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 6, 22, 19, 24, 45, 498, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2020, 6, 22, 19, 24, 45, 498, DateTimeKind.Local).AddTicks(3753));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2020, 6, 22, 19, 22, 40, 370, DateTimeKind.Local).AddTicks(2502));
        }
    }
}
