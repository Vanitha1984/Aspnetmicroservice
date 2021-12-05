using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catalog.API.Entities;
using MongoDB.Driver;

namespace catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "Hyundai I30",
                    Summary = "The Hyundai i30 is a small family car manufactured by the South Korean manufacturer Hyundai Motor Company ",
                    Description = "Hyundai I30",
                    ImageFile = "product-1.png",
                    Price = 200000,
                    Category = "CAR"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "AUDI",
                    Summary = "Audi AG is a German automotive manufacturer of luxury vehicles headquartered in Ingolstadt, Bavaria, Germany.",
                    Description = "Audi A3",
                    ImageFile = "product-2.png",
                    Price = 500000,
                    Category = "CAR"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Peugeot J9",
                    Summary = "The Peugeot J9 is a van manufactured by Peugeot from January 1981 until 1991. It was also manufactured under license by Karsan",
                    Description = "The Peugeot J9 is a van manufactured by Peugeot from January 1981 until 1991. It was also manufactured under license by Karsan",
                    Price = 500000,
                    Category = "Food Truck"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "Peugeot J9",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "product-4.png",
                    Price = 470.00M,
                    Category = "Food Truck"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "Citreon Hy",
                    Summary = "This phone is the company's biggest change to its flagship smartphone in years. It includes a borderless.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus. Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ut, tenetur natus doloremque laborum quos iste ipsum rerum obcaecati impedit odit illo dolorum ab tempora nihil dicta earum fugiat. Temporibus, voluptatibus.",
                    ImageFile = "product-5.png",
                    Price = 380.00M,
                    Category = "Food truck"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47fa",
                    Name = "HYMER Camper Vans",
                    Summary = "Fiat er grænseløst fleksible multikunstnere, der egner sig både til den daglige bykørsel og til ture rundt i landskabet.",
                    Description = "Fiat er grænseløst fleksible multikunstnere, der egner sig både til den daglige bykørsel og til ture rundt i landskabet",
                    ImageFile = "product-6.png",
                    Price = 300000,
                    Category = "Camper Van"
                }
            };
        }
    }
}
