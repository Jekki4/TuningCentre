using TuningCentre.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace TuningCentre.Api.Data
{
    public class TuningCentreDbContext : DbContext //Заповнення бази даних
    {
        public TuningCentreDbContext(DbContextOptions<TuningCentreDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Капот для Mercedes-AMG GT 63 S X290",
                Description = "Деталь виготовлені з ультра-високотемпературного Fiberglass (склопластику) мають вагу оригінальної деталі, завтовшки за стандартами 2-3 мм, з температурним режимом до 120° і граничною міцністю.",
                ImageURL = "/Images/Details/Hoods/merc_hood.png",
                Price = 3500,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Антикрило (трек версія) для Porsche 911 Turbo-S (992)",
                Description = "Ексклюзивна версія з вуглеволокна (Carbon), виготовлена відповідно до параметрів, близьких до авіаційних технологій, володіє високим коефіцієнтом міцності, з температурним режимом вище 120° і вагою нижче за оригінальну деталь.",
                ImageURL = "/Images/Details/Spoilers/por_spoiler.png",
                Price = 2000,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Капот для Porsche 911 Turbo-S (992)",
                Description = "Капот з декоративними вставками для Porsche 911 Turbo-S (992) від Ronaldo performance відмінно доповнює форми кузова.",
                ImageURL = "/Images/Details/Hoods/por_hood.png",
                Price = 4700,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Капот для Nissan GT-R R35 (GOJIRA)",
                Description = "Капот з декоративними вставками для Nissan GT-R R35 (GOJIRA) від Ronaldo performance відмінно доповнює форми кузова.",
                ImageURL = "/Images/Details/Hoods/gtr_hood.png",
                Price = 4800,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Аеродинамічний спойлер для Porsche 911 Turbo-S (992)",
                Description = "Деталь виготовлені з ультра-високотемпературного Fiberglass (склопластику) мають вагу оригінальної деталі, завтовшки за стандартами 2-3 мм, з температурним режимом до 120° і граничною міцністю.",
                ImageURL = "/Images/Details/Spoilers/por_spoiler2.png",
                Price = 1700,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Аеродинамічне антикрило (спойлер) для Mercedes-AMG GT 63 S X290",
                Description = "Аеродинамічне антикрило (спойлер) для Porsche 911 Turbo-S (991) від Ronaldo Performance відмінно доповнює форми кузова.",
                ImageURL = "/Images/Details/Spoilers/merc_spoiler.png",
                Price = 2100,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Аеродинамічне антикрило (спойлер) для Nissan GT-R (GOJIRA)",
                Description = "Аеродинамічне антикрило (спойлер) для Nissan GT-R (GOJIRA) від Ronaldo Performance відмінно доповнює форми кузова.",
                ImageURL = "/Images/Details/Spoilers/gtr_spoiler.png",
                Price = 2610,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Накладка на дах Chevrolet Camaro",
                Description = "Накладка на дах для Chevrolet Camaro від Ronaldo Performance відмінно доповнює форми кузова.",
                ImageURL = "/Images/Details/Roofs/roof_camaro.jpg",
                Price = 1860,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Накладка на дах у стилі GT3 RS для Porsche 911 Turbo-S (992)",
                Description = "Деталь виготовлені з ультра-високотемпературного Fiberglass (склопластику) мають вагу оригінальної деталі, завтовшки за стандартами 2-3 мм, з температурним режимом до 120° і граничною міцністю.",
                ImageURL = "/Images/Details/Roofs/roof_porsche.jpg",
                Price = 2520,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Накладка на дах Nissan GT-R R35 (GOJIRA)",
                Description = "Ексклюзивна версія з вуглеволокна (Carbon), виготовлена відповідно до параметрів, близьких до авіаційних технологій, володіє високим коефіцієнтом міцності, з температурним режимом вище 120° і вагою нижче за оригінальну деталь.",
                ImageURL = "/Images/Details/Roofs/roof_gtr.jpg",
                Price = 2700,
                CategoryId = 3
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Сплітер (губа) переднього бампера для Porsche 911 Turbo-S (992)",
                Description = "Ексклюзивна версія з вуглеволокна (Carbon), виготовлена відповідно до параметрів, близьких до авіаційних технологій, володіє високим коефіцієнтом міцності, з температурним режимом вище 120° і вагою нижче за оригінальну деталь.",
                ImageURL = "/Images/Details/Splitters/splitter_porsche.jpg",
                Price = 2660,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Сплітер переднього бампера BMW M5 F90 (M-Power)",
                Description = "Сплітер переднього бампера для BMW M5 Competition F90 від Ronaldo Performance відмінно доповнює форми кузова.",
                ImageURL = "/Images/Details/Splitters/splitter_bmw_m5.jpg",
                Price = 2130,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Сплітер переднього бампера BMW M850i G16 (M-Power)",
                Description = "Сплітер переднього бампера для BMW M850i xDrive Grand Coupe G16 (M8-POWER) від Ronaldo Performance відмінно доповнює форми кузова.",
                ImageURL = "/Images/Details/Splitters/splitter_bmw_m850i.jpg",
                Price = 1870,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Диски Mad Max Dodge Challendger",
                Description = "22 радiус",
                ImageURL = "/Images/Details/Wheels/dodge_wheels.jpg",
                Price = 3110,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Диски Jeep Grand Cherokee",
                Description = "22 радiус",
                ImageURL = "/Images/Details/Wheels/jeep_wheels.jpg",
                Price = 3000,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Диски Lamborghini Urus",
                Description = "24 радiус ",
                ImageURL = "/Images/Details/Wheels/lambo_wheels.jpg",
                Price = 4000,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Диски Mercedes-Benz Diamant GT",
                Description = "21 радiус",
                ImageURL = "/Images/Details/Wheels/mercedes_wheels.jpg",
                Price = 3400,
                CategoryId = 5
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Диски Nissan GT-R",
                Description = "21 радiус",
                ImageURL = "/Images/Details/Wheels/gtr_wheels.jpg",
                Price = 3700,
                CategoryId = 5
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Oleg"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Jenya"

            });

            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Спойлери",
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Капоти",
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Дахи",
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Спліттери переднього бампера",
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 5,
                Name = "Диски",
            });
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
