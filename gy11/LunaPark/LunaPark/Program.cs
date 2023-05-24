namespace LunaPark
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // kell egy-két céllövölde
            Céllövölde c1 = new ("bejárat melletti");
            Céllövölde c2 = new ("bazársor végi");

            // kell néhány ajándék a céllövöldékbe
            Ajándék a1 = new Labda(c1, S.Instance());
            Ajándék a2 = new Labda(c1, M.Instance());
            Ajándék a3 = new Plüss(c2, XL.Instance());
            Ajándék a4 = new Figura(c2, L.Instance());
            Ajándék a5 = new Figura(c2, L.Instance());

            // kell néhány vendég, akik elmennek lőni

            Vendég v1 = new ("Zsolti");
            Vendég v2 = new ("Karcsi");
            c1.Regisztrál(v1); c1.Regisztrál(v2);
            c2.Regisztrál(v1); c2.Regisztrál(v2);

            // a vendégek nyernek
            v1.Nyer(a1);
            v2.Nyer(a2);
            v1.Nyer(a3);
            v2.Nyer(a4);
            v2.Nyer(a5);

            // megkérdezzük a céllövöldéktõl, hogy ki legjobb vendégük
            Console.WriteLine($"A(z) {c1.Hely} céllövöldében {c1.Legjobb()} volt a legügyesebb vendég.");
            Console.WriteLine($"A(z) {c2.Hely} céllövöldében {c2.Legjobb()} volt a legügyesebb vendég.");
        }
    }
}