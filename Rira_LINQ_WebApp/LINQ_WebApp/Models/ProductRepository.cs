using LINQ_WebApp.Models.Entities;

namespace LINQ_WebApp.Models
{
    public class ProductRepository
    {
        private static ProductRepository repo = new ProductRepository();
        public static ProductRepository Current { get { return repo; } }
        private List<Product> products = new List<Product>
        {
            new Product{Id = 1, Name="Product A",Category="Category 1",Price= 100 },
            new Product{Id = 2, Name="Product B",Category="Category 2",Price= 150 },
            new Product{Id = 3, Name="Product C",Category="Category 1",Price= 120 },
            new Product{Id = 4, Name="Product D",Category="Category 3",Price= 200 },
            new Product{Id = 5, Name="Product E",Category="Category 2",Price= 80 },
        };
        public IEnumerable<Product> GetAll()
        {
            return products;
        }
    }
}
