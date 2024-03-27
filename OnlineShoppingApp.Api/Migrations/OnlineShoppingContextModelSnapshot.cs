﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShoppingApp.Api.Data;

#nullable disable

namespace OnlineShoppingApp.Api.Migrations
{
    [DbContext(typeof(OnlineShoppingContext))]
    partial class OnlineShoppingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineShoppingApp.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("OnlineShoppingApp.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("OnlineShoppingApp.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Glossier tarafından sağlanan, cilt bakımı, saç bakımı ve makyaj ürünlerini içeren bir kit",
                            ImageURL = "/Images/Beauty/Beauty1.png",
                            Name = "Parlatıcı - Güzellik Seti",
                            Price = 100m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Curology tarafından sağlanan, cilt bakım ürünlerini içeren bir kit",
                            ImageURL = "/Images/Beauty/Beauty2.png",
                            Name = "Curology - Cilt Bakım Seti",
                            Price = 50m,
                            Quantity = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Curology tarafından sağlanan, cilt bakım ürünlerini içeren bir kit",
                            ImageURL = "/Images/Beauty/Beauty3.png",
                            Name = "Cocooil - Organik Hindistan Cevizi Yağı",
                            Price = 20m,
                            Quantity = 30
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Schwarzkopf tarafından sağlanan, cilt bakımı ve saç bakım ürünlerini içeren bir kit",
                            ImageURL = "/Images/Beauty/Beauty4.png",
                            Name = "Schwarzkopf - Saç Bakım ve Cilt Bakım Seti",
                            Price = 50m,
                            Quantity = 60
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Cilt bakımı ve saç bakım ürünlerini içeren Cilt Bakım Seti",
                            ImageURL = "/Images/Beauty/Beauty5.png",
                            Name = "Cilt Bakım Seti",
                            Price = 30m,
                            Quantity = 85
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Air Pods - kulak içi kablosuz kulaklıklar",
                            ImageURL = "/Images/Electronic/Electronics1.png",
                            Name = "Airpod'lar",
                            Price = 100m,
                            Quantity = 120
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Kulak üstü Altın Kulaklıklar - bu kulaklıklar kablosuz değildir",
                            ImageURL = "/Images/Electronic/Electronics2.png",
                            Name = "Kulak üstü Altın Kulaklıklar",
                            Price = 40m,
                            Quantity = 200
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Kulak Üstü Siyah Kulaklıklar - bu kulaklıklar kablosuz değildir",
                            ImageURL = "/Images/Electronic/Electronics3.png",
                            Name = "Kulak üstü Siyah Kulaklık",
                            Price = 40m,
                            Quantity = 300
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Sennheiser Dijital Kamera - Sennheiser tarafından sağlanan yüksek kaliteli dijital kamera - tripod içerir",
                            ImageURL = "/Images/Electronic/Electronic4.png",
                            Name = "Sennheiser Tripodlu Dijital Fotoğraf Makinesi",
                            Price = 600m,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Canon Dijital Kamera - Canon tarafından sağlanan yüksek kaliteli dijital kamera",
                            ImageURL = "/Images/Electronic/Electronic5.png",
                            Name = "Canon Dijital Kamera",
                            Price = 500m,
                            Quantity = 15
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Gameboy - Nintendo tarafından sağlanmıştır",
                            ImageURL = "/Images/Electronic/technology6.png",
                            Name = "Nintendo Gameboy'u",
                            Price = 100m,
                            Quantity = 60
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Çok rahat siyah deri ofis koltuğu",
                            ImageURL = "/Images/Furniture/Furniture1.png",
                            Name = "Siyah Deri Ofis Koltuğu",
                            Price = 50m,
                            Quantity = 212
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Çok rahat pembe deri ofis koltuğu",
                            ImageURL = "/Images/Furniture/Furniture2.png",
                            Name = "Pembe Deri Ofis Koltuğu",
                            Price = 50m,
                            Quantity = 112
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "Çok rahat şezlong",
                            ImageURL = "/Images/Furniture/Furniture3.png",
                            Name = "Şezlong",
                            Price = 70m,
                            Quantity = 90
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "Çok rahat gümüş rengi şezlong",
                            ImageURL = "/Images/Furniture/Furniture4.png",
                            Name = "Gümüş Şezlong",
                            Price = 120m,
                            Quantity = 95
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "Beyaz ve mavi Porselen Masa Lambası",
                            ImageURL = "/Images/Furniture/Furniture6.png",
                            Name = "Porselen Masa Lambası",
                            Price = 15m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "Ofis Masa Lambası",
                            ImageURL = "/Images/Furniture/Furniture7.png",
                            Name = "Ofis Masa Lambası",
                            Price = 20m,
                            Quantity = 73
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Description = "Birçok bedende konforlu Puma Spor Ayakkabı",
                            ImageURL = "/Images/Shoes/Shoes1.png",
                            Name = "Puma Spor Ayakkabı",
                            Price = 100m,
                            Quantity = 50
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "Renkli spor ayakkabıları - çoğu boyutta mevcuttur",
                            ImageURL = "/Images/Shoes/Shoes2.png",
                            Name = "Renkli Spor Ayakkabılar",
                            Price = 150m,
                            Quantity = 60
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Mavi Nike Spor Ayakkabı - Birçok bedende mevcuttur",
                            ImageURL = "/Images/Shoes/Shoes3.png",
                            Name = "Mavi Nike Spor Ayakkabıları",
                            Price = 200m,
                            Quantity = 70
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "Renkli Hummel Spor Ayakkabılar - çoğu bedende mevcuttur",
                            ImageURL = "/Images/Shoes/Shoes4.png",
                            Name = "Renkli Hummel Spor Ayakkabı",
                            Price = 120m,
                            Quantity = 120
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "Kırmızı Nike Spor Ayakkabı - çoğu bedende mevcuttur",
                            ImageURL = "/Images/Shoes/Shoes5.png",
                            Name = "Kırmızı Nike Spor Ayakkabıları",
                            Price = 200m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Description = "Birkenstock Sandaletler - çoğu boyutta mevcuttur",
                            ImageURL = "/Images/Shoes/Shoes6.png",
                            Name = "Birkenstock Sandaletler",
                            Price = 50m,
                            Quantity = 150
                        });
                });

            modelBuilder.Entity("OnlineShoppingApp.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IconCSS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "oi oi-beaker",
                            Name = "Güzellik"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "oi oi-tablet",
                            Name = "Mobilya"
                        },
                        new
                        {
                            Id = 3,
                            IconCSS = "oi oi-calculator",
                            Name = "Elektronik"
                        },
                        new
                        {
                            Id = 4,
                            IconCSS = "oi oi-book",
                            Name = "Ayakkabı"
                        });
                });

            modelBuilder.Entity("OnlineShoppingApp.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Hakan"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Zeynep"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
