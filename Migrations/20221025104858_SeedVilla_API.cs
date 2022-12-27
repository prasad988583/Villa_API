using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa_API.Migrations
{
    public partial class SeedVilla_API : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ewdgeqgewqgewqgewg", "Naa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
