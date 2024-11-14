using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CordiSimpleDotnet.Migrations
{
    /// <inheritdoc />
    public partial class EventsTableAndSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    start_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    location = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    occupied_slots = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "events",
                columns: new[] { "id", "capacity", "description", "end_date", "location", "name", "occupied_slots", "start_date", "status" },
                values: new object[,]
                {
                    { 1, 250, "encuentro literario con escritores y editoriales locales.", new DateTime(2024, 10, 29, 18, 0, 0, 0, DateTimeKind.Unspecified), "plaza mayor, medellín", "feria del libro", 0, new DateTime(2024, 10, 25, 9, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, 250, "exposición de avances tecnológicos y nuevas innovaciones.", new DateTime(2024, 12, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "corferias, bogotá", "expo tecnología", 0, new DateTime(2024, 12, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 3, 250, "exposición de obras de arte contemporáneo de artistas colombianos.", new DateTime(2024, 11, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), "museo de arte moderno, cartagena", "exposición de arte moderno", 0, new DateTime(2024, 11, 20, 11, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 4, 250, "concierto navideño con coros y orquestas locales.", new DateTime(2024, 12, 15, 21, 0, 0, 0, DateTimeKind.Unspecified), "teatro metropolitano, medellín", "concierto de navidad", 0, new DateTime(2024, 12, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 5, 250, "proyección de películas y charlas con cineastas colombianos.", new DateTime(2024, 11, 2, 22, 0, 0, 0, DateTimeKind.Unspecified), "cine colombia, cali", "festival de cine", 0, new DateTime(2024, 10, 30, 14, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 6, 250, "encuentro de profesionales de la salud con charlas y talleres.", new DateTime(2024, 11, 7, 17, 0, 0, 0, DateTimeKind.Unspecified), "hotel hilton, cartagena", "congreso de medicina", 0, new DateTime(2024, 11, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 7, 250, "muestra de la gastronomía colombiana con degustaciones y talleres.", new DateTime(2024, 12, 12, 19, 0, 0, 0, DateTimeKind.Unspecified), "centro de convenciones, cali", "expo gastronómica", 0, new DateTime(2024, 12, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), false },
                    { 8, 250, "presentaciones de grupos de danza folclórica de diferentes regiones.", new DateTime(2024, 11, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), "plaza mayor, medellín", "festival de danza folclórica", 0, new DateTime(2024, 11, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 9, 250, "competencia de atletismo en diferentes categorías.", new DateTime(2024, 12, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "parque simón bolívar, bogotá", "carrera 10k", 0, new DateTime(2024, 12, 20, 7, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 10, 250, "un festival de música al aire libre con artistas nacionales e internacionales.", new DateTime(2024, 11, 10, 23, 59, 0, 0, DateTimeKind.Unspecified), "parque simón bolívar, bogotá", "festival de música", 0, new DateTime(2024, 11, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "events");
        }
    }
}
