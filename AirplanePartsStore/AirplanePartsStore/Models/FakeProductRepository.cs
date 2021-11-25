using System.Collections.Generic;
using System.Linq;

namespace AirplanePartsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {

        public IQueryable<Product> Products => new List<Product> {
            new Product { Name = "Helmet", Price = 25 },
            new Product { Name = "Glide Skid", Price = 179 },
            new Product { Name = "Work Boots", Price = 95 }
        }.AsQueryable<Product>();
    }
   
}
