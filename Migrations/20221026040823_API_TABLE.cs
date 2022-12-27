using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa_API.Migrations
{
    public partial class API_TABLE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "NA", "Sekhar" });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Excelence", "Conga" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super", "Apttus" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ok", "Prasad" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "ewdgeqgewqgewqgewg", "Naa" });
        }
    }
}
