using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "PublishDate",
                value: new DateTime(2020, 6, 25, 19, 25, 42, 706, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2020, 6, 25, 19, 25, 42, 706, DateTimeKind.Local).AddTicks(7007));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1,
                column: "PublishDate",
                value: new DateTime(2020, 6, 25, 19, 3, 42, 260, DateTimeKind.Local).AddTicks(4276));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 2,
                column: "PublishDate",
                value: new DateTime(2020, 6, 25, 19, 3, 42, 262, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 3,
                column: "PublishDate",
                value: new DateTime(2020, 6, 25, 19, 3, 42, 262, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 4,
                column: "PublishDate",
                value: new DateTime(2020, 6, 25, 19, 3, 42, 262, DateTimeKind.Local).AddTicks(8544));
        }
    }
}
