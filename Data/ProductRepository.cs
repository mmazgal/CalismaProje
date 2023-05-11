
using CalismaProje.Models;

namespace CalismaProje.Data 
{
    public class ProductRepository
    {
        private static List<Product>? _products =null;
        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product {ProductId=1, Name="Iphone 5", Price=5000, Description="Telefon", ImageUrl="~/img/robotik.jpg"},
                new Product {ProductId=2, Name="Iphone 5S", Price=6000, Description="Telefon", ImageUrl="~/img/robotik.jpg"},
                new Product {ProductId=3, Name="Iphone S3", Price=2300, Description="Telefon", ImageUrl="~/img/robotik.jpg"},
                new Product {ProductId=4, Name="Casper Nirvana", Price=12000, Description="Bilgisayar", ImageUrl="~/img/robotik.jpg"},
                new Product {ProductId=5, Name="Macbook Pro 2", Price=25000, Description="Bilgisayar", ImageUrl="~/img/robotik.jpg"}
            };
        }
        public static List<Product>? Products
        {
            get
            {
                return _products;
            }
        }
        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p=>p.ProductId==id);
        }
    }
}