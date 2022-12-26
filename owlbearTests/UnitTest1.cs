using Microsoft.VisualStudio.TestTools.UnitTesting;
using Structure;
using Items;

namespace owlbearTests;

[TestClass]
public class OwlbearTests
{
    [TestMethod]
    public void BasicItemConstructorTest()
    {
        string name = "a";
        string desc = "aa";
        int weight = 10;
        int val = 15;


        BasicItem item = new BasicItem(name, desc, weight, val);
        Assert.AreEqual(name, item.Name);
    }

    [TestMethod]
    public void SanityTest()
    {
        string name = "b";
        string desc = "bb";
        int weight = 9;
        int val = 13;


        BasicItem item = new BasicItem(name, desc, weight, val);
        Assert.AreEqual(name, item.Name);
        Assert.AreEqual(desc, item.Desc);
        Assert.AreEqual(weight, item.Weight);
        Assert.AreEqual(val, item.Value);

        string altName = "aa";
        item.Name = altName;

        Assert.AreEqual(altName, item.Name);
    }
}
