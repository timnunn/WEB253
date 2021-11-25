using System.Linq;

namespace AirplanePartsStore.Models
{
    public class IProductRepository
    {
        public IQueryable<Product> Products { get; }
    }
}
