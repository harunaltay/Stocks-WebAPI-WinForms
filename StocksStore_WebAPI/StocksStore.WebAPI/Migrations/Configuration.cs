using StocksStore.WebAPI.Models;

namespace StocksStore.WebAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StocksStore.WebAPI.Models.StocksDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(StocksStore.WebAPI.Models.StocksDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Categories.AddOrUpdate(
                c => c.CategoryName,
                new Category { CategoryID = 1, CategoryName = "Bilgisayar Masaüstü" },
                new Category { CategoryID = 2, CategoryName = "Bilgisayar Dizüstü" },
                new Category { CategoryID = 3, CategoryName = "Bilgisayar Çevrebirim" },
                new Category { CategoryID = 4, CategoryName = "Cep Telefonu" },
                new Category { CategoryID = 5, CategoryName = "Televizyon" }
            );

            context.Suppliers.AddOrUpdate(
                s => s.SupplierName,
                new Supplier { SupplierID = 1, SupplierName = "TeknoSa", SupplierPhone = "111", SupplierWebPage = "www.TeknoSa.com" },
                new Supplier { SupplierID = 2, SupplierName = "MediaMarkt", SupplierPhone = "222", SupplierWebPage = "www.MediaMarkt.com" },
                new Supplier { SupplierID = 3, SupplierName = "Vatan", SupplierPhone = "333", SupplierWebPage = "www.Vatan.com" },
                new Supplier { SupplierID = 4, SupplierName = "Casper", SupplierPhone = "444", SupplierWebPage = "www.Casper.com" },
                new Supplier { SupplierID = 5, SupplierName = "Monster", SupplierPhone = "555", SupplierWebPage = "www.Monster.com" }
            );

            //context.Products.AddOrUpdate(
            //    new Product { ProductID = 1, ProductName = "iPhone 10", CategoryID = 4, SupplierID = 1, UnitPrice = 1200 },
            //    new Product { ProductID = 1, ProductName = "Galaxy S10+", CategoryID = 4, SupplierID = 2, UnitPrice = 900 },
            //    new Product { ProductID = 1, ProductName = "HP X100", CategoryID = 1, SupplierID = 3, UnitPrice = 800 },
            //    new Product { ProductID = 1, ProductName = "Logitech H140", CategoryID = 3, SupplierID = 4, UnitPrice = 75 },
            //    new Product { ProductID = 1, ProductName = "Monster Pro 120", CategoryID = 2, SupplierID = 5, UnitPrice = 1100 }
            //    );
        }
    }
}