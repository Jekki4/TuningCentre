using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TuningCentre.Api.Migrations
{
    /// <inheritdoc />
    public partial class init228 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionEN",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameEN",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameEN",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "NameEN",
                value: "Spoilers");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "NameEN",
                value: "Hoods");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "NameEN",
                value: "Roofs");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "NameEN",
                value: "Front bumper splitters");

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "NameEN",
                value: "Rims");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "The parts are made of ultra-high-temperature Fiberglass (fiberglass) and have the weight of the original part, a thickness of 2-3 mm according to the standards, with a temperature range of up to 120° and ultimate strength.", "Hood for Mercedes-AMG GT 63 S X290" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "The exclusive carbon fiber version, manufactured in accordance with parameters close to aircraft technology, has a high strength factor, a temperature range above 120°, and a weight lower than the original part.", "Anti-wing (track version) for Porsche 911 Turbo-S (992)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "The hood with decorative inserts for the Porsche 911 Turbo-S (992) from Ronaldo performance perfectly complements the body shape.", "Hood for Porsche 911 Turbo-S (992)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "The hood with decorative inserts for the Nissan GT-R R35 (GOJIRA) by Ronaldo performance perfectly complements the body shape.", "Hood for Nissan GT-R R35 (GOJIRA)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "The parts are made of ultra-high-temperature Fiberglass (fiberglass) and have the weight of the original part, a thickness of 2-3 mm according to the standards, with a temperature range of up to 120° and ultimate strength.", "Aerodynamic spoiler for the Porsche 911 Turbo-S (992)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "The aerodynamic wing (spoiler) for the Porsche 911 Turbo-S (991) from Ronaldo Performance perfectly complements the body shape.", "Aerodynamic wing (spoiler) for Mercedes-AMG GT 63 S X290" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "The aerodynamic wing (spoiler) for the Nissan GT-R (GOJIRA) by Ronaldo Performance perfectly complements the body shape.", "Aerodynamic wing (spoiler) for Nissan GT-R (GOJIRA)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "The roof lining for the Chevrolet Camaro by Ronaldo Performance perfectly complements the body shape.", "Chevrolet Camaro roof cover" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "The parts are made of ultra-high-temperature Fiberglass (fiberglass) and have the weight of the original part, a thickness of 2-3 mm according to the standards, with a temperature range of up to 120° and ultimate strength.", "Roof liner in GT3 RS style for Porsche 911 Turbo-S (992)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "The exclusive carbon fiber version, manufactured in accordance with parameters close to aircraft technology, has a high strength factor, a temperature range above 120°, and a weight lower than the original part.", "Roof cover for Nissan GT-R R35 (GOJIRA)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "The exclusive carbon fiber version, manufactured in accordance with parameters close to aircraft technology, has a high strength factor, a temperature range above 120°, and a weight lower than the original part.", "Front bumper splitter (lip) for Porsche 911 Turbo-S (992)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "The front bumper splitter for the BMW M5 Competition F90 by Ronaldo Performance perfectly complements the body shape.", "Front bumper splitter BMW M5 F90 (M-Power)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "The front bumper splitter for BMW M850i xDrive Grand Coupe G16 (M8-POWER) by Ronaldo Performance perfectly complements the body shape.", "Front bumper splitter BMW M850i G16 (M-Power)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "22 radius", "Mad Max Dodge Challenger rims" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "22 radius", "Jeep Grand Cherokee rims" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "DescriptionEN", "NameEN" },
                values: new object[] { "24 радiус", "24 radius", "Lamborghini Urus wheels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "21 radius", "Mercedes-Benz Diamant GT wheels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DescriptionEN", "NameEN" },
                values: new object[] { "21 radius", "Nissan GT-R wheels" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionEN",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "NameEN",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "NameEN",
                table: "ProductCategories");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "24 радiус ");
        }
    }
}
