﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopVitrin.Models;

#nullable disable

namespace ShopVitrin.Migrations
{
    [DbContext(typeof(UrunContext))]
    [Migration("20230422075846_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShopVitrin.Models.Urun", b =>
                {
                    b.Property<int>("UrunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UrunId"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UrunId");

                    b.ToTable("Urunler");

                    b.HasData(
                        new
                        {
                            UrunId = 1,
                            Aciklama = "Donate: If yose conp pay for theour support.",
                            Isim = "Erkek Beyaz Pantolon",
                            Resim = "Picture/erkek_beyaz_pantolon.png"
                        },
                        new
                        {
                            UrunId = 2,
                            Aciklama = "ciated - click here to donate using PayPal. Thank you for your support.",
                            Isim = "Erkek Gri Ayakkabı",
                            Resim = "Picture/erkek_gri_ayakkabı.png"
                        },
                        new
                        {
                            UrunId = 3,
                            Aciklama = "Donate: If you use this siting PayPal. Thank you for your support.",
                            Isim = "Erkek Gri Pantolon",
                            Resim = "Picture/erkek_gri_pantolon.png"
                        },
                        new
                        {
                            UrunId = 4,
                            Aciklama = "Donat. Thank you for your support.",
                            Isim = "Erkek Kareli Pantolon",
                            Resim = "Picture/erkek_kareli_pantolon.png"
                        },
                        new
                        {
                            UrunId = 5,
                            Aciklama = "o donate using PayPal. Thank you for your support.",
                            Isim = "Erkek Mavi Hırka",
                            Resim = "Picture//erkek_mavi_hırka.png"
                        },
                        new
                        {
                            UrunId = 6,
                            Aciklama = "Donate: If yated - click here toyour support.",
                            Isim = "Erkek Tsirt",
                            Resim = "Picture/erkek_tsirt.png"
                        },
                        new
                        {
                            UrunId = 7,
                            Aciklama = "Donate: If yu for your support.",
                            Isim = "Erkek Tsirt Kırmızı",
                            Resim = "Picture/erkek_tsirt_kırmızı.png"
                        },
                        new
                        {
                            UrunId = 8,
                            Aciklama = "Do. Thank you for your support.",
                            Isim = "Kadın Çanta Takım",
                            Resim = "Picture/kadın_çanta_takım.png"
                        },
                        new
                        {
                            UrunId = 9,
                            Aciklama = "Donate: If you use this site regular pport.",
                            Isim = "Kadın Kot Pantolon",
                            Resim = "Picture/kadın_kot_pantolon.png"
                        },
                        new
                        {
                            UrunId = 10,
                            Aciklama = "Donate: click here to donate using PayPal. Thank you for your support.",
                            Isim = "Kadın Kot Siyah",
                            Resim = "Picture/kadın_kot_siyah.png"
                        },
                        new
                        {
                            UrunId = 11,
                            Aciklama = "Dona your support.",
                            Isim = "Kadın Turuncu Hırka",
                            Resim = "Picture/kadın_turuncu_hırka.png"
                        },
                        new
                        {
                            UrunId = 12,
                            Aciklama = "Donate:  hany sum is appreciated - click here to donate using PayPal. Thank you for your support.",
                            Isim = "Kulaklık",
                            Resim = "Picture/kulaklık.png"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}