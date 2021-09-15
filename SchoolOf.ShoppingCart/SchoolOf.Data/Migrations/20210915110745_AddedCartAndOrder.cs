using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolOf.Data.Migrations
{
    public partial class AddedCartAndOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 11, 7, 45, 197, DateTimeKind.Unspecified).AddTicks(6353), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 11, 7, 45, 197, DateTimeKind.Unspecified).AddTicks(6595), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 11, 7, 45, 197, DateTimeKind.Unspecified).AddTicks(6820), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 11, 7, 45, 197, DateTimeKind.Unspecified).AddTicks(6822), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 11, 7, 45, 197, DateTimeKind.Unspecified).AddTicks(6825), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 11, 7, 45, 197, DateTimeKind.Unspecified).AddTicks(6826), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 11, 6, 21, 287, DateTimeKind.Unspecified).AddTicks(598), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 11, 6, 21, 287, DateTimeKind.Unspecified).AddTicks(840), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 11, 6, 21, 287, DateTimeKind.Unspecified).AddTicks(1066), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 11, 6, 21, 287, DateTimeKind.Unspecified).AddTicks(1068), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 11, 6, 21, 287, DateTimeKind.Unspecified).AddTicks(1070), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 11, 6, 21, 287, DateTimeKind.Unspecified).AddTicks(1072), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
