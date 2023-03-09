using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp5.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "IdCategory", "Name" },
                values: new object[,]
                {
                    { new Guid("6da82f7b-6b84-438c-8451-86352728709b"), "Фрукты" },
                    { new Guid("8e19db02-c3d2-4007-859b-319ef103f1bb"), "Овощи" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: new Guid("6da82f7b-6b84-438c-8451-86352728709b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "IdCategory",
                keyValue: new Guid("8e19db02-c3d2-4007-859b-319ef103f1bb"));
        }
    }
}
