using Microsoft.VisualStudio.TestTools.UnitTesting;



[TestClass]
public class JournalTests
{
    [TestMethod]
    public void Test_AddEmployees()
    {
        Journal journal = new Journal();
        journal.NumberOfEmployees = 10;

        journal += 5; 

        Assert.AreEqual(15, journal.NumberOfEmployees);
    }

    [TestMethod]
    public void Test_Equality()
    {
        Journal journal1 = new Journal();
        journal1.NumberOfEmployees = 10;

        Journal journal2 = new Journal();
        journal2.NumberOfEmployees = 10;

        Assert.AreEqual(journal1, journal2);
    }
}

[TestClass]
public class ShopTests
{
    [TestMethod]
    public void Test_AreaChange()
    {
        Shop shop = new Shop();
        shop.Area = 100;

        shop += 50; 

        Assert.AreEqual(150, shop.Area);
    }

    [TestMethod]
    public void Test_Comparison()
    {
        Shop shop1 = new Shop();
        shop1.Area = 100;

        Shop shop2 = new Shop();
        shop2.Area = 150;

        Assert.IsTrue(shop2 > shop1); 
    }
}
