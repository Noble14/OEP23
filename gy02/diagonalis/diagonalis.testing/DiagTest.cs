namespace diagonalis.testing
{
    [TestClass]
    public class DiagTest
    {
        [TestMethod]
        public void DiagonalAddTest()
        {
            Diagonal d1 = new Diagonal(new List<double> { 1, 2, 3 });
            Diagonal d2 = new Diagonal(new List<double> { 4, 5, 6 });

            Diagonal d3 = d1 + d2;

            Assert.AreEqual(5, d3[0, 0]);
            Assert.AreEqual(7, d3[1, 1]);
            Assert.AreEqual(9, d3[2, 2]);

            Diagonal d4 = new Diagonal(4);

            Assert.ThrowsException<Diagonal.WrgonDimensionException>(() => d3 + d4);
        }
    }
}