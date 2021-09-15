using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolOf.Data.Migrations
{
    public partial class ChangedProductDescriptionLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 11, 5, 34, 594, DateTimeKind.Unspecified).AddTicks(4932), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 11, 5, 34, 594, DateTimeKind.Unspecified).AddTicks(5203), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 11, 5, 34, 594, DateTimeKind.Unspecified).AddTicks(5643), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 11, 5, 34, 594, DateTimeKind.Unspecified).AddTicks(5645), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 9, 15, 11, 5, 34, 594, DateTimeKind.Unspecified).AddTicks(5648), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 9, 15, 11, 5, 34, 594, DateTimeKind.Unspecified).AddTicks(5649), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
