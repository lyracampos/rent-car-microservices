using System.Collections.Generic;
using MongoDB.Driver;
using RentCar.Catalog.Api.Entities;

namespace RentCar.Catalog.Api.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(ConfigureProducts());
            }
        }

        private static IEnumerable<Product> ConfigureProducts()
        {
            return new List<Product> 
            {
                new Product(new Category("Basic", "carros básicos"), null)
            };
        }
    }
}