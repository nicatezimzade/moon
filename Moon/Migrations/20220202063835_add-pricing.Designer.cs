﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moon.DAL;

namespace Moon.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220202063835_add-pricing")]
    partial class addpricing
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Moon.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ButtonText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("Moon.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogShare1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogShare2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogTag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Moon.Models.Counter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EndNum")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InnerNum")
                        .HasColumnType("int");

                    b.Property<int>("Interval")
                        .HasColumnType("int");

                    b.Property<int>("StartNum")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Counters");
                });

            modelBuilder.Entity("Moon.Models.FeatWrapper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FeatWrapperIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatWrapperImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatWrapperText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatWrapperTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FeatWrappers");
                });

            modelBuilder.Entity("Moon.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FeatIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Moon.Models.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HeroImgSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeroText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeroTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("Moon.Models.Pricing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PBtnText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCapType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PCapacity")
                        .HasColumnType("int");

                    b.Property<string>("PCost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PFeat1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PFeat2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PFeat3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PTag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pricings");
                });
#pragma warning restore 612, 618
        }
    }
}
