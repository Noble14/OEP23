namespace FishingContest.Test;

[TestClass]
public class UnitTest1
{
    private Fisher Jozsi()
    {
        return new Fisher("J�zsi");
    }


    [TestMethod]
    public void TestMethod1()
    {

        Fisher f = new Fisher("J�zsi");
        //f.Catches.Add(new Fisher.Catch() { });


        Assert.AreEqual(0, f.harcsak());
    }
}