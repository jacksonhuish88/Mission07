using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission07.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lentTo = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Action", "Ridley Scott", false, null, null, "R", "Gladiator", 2000 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Action", "Clint Eastwood", false, null, null, "R", "American Sniper", 2014 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "category", "director", "edited", "lentTo", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Action", "Matt Reeves", false, null, null, "PG-13", "The Batman", 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
