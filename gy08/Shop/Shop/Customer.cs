using TextFile;

namespace Shop
{
    public class Customer
    {
        List<String> BevLista;
        List<Product> Kosar;
        public String name;

        public Customer(string input)
        {
            Kosar = new List<Product>();    
            TextFileReader reader = new TextFileReader(input);
            BevLista = new List<String>();
            name = reader.ReadLine();
            while (reader.ReadString(out string nev))
            {
                BevLista.Add(nev);
            }
        }

        public void Shop(Shop store)
        {
            Console.WriteLine($"{this.name} vásárló megvette az alábbi árukat");
            foreach (String nev in BevLista)
            {
                if (LinSearch(out Product? product, store.food, nev))
                    Buy(product!, store.food);
            }
            foreach (String  nev in BevLista)
            {
                if(ConditionalMin(out Product? product, store.tech, nev))
                    Buy(product!, store.tech);
            }
        }

        private void Buy (Product product, Department department)
        {
            Kosar.Add(product);
            department.Stock.Remove(product);
            Console.WriteLine($"{product.Name} {product.Price}");
        }

        private bool LinSearch(out Product? product, Department department, string nev)
        {
            foreach (Product p in department.Stock)
            {
                if (p.Name == nev)
                {
                    product = p;
                    return true;
                }
            }
            product = null;
            return false;
        }

        private bool ConditionalMin(out Product? product, Department department, string nev)
        {
            product = null;
            bool l = false;
            foreach(Product p in department.Stock)
            {
                if (p.Name != nev) continue;
                if (!l)
                {
                    l = true;
                    product = p;
                }
                else
                {
                    if (p.Price < product!.Price)
                    {
                        product = p;
                    }
                }
            }
            return l;
        }
    }
}
