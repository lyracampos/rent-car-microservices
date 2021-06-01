using System;
using MongoDB.Driver;
using RentCar.Catalog.Api.Entities;

namespace RentCar.Catalog.Api.Data
{
    public interface ICatalogContext : IDisposable
    {
        IMongoCollection<Product> Products { get; }
    }
}