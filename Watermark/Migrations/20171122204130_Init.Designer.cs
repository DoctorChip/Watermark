﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Watermark.Models;
using Watermark.Models.Products;
using Watermark.Models.Products.Contracts;
using Watermark.Repository;

namespace Watermark.Migrations
{
    [DbContext(typeof(WatermarkDbContext))]
    [Migration("20171122204130_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Watermark.Models.Lifetime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("End");

                    b.Property<DateTime?>("Start");

                    b.HasKey("Id");

                    b.ToTable("Lifetime");
                });

            modelBuilder.Entity("Watermark.Models.PriceDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<bool>("IncludesTax");

                    b.Property<int?>("TaxRateId");

                    b.HasKey("Id");

                    b.HasIndex("TaxRateId");

                    b.ToTable("PriceDetail");
                });

            modelBuilder.Entity("Watermark.Models.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int?>("LifetimeId");

                    b.Property<int?>("PriceInformationId");

                    b.Property<int?>("ProductNameId");

                    b.Property<int?>("ProductSKUId");

                    b.Property<int>("ProductType");

                    b.Property<int?>("SearchEngineOptimisationOptionsId");

                    b.Property<int?>("StockLevelsId");

                    b.Property<int?>("TemplateId");

                    b.Property<bool>("TemporaryWithLifetime");

                    b.HasKey("Id");

                    b.HasIndex("LifetimeId");

                    b.HasIndex("PriceInformationId");

                    b.HasIndex("ProductNameId");

                    b.HasIndex("ProductSKUId");

                    b.HasIndex("SearchEngineOptimisationOptionsId");

                    b.HasIndex("StockLevelsId");

                    b.HasIndex("TemplateId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("ProductId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductAttribute");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("ParentId");

                    b.Property<int?>("ProductCategoryId");

                    b.Property<int?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Name");

                    b.Property<int?>("ProductId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductConfiguration");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductDeliveryOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDeliveryOption");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<int>("Language");

                    b.Property<int?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDescription");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MediaType");

                    b.Property<bool>("PrimaryMedia");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductMedia");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName");

                    b.HasKey("Id");

                    b.ToTable("ProductName");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductPricing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BasePriceId");

                    b.Property<int?>("SpecialPriceId");

                    b.HasKey("Id");

                    b.HasIndex("BasePriceId");

                    b.HasIndex("SpecialPriceId");

                    b.ToTable("ProductPricing");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<int>("ProductId");

                    b.Property<int>("Rating");

                    b.Property<int>("ReviewerId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductReview");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductSearchEngineOptimisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("ProductSearchEngineOptimisation");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductSettingOverride", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductId");

                    b.Property<string>("Setting");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductSettingOverride");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductSKU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SKU");

                    b.HasKey("Id");

                    b.ToTable("ProductSKU");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductStockLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("LowStockNotification");

                    b.Property<int>("LowStockThreshold");

                    b.Property<int>("MaxCountInCart");

                    b.Property<int>("NotifyAtStockLevel");

                    b.Property<int>("OutOfStockThreshold");

                    b.Property<int>("StockLevel");

                    b.HasKey("Id");

                    b.ToTable("ProductStockLevel");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("ProductTemplate");
                });

            modelBuilder.Entity("Watermark.Models.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("Watermark.Models.TaxRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("WholeNumberTaxRate");

                    b.HasKey("Id");

                    b.ToTable("TaxRate");
                });

            modelBuilder.Entity("Watermark.Models.PriceDetail", b =>
                {
                    b.HasOne("Watermark.Models.TaxRate", "TaxRate")
                        .WithMany()
                        .HasForeignKey("TaxRateId");
                });

            modelBuilder.Entity("Watermark.Models.Products.Product", b =>
                {
                    b.HasOne("Watermark.Models.Lifetime", "Lifetime")
                        .WithMany()
                        .HasForeignKey("LifetimeId");

                    b.HasOne("Watermark.Models.Products.ProductPricing", "PriceInformation")
                        .WithMany()
                        .HasForeignKey("PriceInformationId");

                    b.HasOne("Watermark.Models.Products.ProductName", "ProductName")
                        .WithMany()
                        .HasForeignKey("ProductNameId");

                    b.HasOne("Watermark.Models.Products.ProductSKU", "ProductSKU")
                        .WithMany()
                        .HasForeignKey("ProductSKUId");

                    b.HasOne("Watermark.Models.Products.ProductSearchEngineOptimisation", "SearchEngineOptimisationOptions")
                        .WithMany()
                        .HasForeignKey("SearchEngineOptimisationOptionsId");

                    b.HasOne("Watermark.Models.Products.ProductStockLevel", "StockLevels")
                        .WithMany()
                        .HasForeignKey("StockLevelsId");

                    b.HasOne("Watermark.Models.Products.ProductTemplate", "Template")
                        .WithMany()
                        .HasForeignKey("TemplateId");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductAttribute", b =>
                {
                    b.HasOne("Watermark.Models.Products.Product")
                        .WithMany("ProductAttributes")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductCategory", b =>
                {
                    b.HasOne("Watermark.Models.Products.ProductCategory")
                        .WithMany("Children")
                        .HasForeignKey("ProductCategoryId");

                    b.HasOne("Watermark.Models.Products.Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductConfiguration", b =>
                {
                    b.HasOne("Watermark.Models.Products.Product")
                        .WithMany("Configurations")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductDeliveryOption", b =>
                {
                    b.HasOne("Watermark.Models.Products.Product")
                        .WithMany("DeliveryOptions")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductDescription", b =>
                {
                    b.HasOne("Watermark.Models.Products.Product")
                        .WithMany("Descriptions")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductMedia", b =>
                {
                    b.HasOne("Watermark.Models.Products.Product")
                        .WithMany("ProductMedia")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductPricing", b =>
                {
                    b.HasOne("Watermark.Models.PriceDetail", "BasePrice")
                        .WithMany()
                        .HasForeignKey("BasePriceId");

                    b.HasOne("Watermark.Models.PriceDetail", "SpecialPrice")
                        .WithMany()
                        .HasForeignKey("SpecialPriceId");
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductReview", b =>
                {
                    b.HasOne("Watermark.Models.Products.Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Watermark.Models.Products.ProductSettingOverride", b =>
                {
                    b.HasOne("Watermark.Models.Products.Product")
                        .WithMany("SettingOverrides")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Watermark.Models.Site", b =>
                {
                    b.HasOne("Watermark.Models.Products.Product")
                        .WithMany("Sites")
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
