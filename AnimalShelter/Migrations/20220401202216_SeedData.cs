using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 13, "Celtic Setter", "Female", "Sophie", "Dog" },
                    { 18, 3, "Sphynx", "Female", "LeeLoo", "Cat" },
                    { 17, 4, "Siamese", "Male", "Zero", "Cat" },
                    { 16, 1, "Bengal", "Male", "Oliver", "Cat" },
                    { 15, 7, "Tabby", "Female", "Oona", "Cat" },
                    { 14, 6, "Russian Blue", "Male", "Dave", "Cat" },
                    { 13, 5, "Scottish Fold", "Male", "Beans", "Cat" },
                    { 12, 4, "Maine Coon", "Male", "Dog", "Cat" },
                    { 11, 12, "Orange Tabby", "Female", "Charlie", "Cat" },
                    { 10, 5, "Beagle", "Female", "Lucky", "Dog" },
                    { 9, 6, "Dalmation", "Female", "Spot", "Dog" },
                    { 8, 3, "Bull Terrier", "Female", "Zoie", "Dog" },
                    { 7, 4, "Poodle", "Male", "Marcus", "Dog" },
                    { 6, 1, "Golden Retriever", "Male", "Zane", "Dog" },
                    { 5, 7, "Pitbull", "Female", "Penny", "Dog" },
                    { 4, 6, "Jack Russel Terrier", "Male", "Gary2", "Dog" },
                    { 3, 5, "Coon Hound", "Male", "Lawrence", "Dog" },
                    { 2, 4, "English Bulldog", "Male", "Bucket", "Dog" },
                    { 19, 6, "Oriental Shorthair", "Female", "Madame Princess Cat", "Cat" },
                    { 20, 5, "Persian", "Female", "Boo", "Cat" }
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

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 20);
        }
    }
}
