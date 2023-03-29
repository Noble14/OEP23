namespace PrQueue.Test
{
    [TestClass]
    public class prqueuetests
    {
        [TestMethod]
        public void AddTest()
        {
            PrQueue p = new PrQueue();
            Assert.IsTrue(p.IsEmpty());
            p.Add(new Element(10,"Hello"));
            Assert.IsFalse(p.IsEmpty());
            p.SetEmpty();
            Assert.IsTrue(p.IsEmpty());
            p.Add(new Element(10, "Hello"));
            p.Add(new Element(10, "Hello"));
            Assert.IsFalse(p.IsEmpty());
            p.SetEmpty();
            Assert.IsTrue(p.IsEmpty());

        }
        [TestMethod]
        public void RemMaxTest()
        {
            PrQueue p = new();
            Assert.ThrowsException<PrQueue.NoElementsExeption>(() => p.RemMax());
            Assert.ThrowsException<PrQueue.NoElementsExeption>(() => p.GetMax());
            
            p.Add(new Element(1, "h1"));
            p.Add(new Element(10, "h2"));
            p.Add(new Element(12, "h2"));
            p.Add(new Element(9, "h2"));
            p.Add(new Element(8, "h2"));
            p.Add(new Element(3, "h2"));
        }
        [TestMethod]
        public void GetMaxTest()
        {
            PrQueue p = new();
            p.Add(new Element(1,"h1"));
            p.Add(new Element(10,"h2"));
            p.Add(new Element(12,"h2"));
            p.Add(new Element(9,"h2"));
            p.Add(new Element(8,"h2"));
            p.Add(new Element(3,"h2"));

            Assert.AreEqual(12, p.GetMax().Prioritas);
        }
    }
}