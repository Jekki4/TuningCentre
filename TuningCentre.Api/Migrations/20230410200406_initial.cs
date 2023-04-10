using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TuningCentre.Api.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Спойлери" },
                    { 2, "Капоти" },
                    { 3, "Дахи" },
                    { 4, "Спліттери переднього бампера" },
                    { 5, "Диски" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Oleg" },
                    { 2, "Jenya" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 2, "Деталь виготовлені з ультра-високотемпературного Fiberglass (склопластику) мають вагу оригінальної деталі, завтовшки за стандартами 2-3 мм, з температурним режимом до 120° і граничною міцністю.", "/Images/Details/Hoods/merc_hood.png", "Капот для Mercedes-AMG GT 63 S X290", 3500m },
                    { 2, 1, "Ексклюзивна версія з вуглеволокна (Carbon), виготовлена відповідно до параметрів, близьких до авіаційних технологій, володіє високим коефіцієнтом міцності, з температурним режимом вище 120° і вагою нижче за оригінальну деталь.", "/Images/Details/Spoilers/por_spoiler.png", "Антикрило (трек версія) для Porsche 911 Turbo-S (992)", 2000m },
                    { 3, 2, "Капот з декоративними вставками для Porsche 911 Turbo-S (992) від Ronaldo performance відмінно доповнює форми кузова.", "/Images/Details/Hoods/por_hood.png", "Капот для Porsche 911 Turbo-S (992)", 4700m },
                    { 4, 2, "Капот з декоративними вставками для Nissan GT-R R35 (GOJIRA) від Ronaldo performance відмінно доповнює форми кузова.", "/Images/Details/Hoods/gtr_hood.png", "Капот для Nissan GT-R R35 (GOJIRA)", 4800m },
                    { 5, 1, "Деталь виготовлені з ультра-високотемпературного Fiberglass (склопластику) мають вагу оригінальної деталі, завтовшки за стандартами 2-3 мм, з температурним режимом до 120° і граничною міцністю.", "/Images/Details/Spoilers/por_spoiler2.png", "Аеродинамічний спойлер для Porsche 911 Turbo-S (992)", 1700m },
                    { 6, 1, "Аеродинамічне антикрило (спойлер) для Porsche 911 Turbo-S (991) від Ronaldo Performance відмінно доповнює форми кузова.", "/Images/Details/Spoilers/merc_spoiler.png", "Аеродинамічне антикрило (спойлер) для Mercedes-AMG GT 63 S X290", 2100m },
                    { 7, 1, "Аеродинамічне антикрило (спойлер) для Nissan GT-R (GOJIRA) від Ronaldo Performance відмінно доповнює форми кузова.", "/Images/Details/Spoilers/gtr_spoiler.png", "Аеродинамічне антикрило (спойлер) для Nissan GT-R (GOJIRA)", 2610m },
                    { 8, 3, "Накладка на дах для Chevrolet Camaro від Ronaldo Performance відмінно доповнює форми кузова.", "/Images/Details/Roofs/roof_camaro.jpg", "Накладка на дах Chevrolet Camaro", 1860m },
                    { 9, 3, "Деталь виготовлені з ультра-високотемпературного Fiberglass (склопластику) мають вагу оригінальної деталі, завтовшки за стандартами 2-3 мм, з температурним режимом до 120° і граничною міцністю.", "/Images/Details/Roofs/roof_porsche.jpg", "Накладка на дах у стилі GT3 RS для Porsche 911 Turbo-S (992)", 2520m },
                    { 10, 3, "Ексклюзивна версія з вуглеволокна (Carbon), виготовлена відповідно до параметрів, близьких до авіаційних технологій, володіє високим коефіцієнтом міцності, з температурним режимом вище 120° і вагою нижче за оригінальну деталь.", "/Images/Details/Roofs/roof_gtr.jpg", "Накладка на дах Nissan GT-R R35 (GOJIRA)", 2700m },
                    { 11, 4, "Ексклюзивна версія з вуглеволокна (Carbon), виготовлена відповідно до параметрів, близьких до авіаційних технологій, володіє високим коефіцієнтом міцності, з температурним режимом вище 120° і вагою нижче за оригінальну деталь.", "/Images/Details/Splitters/splitter_porsche.jpg", "Сплітер (губа) переднього бампера для Porsche 911 Turbo-S (992)", 2660m },
                    { 12, 4, "Сплітер переднього бампера для BMW M5 Competition F90 від Ronaldo Performance відмінно доповнює форми кузова.", "/Images/Details/Splitters/splitter_bmw_m5.jpg", "Сплітер переднього бампера BMW M5 F90 (M-Power)", 2130m },
                    { 13, 4, "Сплітер переднього бампера для BMW M850i xDrive Grand Coupe G16 (M8-POWER) від Ronaldo Performance відмінно доповнює форми кузова.", "/Images/Details/Splitters/splitter_bmw_m850i.jpg", "Сплітер переднього бампера BMW M850i G16 (M-Power)", 1870m },
                    { 14, 5, "22 радiус", "/Images/Details/Wheels/dodge_wheels.jpg", "Диски Mad Max Dodge Challendger", 3110m },
                    { 15, 5, "22 радiус", "/Images/Details/Wheels/jeep_wheels.jpg", "Диски Jeep Grand Cherokee", 3000m },
                    { 16, 5, "24 радiус ", "/Images/Details/Wheels/lambo_wheels.jpg", "Диски Lamborghini Urus", 4000m },
                    { 17, 5, "21 радiус", "/Images/Details/Wheels/mercedes_wheels.jpg", "Диски Mercedes-Benz Diamant GT", 3400m },
                    { 18, 5, "21 радiус", "/Images/Details/Wheels/gtr_wheels.jpg", "Диски Nissan GT-R", 3700m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
