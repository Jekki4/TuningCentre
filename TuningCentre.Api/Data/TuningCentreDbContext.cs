using TuningCentre.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace TuningCentre.Api.Data
{
    public class TuningCentreDbContext : DbContext
    {
        public TuningCentreDbContext(DbContextOptions<TuningCentreDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Products
            //Beauty Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Капот для Mercedes-AMG GT 63 S X290",
                Description = "Деталі виготовлені з ультра-високотемпературного Fiberglass (склопластику) мають вагу оригінальної деталі, завтовшки за стандартами 2-3 мм, з температурним режимом до 120° і граничною міцністю.",
                ImageURL = "/Images/Details/merc_hood.png",
                Price = 3500,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Антикрило (трек версія) для Porsche 911 Turbo-S (992)",
                Description = "Ексклюзивна версія з вуглеволокна (Carbon), виготовлена відповідно до параметрів, близьких до авіаційних технологій, володіє високим коефіцієнтом міцності, з температурним режимом вище 120° і вагою нижче за оригінальну деталь.",
                ImageURL = "/Images/Details/por_spoiler.png",
                Price = 2000,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Капот для Porsche 911 Turbo-S (992)",
                Description = "Капот з декоративними вставками для Porsche 911 Turbo-S (992) від Ronaldo performance відмінно доповнює форми кузова.",
                ImageURL = "/Images/Details/por_hood.png",
                Price = 4700,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Аеродинамічний спойлер для Porsche 911 Turbo-S (992)",
                Description = "Деталі виготовлені з ультра-високотемпературного Fiberglass (склопластику) мають вагу оригінальної деталі, завтовшки за стандартами 2-3 мм, з температурним режимом до 120° і граничною міцністю.",
                ImageURL = "/Images/Details/por_spoiler2.png",
                Price = 1700,
                CategoryId = 1
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Аеродинамічне антикрило (спойлер) для Mercedes-AMG GT 63 S X290",
                Description = "Аеродинамічне антикрило (спойлер) для Porsche 911 Turbo-S (991) від Ronaldo performance відмінно доповнює форми кузова.",
                ImageURL = "/Images/Details/merc_spoiler.png",
                Price = 2100,
                CategoryId = 1
            });
            

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Kyrylo"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Dmytro"

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
                Name = "Капоти",
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Капоти",
            });
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
