using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_FARM.Migrations
{
    /// <inheritdoc />
    public partial class MigrationsSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "animal_types",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet", "Anna" },
                    { 2, "Consectetur adipiscing elit.", "John" },
                    { 3, "Sed do eiusmod tempor incididunt.", "Michael" },
                    { 4, "Lorem ipsum dolor sit amet", "Juan" },
                    { 5, "Consectetur adipiscing elit.", "Vicente" },
                    { 6, "Sed do eiusmod tempor incididunt.", "Monserrat" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "animal_types",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "animal_types",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "animal_types",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "animal_types",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "animal_types",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "animal_types",
                keyColumn: "id",
                keyValue: 6);
        }
    }
}
