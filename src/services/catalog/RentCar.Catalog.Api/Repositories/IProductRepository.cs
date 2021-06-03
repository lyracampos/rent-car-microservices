using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RentCar.Catalog.Api.Entities;

namespace RentCar.Catalog.Api.Repositories
{
    public interface IProductRepository : IDisposable
    {
        Task<IEnumerable<Product>> Get();
        Task<Product> Get(Guid id);
        Task<Product> Get(string slug);
    }
}