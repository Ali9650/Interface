
namespace Product
{
    internal class Product
    {
        public string Name { get; set;}
        public decimal Price { get; set; }
        public ProductType Type { get; set; }

        private Product[] products;
        public Product[] Products { get => products;}
        public Product()
        {
            products= new Product[0];
        }

        public void GetAllProductsByType (ProductType type)
        {
            foreach (var product in products)
            {
                if (product.Type == type)
                    product.GetDetails();
            }
        }

        public void AddProduct (Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }


     
        public void GetDetails()
        {
            Console.WriteLine($"{Name} {Price}");
        }
    }
}
