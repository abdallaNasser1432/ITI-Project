using System.Collections.Generic;

namespace FirstLoook.Models
{
    public static class ProductSampleData
    {
        public static List<Product> ProductList { get; set; }
        = new List<Product>();
        static ProductSampleData()
        {
            ProductList.Add(new Product() { Id = 1, Name = "Iphone1", Quantity = 10, Price = 30000, Image = "1.jpg" });
            ProductList.Add(new Product() { Id = 2, Name = "Iphone2", Quantity = 20, Price = 40000, Image = "2.jpg" });
            ProductList.Add(new Product() { Id = 3, Name = "Iphone3", Quantity = 30, Price = 50000, Image = "3.jpg" });
            ProductList.Add(new Product() { Id = 4, Name = "Iphone4", Quantity = 40, Price = 60000, Image = "1.jpg" });
            ProductList.Add(new Product() { Id = 5, Name = "Iphone5", Quantity = 50, Price = 30000, Image = "2.jpg" });
        }
    }
}
