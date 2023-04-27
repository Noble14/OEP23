using TextFile;

namespace Shop
{
    public class Department
    {
        public List<Product> Stock { get; private set; }

        public Department(string inputfile)
        {
            TextFileReader reader = new TextFileReader(inputfile);
            Stock = new List<Product>();
            while (Product.ReadProduct(out Product? product, reader))
            {
                if (product != null)
                    Stock.Add(product);
            }
        }
    }

}
