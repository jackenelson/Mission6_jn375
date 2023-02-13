using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_jn375.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieInputs",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieInputs", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "MovieInputs",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action", "Kevin Reynolds", true, "", "", "PG-13", "Count of Monte Cristo", 2002 });

            migrationBuilder.InsertData(
                table: "MovieInputs",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Animated", "Adrian Molina", true, "", "", "PG", "Coco", 2017 });

            migrationBuilder.InsertData(
                table: "MovieInputs",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Animated", "Kelly Asbury", true, "", "", "G", "Spirit", 2002 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieInputs");
        }
    }
}
