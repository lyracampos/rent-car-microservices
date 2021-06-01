using Microsoft.Extensions.Options;
using MongoDB.Driver;
using RentCar.Catalog.Api.Entities;
using RentCar.Catalog.Api.Settings;

namespace RentCar.Catalog.Api.Data
{
    public class CatalogContext : ICatalogContext
    {
        private IMongoDatabase mongoDatabase;

        public CatalogContext(IOptions<DatabaseSettings> options)
        { 
            var client = new MongoClient(options.Value.ConnectionString);
            mongoDatabase = client.GetDatabase(options.Value.DatabaseName);
        }
        public IMongoCollection<Product> Products 
        {
            get
            {
                return mongoDatabase.GetCollection<Product>
                    (nameof(Product));
            }
        }

        private bool disposedValue = false;

        public void Dispose()
        {
            Dispose(true);
        }

        /// <inheritdoc/>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                //mongoDatabase = null;
                disposedValue = true;
            }
        }
    }
}