using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class ChangeSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "Or forefather produced furniture at an incredible rate.  Is this because they were just that much more talented than we are today?  Possibly but they had the benefit of not knowing any other way to work and they took advantage of the unique nature of hand work to be efficient and eliminate steps that we would go through today in order to work with a machine.  ", new DateTime(2020, 6, 29, 8, 50, 18, 588, DateTimeKind.Local).AddTicks(6968), "Taking the Tool to Wood" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 2,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "Nails not only are 'acceptable' in your woodworking projects but they have experienced a resurgence in popularity.  But these are not the wire nails you will find at the typical hardware store.  These are the 18th and 19th century variants: cut nails and wrought nails.  Both of these types of nails have substantially more holding power then the modern equivalents but require a bit more care when driving them in.  First and foremost, in almost all cases you will want to bore a pilot hole before you reach for the hammer.", new DateTime(2020, 6, 29, 8, 50, 18, 591, DateTimeKind.Local).AddTicks(4398), "Nails 101" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 3,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "In its simplest form, a kitchen garden produces fresh fruits, vegetables and herbs for delicious, healthy meals. A kitchen garden doesn’t have to be right outside the kitchen door, but the closer it is, the better. Think about it this way: The easier it is for you to get into the garden, the more likely it is that you will get tasty things out of it. Did you forget to add the chopped dill on your boiled red-skinned potatoes? No problem — it’s just steps away.", new DateTime(2020, 6, 29, 8, 50, 18, 591, DateTimeKind.Local).AddTicks(4501), "Grow your own food" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 4,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "Your pool and spa are big investments, so it’s important to maintain them year-round. In this blog, we’ll go over the winterization basics for inground pools and above ground pools, as well as touch on spas and recommended products.", new DateTime(2020, 6, 29, 8, 50, 18, 591, DateTimeKind.Local).AddTicks(4509), "Winterize your pool" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 1,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "Rons super wood", new DateTime(2020, 6, 28, 14, 3, 2, 530, DateTimeKind.Local).AddTicks(1985), "My first candle boat" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "ContentId",
                keyValue: 2,
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "Ash", new DateTime(2020, 6, 28, 14, 3, 2, 532, DateTimeKind.Local).AddTicks(9688), "My second candle boat" });

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
                columns: new[] { "Body", "PublishDate", "Title" },
                values: new object[] { "this is body", new DateTime(2020, 6, 28, 14, 3, 2, 532, DateTimeKind.Local).AddTicks(9821), "Swimming" });
        }
    }
}
