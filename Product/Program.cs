namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Product product = new Product();
            product.AddProduct(new Product
            {
                Name = "Laptop",
                Price = 1050m,
                Type = ProductType.Electronics
            });

            product.GetAllProductsByType(ProductType.Electronics);

        }
    }
}
