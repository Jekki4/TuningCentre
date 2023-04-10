﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TuningCentre.Api.Data;

#nullable disable

namespace TuningCentre.Api.Migrations
{
    [DbContext(typeof(TuningCentreDbContext))]
    [Migration("20230410200406_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TuningCentre.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("TuningCentre.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("TuningCentre.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "Деталь виготовлені з ультра-високотемпературного Fiberglass (склопластику) мають вагу оригінальної деталі, завтовшки за стандартами 2-3 мм, з температурним режимом до 120° і граничною міцністю.",
                            ImageURL = "/Images/Details/Hoods/merc_hood.png",
                            Name = "Капот для Mercedes-AMG GT 63 S X290",
                            Price = 3500m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Ексклюзивна версія з вуглеволокна (Carbon), виготовлена відповідно до параметрів, близьких до авіаційних технологій, володіє високим коефіцієнтом міцності, з температурним режимом вище 120° і вагою нижче за оригінальну деталь.",
                            ImageURL = "/Images/Details/Spoilers/por_spoiler.png",
                            Name = "Антикрило (трек версія) для Porsche 911 Turbo-S (992)",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "Капот з декоративними вставками для Porsche 911 Turbo-S (992) від Ronaldo performance відмінно доповнює форми кузова.",
                            ImageURL = "/Images/Details/Hoods/por_hood.png",
                            Name = "Капот для Porsche 911 Turbo-S (992)",
                            Price = 4700m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Капот з декоративними вставками для Nissan GT-R R35 (GOJIRA) від Ronaldo performance відмінно доповнює форми кузова.",
                            ImageURL = "/Images/Details/Hoods/gtr_hood.png",
                            Name = "Капот для Nissan GT-R R35 (GOJIRA)",
                            Price = 4800m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Деталь виготовлені з ультра-високотемпературного Fiberglass (склопластику) мають вагу оригінальної деталі, завтовшки за стандартами 2-3 мм, з температурним режимом до 120° і граничною міцністю.",
                            ImageURL = "/Images/Details/Spoilers/por_spoiler2.png",
                            Name = "Аеродинамічний спойлер для Porsche 911 Turbo-S (992)",
                            Price = 1700m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "Аеродинамічне антикрило (спойлер) для Porsche 911 Turbo-S (991) від Ronaldo Performance відмінно доповнює форми кузова.",
                            ImageURL = "/Images/Details/Spoilers/merc_spoiler.png",
                            Name = "Аеродинамічне антикрило (спойлер) для Mercedes-AMG GT 63 S X290",
                            Price = 2100m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "Аеродинамічне антикрило (спойлер) для Nissan GT-R (GOJIRA) від Ronaldo Performance відмінно доповнює форми кузова.",
                            ImageURL = "/Images/Details/Spoilers/gtr_spoiler.png",
                            Name = "Аеродинамічне антикрило (спойлер) для Nissan GT-R (GOJIRA)",
                            Price = 2610m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Накладка на дах для Chevrolet Camaro від Ronaldo Performance відмінно доповнює форми кузова.",
                            ImageURL = "/Images/Details/Roofs/roof_camaro.jpg",
                            Name = "Накладка на дах Chevrolet Camaro",
                            Price = 1860m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Деталь виготовлені з ультра-високотемпературного Fiberglass (склопластику) мають вагу оригінальної деталі, завтовшки за стандартами 2-3 мм, з температурним режимом до 120° і граничною міцністю.",
                            ImageURL = "/Images/Details/Roofs/roof_porsche.jpg",
                            Name = "Накладка на дах у стилі GT3 RS для Porsche 911 Turbo-S (992)",
                            Price = 2520m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Ексклюзивна версія з вуглеволокна (Carbon), виготовлена відповідно до параметрів, близьких до авіаційних технологій, володіє високим коефіцієнтом міцності, з температурним режимом вище 120° і вагою нижче за оригінальну деталь.",
                            ImageURL = "/Images/Details/Roofs/roof_gtr.jpg",
                            Name = "Накладка на дах Nissan GT-R R35 (GOJIRA)",
                            Price = 2700m
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 4,
                            Description = "Ексклюзивна версія з вуглеволокна (Carbon), виготовлена відповідно до параметрів, близьких до авіаційних технологій, володіє високим коефіцієнтом міцності, з температурним режимом вище 120° і вагою нижче за оригінальну деталь.",
                            ImageURL = "/Images/Details/Splitters/splitter_porsche.jpg",
                            Name = "Сплітер (губа) переднього бампера для Porsche 911 Turbo-S (992)",
                            Price = 2660m
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 4,
                            Description = "Сплітер переднього бампера для BMW M5 Competition F90 від Ronaldo Performance відмінно доповнює форми кузова.",
                            ImageURL = "/Images/Details/Splitters/splitter_bmw_m5.jpg",
                            Name = "Сплітер переднього бампера BMW M5 F90 (M-Power)",
                            Price = 2130m
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 4,
                            Description = "Сплітер переднього бампера для BMW M850i xDrive Grand Coupe G16 (M8-POWER) від Ronaldo Performance відмінно доповнює форми кузова.",
                            ImageURL = "/Images/Details/Splitters/splitter_bmw_m850i.jpg",
                            Name = "Сплітер переднього бампера BMW M850i G16 (M-Power)",
                            Price = 1870m
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 5,
                            Description = "22 радiус",
                            ImageURL = "/Images/Details/Wheels/dodge_wheels.jpg",
                            Name = "Диски Mad Max Dodge Challendger",
                            Price = 3110m
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 5,
                            Description = "22 радiус",
                            ImageURL = "/Images/Details/Wheels/jeep_wheels.jpg",
                            Name = "Диски Jeep Grand Cherokee",
                            Price = 3000m
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 5,
                            Description = "24 радiус ",
                            ImageURL = "/Images/Details/Wheels/lambo_wheels.jpg",
                            Name = "Диски Lamborghini Urus",
                            Price = 4000m
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 5,
                            Description = "21 радiус",
                            ImageURL = "/Images/Details/Wheels/mercedes_wheels.jpg",
                            Name = "Диски Mercedes-Benz Diamant GT",
                            Price = 3400m
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 5,
                            Description = "21 радiус",
                            ImageURL = "/Images/Details/Wheels/gtr_wheels.jpg",
                            Name = "Диски Nissan GT-R",
                            Price = 3700m
                        });
                });

            modelBuilder.Entity("TuningCentre.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Спойлери"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Капоти"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Дахи"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Спліттери переднього бампера"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Диски"
                        });
                });

            modelBuilder.Entity("TuningCentre.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Oleg"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Jenya"
                        });
                });

            modelBuilder.Entity("TuningCentre.Api.Entities.Product", b =>
                {
                    b.HasOne("TuningCentre.Api.Entities.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });
#pragma warning restore 612, 618
        }
    }
}