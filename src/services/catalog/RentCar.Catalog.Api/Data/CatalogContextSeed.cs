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
                new Product(
                    new Category("Econômico", "Carros com motor 1.0. Ideais para uso no dia-a-dia."),
                    new List<Car>
                    {
                        new Car("Uno", "Fiat", 4, "1.0", true, false),
                        new Car("Onix", "Chevrolet", 5, "1.0", true, false),
                        new Car("HB20", "Hyundai", 5, "1.0", true, false),
                        new Car("Gol", "Volkswagen", 5, "1.0", true, false),
                    }),
                 new Product(
                    new Category("Standard", "Ideais para passeio com família e pequenas viagens."),
                    new List<Car>
                    {
                        new Car("Cronos", "Fiat", 5, "1.3", true, true),
                        new Car("Cruze", "Chevrolet", 5, "1.6", true, true),
                        new Car("Voyage", "Volkswagen", 5, "1.0", true, false),
                    }),
                new Product(
                    new Category("Utilitários", "Carros utilitários para carreto."),
                    new List<Car>
                    {
                        new Car("Fiorino", "Fiat", 2, "1.0", false, false),
                        new Car("Kangoo", "Renault", 2, "1.3", true, false)
                    }),
                new Product(
                    new Category("SUV", "Carros para família e amigos. ideal para viagens com bastante mala."),
                    new List<Car>
                    {
                        new Car("Duster", "Renault", 5, "1.6", true, true),
                        new Car("T-Cross", "Volkswagen", 5, "1.6", true, true),
                        new Car("Compass", "Jeep", 7, "1.6", true, true),
                    }),
                new Product(
                    new Category("Luxo", "Carros importados para ocasiões especiais."),
                    new List<Car>
                    {
                        new Car("C180", "Mercedes-Benz", 5, "2.5", true, true),
                        new Car("A3 Sedan", "Audi", 4, "2.5", true, true)
                    })
            };
        }
    }
}