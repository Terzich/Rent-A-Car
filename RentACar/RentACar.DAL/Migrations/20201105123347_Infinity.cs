using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentACar.DAL.Migrations
{
    public partial class Infinity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    YearOfProduction = table.Column<int>(maxLength: 2020, nullable: false),
                    NumberOfDoors = table.Column<int>(nullable: false),
                    HorsePower = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    DateofBirth = table.Column<DateTime>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    BookedCarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookedCars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    BookedFrom = table.Column<DateTime>(nullable: false),
                    BookedTo = table.Column<DateTime>(nullable: false),
                    TotalPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookedCars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookedCars_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookedCars_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "DateCreated", "Description", "HorsePower", "Name", "NumberOfDoors", "YearOfProduction" },
                values: new object[,]
                {
                    { 1, "Black", new DateTime(2020, 11, 5, 12, 33, 46, 779, DateTimeKind.Utc).AddTicks(9837), null, 131, "Mercedes Benz C220", 5, 2012 },
                    { 2, "Red", new DateTime(2020, 11, 5, 12, 33, 46, 780, DateTimeKind.Utc).AddTicks(4666), null, 151, "Mercedes Benz E220", 5, 2014 },
                    { 3, "White", new DateTime(2020, 11, 5, 12, 33, 46, 780, DateTimeKind.Utc).AddTicks(4745), null, 131, "Audi A6", 5, 2013 }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "DateCreated", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 5, 12, 33, 46, 788, DateTimeKind.Utc).AddTicks(1477), "Sarajevo" },
                    { 2, new DateTime(2020, 11, 5, 12, 33, 46, 788, DateTimeKind.Utc).AddTicks(2372), "Bugojno" },
                    { 3, new DateTime(2020, 11, 5, 12, 33, 46, 788, DateTimeKind.Utc).AddTicks(2388), "Mostar" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BookedCarId", "CityId", "DateCreated", "DateofBirth", "FirstName", "Lastname", "Username" },
                values: new object[] { 1, 0, 1, new DateTime(2020, 11, 5, 12, 33, 46, 790, DateTimeKind.Utc).AddTicks(1842), new DateTime(1999, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ahmed", "Terzić", "Terzich" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BookedCarId", "CityId", "DateCreated", "DateofBirth", "FirstName", "Lastname", "Username" },
                values: new object[] { 2, 0, 2, new DateTime(2020, 11, 5, 12, 33, 46, 790, DateTimeKind.Utc).AddTicks(6054), new DateTime(1998, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nihad", "Hrustić", "Nixi" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BookedCarId", "CityId", "DateCreated", "DateofBirth", "FirstName", "Lastname", "Username" },
                values: new object[] { 3, 0, 3, new DateTime(2020, 11, 5, 12, 33, 46, 790, DateTimeKind.Utc).AddTicks(6134), new DateTime(1998, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zlatan", "Haljeta", "Zlaja" });

            migrationBuilder.CreateIndex(
                name: "IX_BookedCars_CarId",
                table: "BookedCars",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_BookedCars_UserId",
                table: "BookedCars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookedCars");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
