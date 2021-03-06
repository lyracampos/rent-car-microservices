using System;
using System.Collections.Generic;

namespace RentCar.Catalog.Api.Entities
{
    public class Product
    {
        public Product(Category category, ICollection<Car> cars)
        {
            Category = category;
            Cars = cars;
        }

        public Guid Id { get; private set; }
        public Category Category { get; private set; }
        public ICollection<Car> Cars { get; private set; }
    }
}