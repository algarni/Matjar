namespace Matjar.DataContexts.MatjarMigrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Matjar.DataContexts.MatjarDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContexts\MatjarMigrations";
        }

        protected override void Seed(Matjar.DataContexts.MatjarDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var category1 = new Category { CategoryName = "Tea Glasses" };
            context.Categories.AddOrUpdate(
                c => c.CategoryName,
                category1
                );

            // product 1
            var product1 = new Product
            {
                ProductName = "Multiple Color with Gold Motif Tea Glasses TG011",
                Price = 10.00m,
            };

            product1.Images.Add(new Image
            {
                ImageName = "3c22e6c1-044a-4d39-8029-c1b735cf7528.jpg",
                ImageDescription = "Multiple Color with Gold Motif Tea Glasses TG011"
            });

            product1.Category = category1;

            // product 2
            var product2 = new Product
            {
                ProductName = "Orange with Gold Motif Tea Glasses TG001",
                Price = 10.00m,
            };

            product2.Images.Add(new Image
            {
                ImageName = "e993c9d9-f564-414b-bd74-b863c1d5f74c.jpg",
                ImageDescription = "Orange with Gold Motif Tea Glasses TG001"
            });

            product2.Category = category1;

            // product 3
            var product3 = new Product
            {
                ProductName = "Green with Gold Floral Motif Tea Glasses – TG003",
                Price = 10.00m,
            };

            product3.Images.Add(new Image
            {
                ImageName = "797f0df6-753a-44ba-a211-9e04a714f8dd.jpg",
                ImageDescription = "Green with Gold Floral Motif Tea Glasses – TG003"
            });

            product3.Category = category1;

            // product 4
            var product4 = new Product
            {
                ProductName = "Multi Color Tea Glasses TG004",
                Price = 10.00m,
            };

            product4.Images.Add(new Image
            {
                ImageName = "9b0f41f7-fbf7-4931-bb27-a70363c7efcb.jpg",
                ImageDescription = "Multi Color Tea Glasses TG004"
            });

            product4.Category = category1;

            // product 5
            var product5 = new Product
            {
                ProductName = "Red with Gold Motif Tea Glasses – TG006",
                Price = 10.00m,
            };

            product5.Images.Add(new Image
            {
                ImageName = "7fc864c8-4bf2-4b09-86a9-2b211e6115e9.jpg",
                ImageDescription = "Red with Gold Motif Tea Glasses – TG006"
            });

            product5.Category = category1;

            // product 6
            var product6 = new Product
            {
                ProductName = "Multiple Color with Gold Motif Tea Glasses – TG007",
                Price = 10.00m,
            };

            product6.Images.Add(new Image
            {
                ImageName = "a8ff7375-c790-49b0-8b06-679d929b0a95.jpg",
                ImageDescription = "Multiple Color with Gold Motif Tea Glasses – TG007"
            });

            product6.Category = category1;

            // product 7
            var product7 = new Product
            {
                ProductName = "Silver Motif with White Frosted Tea Glasses TG016",
                Price = 10.00m,
            };

            product7.Images.Add(new Image
            {
                ImageName = "bb13656e-b0ba-4f06-90f0-4921d579925c.jpg",
                ImageDescription = "Silver Motif with White Frosted Tea Glasses TG016"
            });

            product7.Category = category1;

            // product 8
            var product8 = new Product
            {
                ProductName = "Pink with Gold Motif Tea Glasses TG017",
                Price = 10.00m,
            };

            product8.Images.Add(new Image
            {
                ImageName = "e56c8ef2-1b2e-41fb-8a64-e44e079646dc.jpg",
                ImageDescription = "Pink with Gold Motif Tea Glasses TG017"
            });

            product8.Category = category1;

            // product 9
            var product9 = new Product
            {
                ProductName = "Gold Floral Motif Blue Colored Tea Glasses TG030",
                Price = 10.00m,
            };

            product9.Images.Add(new Image
            {
                ImageName = "ceb35940-e670-4afd-bea6-3e69b237dda7.jpg",
                ImageDescription = "Gold Floral Motif Blue Colored Tea Glasses TG030"
            });

            product9.Category = category1;

            // product 10
            var product10 = new Product
            {
                ProductName = "Black Floral Motif Multiple Colored Tea Glasses TG036",
                Price = 10.00m,
            };

            product10.Images.Add(new Image
            {
                ImageName = "ff611c4d-2af1-40af-bed4-91544243159e.jpg",
                ImageDescription = "Black Floral Motif Multiple Colored Tea Glasses TG036"
            });

            product10.Category = category1;

            // product 11
            var product11 = new Product
            {
                ProductName = "Red Tea Glasses with Gold Floral Motif – TG037",
                Price = 10.00m,
            };

            product11.Images.Add(new Image
            {
                ImageName = "d3138fbb-e7fb-408b-b1e2-90d63fa0a448.jpg",
                ImageDescription = "Red Tea Glasses with Gold Floral Motif – TG037"
            });

            product11.Category = category1;

            // product 12
            var product12 = new Product
            {
                ProductName = "Blue Tea Glasses with Gold Floral Motif – TG038",
                Price = 10.00m,
            };

            product12.Images.Add(new Image
            {
                ImageName = "dee6e241-0c38-4af8-b752-142fbcb588d1.jpg",
                ImageDescription = "Blue Tea Glasses with Gold Floral Motif – TG038"
            });

            product12.Category = category1;

            // product 13
            var product13 = new Product
            {
                ProductName = "Green Tea Glasses with Gold Floral Motif – TG039",
                Price = 10.00m,
            };

            product13.Images.Add(new Image
            {
                ImageName = "8fd71d65-22af-43cd-b45c-07eb6a895540.jpg",
                ImageDescription = "Green Tea Glasses with Gold Floral Motif – TG039"
            });

            product13.Category = category1;

            // product 14
            var product14 = new Product
            {
                ProductName = "Pink Tea Glasses with Gold Floral Motif – TG041",
                Price = 10.00m,
            };

            product14.Images.Add(new Image
            {
                ImageName = "e4a09989-ce65-4472-ad65-f9233670dfdf.jpg",
                ImageDescription = "Pink Tea Glasses with Gold Floral Motif – TG041"
            });

            product14.Category = category1;

            // product 15
            var product15 = new Product
            {
                ProductName = "Orange Tea Glasses with Gold Floral Motif – TG040",
                Price = 10.00m,
            };

            product15.Images.Add(new Image
            {
                ImageName = "d581f5fb-5341-4ffd-a831-c32faa7915e1.jpg",
                ImageDescription = "Orange Tea Glasses with Gold Floral Motif – TG040"
            });

            product15.Category = category1;

            // product 16
            var product16 = new Product
            {
                ProductName = "Clear Tea Glasses with Silver Motif Design – TG042",
                Price = 10.00m,
            };

            product16.Images.Add(new Image
            {
                ImageName = "a99fe0a8-579f-4e3d-83fa-bfca23d91288,jpg",
                ImageDescription = "Clear Tea Glasses with Silver Motif Design – TG042"
            });

            product16.Category = category1;

            // product 17
            var product17 = new Product
            {
                ProductName = "Clear Tea Glasses with Bronze Color Rim – TG043",
                Price = 10.00m,
            };

            product17.Images.Add(new Image
            {
                ImageName = "d5b037d4-0687-42fb-bc97-7674fdcf90d3.jpg",
                ImageDescription = "Clear Tea Glasses with Bronze Color Rim – TG043"
            });

            product17.Category = category1;

            // product 18
            var product18 = new Product
            {
                ProductName = "Multi Color Frosted Tea Glasses – TG045",
                Price = 10.00m,
            };

            product18.Images.Add(new Image
            {
                ImageName = "b95f29c2-a6a3-4863-9e38-c98c844e67d2.jpg",
                ImageDescription = "Multi Color Frosted Tea Glasses – TG045"
            });

            product18.Category = category1;

            // product 19
            var product19 = new Product
            {
                ProductName = "Gold Motif Tea Glasses TG008",
                Price = 10.00m,
            };

            product19.Images.Add(new Image
            {
                ImageName = "eac2aaf9-7e10-402b-b7dc-3ef3df92a064.jpg",
                ImageDescription = "Gold Motif Tea Glasses TG008"
            });

            product19.Category = category1;

            context.Products.AddOrUpdate(
                p => new { p.ProductName, p.Price }, product1, product2, product3, product4, product5, product6, product7, product8, product9, product10, product11, product12, product13, product14, product15, product16, product17, product18, product19);

        }
    }
}
