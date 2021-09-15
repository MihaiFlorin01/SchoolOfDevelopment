using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolOf.Data.Migrations
{
    public partial class AddedProductsToCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 12, 11, 7, 605, DateTimeKind.Unspecified).AddTicks(4518), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 12, 11, 7, 605, DateTimeKind.Unspecified).AddTicks(4754), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 12, 11, 7, 605, DateTimeKind.Unspecified).AddTicks(4985), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 12, 11, 7, 605, DateTimeKind.Unspecified).AddTicks(4987), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 12, 11, 7, 605, DateTimeKind.Unspecified).AddTicks(4990), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 12, 11, 7, 605, DateTimeKind.Unspecified).AddTicks(4991), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 12, 4, 41, 723, DateTimeKind.Unspecified).AddTicks(2581), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 12, 4, 41, 723, DateTimeKind.Unspecified).AddTicks(2815), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 12, 4, 41, 723, DateTimeKind.Unspecified).AddTicks(3033), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 12, 4, 41, 723, DateTimeKind.Unspecified).AddTicks(3036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 12, 4, 41, 723, DateTimeKind.Unspecified).AddTicks(3038), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 12, 4, 41, 723, DateTimeKind.Unspecified).AddTicks(3039), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
