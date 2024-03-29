﻿//Demo 6 - Authentication Basics; LV
// This and the classes - Product.cs, SubCategory.cs, Category.cs, LoginInfo.cs, TblOrder.cs, TblOrderDetail.cs - were auto-generated by running the following command at the Package Manager Console prompt.
// Scaffold-Dbcontext "Server=buscissql1601\cisweb;Database=TaraStore;User ID=csu;Password=rams;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Tables Product,SubCategory,Category,tblOrder,tblOrderDetail,LoginInfo

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Demo6.Models
{
    public partial class TaraStoreContext : DbContext
    {
        public TaraStoreContext()
        {
        }

        public TaraStoreContext(DbContextOptions<TaraStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<LoginInfo> LoginInfo { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<TblOrder> TblOrder { get; set; }
        public virtual DbSet<TblOrderDetail> TblOrderDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.

//                this connnection string information has been moved

//                optionsBuilder.UseSqlServer("Server=buscissql1601\\cisweb;Database=TaraStore;User ID=csu;Password=rams;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryPk)
                    .HasName("PK_Categories");

                entity.Property(e => e.CategoryPk).HasColumnName("CategoryPK");

                entity.Property(e => e.CategoryImage)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Thumbnail).HasMaxLength(50);

                entity.Property(e => e.TinyThumb).HasMaxLength(50);
            });

            modelBuilder.Entity<LoginInfo>(entity =>
            {
                entity.HasKey(e => e.UserPk);

                entity.Property(e => e.UserPk).HasColumnName("UserPK");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserRoles)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductPk)
                    .HasName("PK_Products");

                entity.Property(e => e.ProductPk).HasColumnName("ProductPK");

                entity.Property(e => e.Availability).HasMaxLength(50);

                entity.Property(e => e.CategoryFk).HasColumnName("CategoryFK");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.ModelName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModelNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProductImage).HasMaxLength(50);

                entity.Property(e => e.SubCategoryFk).HasColumnName("SubCategoryFK");

                entity.Property(e => e.Thumbnail).HasMaxLength(50);

                entity.Property(e => e.UnitCost).HasColumnType("money");

                entity.HasOne(d => d.CategoryFkNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Category");

                entity.HasOne(d => d.SubCategoryFkNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.SubCategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_SubCategory");
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasKey(e => e.SubCategoryPk)
                    .HasName("PK_SubCategories");

                entity.Property(e => e.SubCategoryPk).HasColumnName("SubCategoryPK");

                entity.Property(e => e.CategoryFk).HasColumnName("CategoryFK");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.SubCategoryImage).HasMaxLength(50);

                entity.Property(e => e.SubCategoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Thumbnail).HasMaxLength(50);

                entity.HasOne(d => d.CategoryFkNavigation)
                    .WithMany(p => p.SubCategory)
                    .HasForeignKey(d => d.CategoryFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCategory_Category");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.HasKey(e => e.OrderPk);

                entity.ToTable("tblOrder");

                entity.Property(e => e.OrderPk).HasColumnName("OrderPK");

                entity.Property(e => e.CustomerFk).HasColumnName("CustomerFK");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.HasOne(d => d.CustomerFkNavigation)
                    .WithMany(p => p.TblOrder)
                    .HasForeignKey(d => d.CustomerFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrder_LoginInfo");
            });

            modelBuilder.Entity<TblOrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailPk);

                entity.ToTable("tblOrderDetail");

                entity.Property(e => e.OrderDetailPk).HasColumnName("OrderDetailPK");

                entity.Property(e => e.OrderFk).HasColumnName("OrderFK");

                entity.Property(e => e.ProductFk).HasColumnName("ProductFK");

                entity.HasOne(d => d.OrderFkNavigation)
                    .WithMany(p => p.TblOrderDetail)
                    .HasForeignKey(d => d.OrderFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrderDetail_tblOrder");

                entity.HasOne(d => d.ProductFkNavigation)
                    .WithMany(p => p.TblOrderDetail)
                    .HasForeignKey(d => d.ProductFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOrderDetail_Product");
            });
        }
    }
}
