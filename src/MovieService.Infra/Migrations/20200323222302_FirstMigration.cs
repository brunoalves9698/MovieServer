using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieService.Infra.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Password = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Role = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<TimeSpan>(type: "time(7)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false),
                    Nationality = table.Column<int>(type: "int", nullable: false),
                    Distributor = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Director = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Cast = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: false),
                    Sinopse = table.Column<string>(type: "varchar(800)", maxLength: 800, nullable: false),
                    Trailer = table.Column<string>(type: "varchar(200)", maxLength: 100, nullable: false),
                    PortraitImage = table.Column<string>(type: "varchar(200)", maxLength: 100, nullable: false),
                    LandscapeImage = table.Column<string>(type: "varchar(200)", maxLength: 100, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    CPF = table.Column<string>(type: "char(11)", maxLength: 11, nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Phone = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true),
                    Street = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Number = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true),
                    Neighborhood = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: true),
                    State = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "char(8)", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
