using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "AdoptionDate", "Age", "Breed", "CheckInDate", "Gender", "IsAdopted", "Name", "Species" },
                values: new object[,]
                {
                    { 1, null, 7, "Tabby", new DateTime(2017, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", false, "Boots", 0 },
                    { 2, null, 4, "Retriever", new DateTime(2019, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", false, "Bandit", 1 },
                    { 3, null, 3, "Siamese", new DateTime(2017, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", false, "Felix", 0 },
                    { 4, null, 2, "Collie", new DateTime(2019, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", false, "Lassie", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);
        }
    }
}
