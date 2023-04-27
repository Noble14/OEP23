using TextFile;

namespace Shop
{
    public class Product
    {

        public int Price { get; private set; }

        public string Name { get; private set; }

        public Product(int price, string name)
        {
            this.Price = price;
            this.Name = name;
        }



        public static bool ReadProduct(out Product? product, TextFileReader reader)
        {
            product = null;
            bool l = reader.ReadString(out string nev) & reader.ReadInt(out int price);
            if (l)
            {
                product = new Product(price, nev);
            }
            return l;
        }
    }
}
