using Microsoft.VisualStudio.TestTools.UnitTesting;
using Structure;
using Items;

namespace owlbearTests;

[TestClass]
public class OwlbearTests
{
    CharacterClass testClass1;
    CharacterClass testClass2;
    CharacterClass testClass3;
    CharacterClass testClass4;

    BasicItem basicItem1;
    BasicItem basicItem2;
    Weapon weapon1;
    Weapon weapon2;
    Armor armor1;
    Armor armor2;
    MagicItem magicItem1;
    MagicItem magicItem2;

    ItemAttack testAttack1;
    ItemAttack testAttack2;

    ItemAction testAction1;

    string char1Name;
    string char2Name;

    PlayerCharacter? testChar1;
    PlayerCharacter? testChar2;

    public OwlbearTests()
    {
        this.testClass1 = new CharacterClass("Barbarian", 12);
        this.testClass2 = new CharacterClass("Bard", 8, 3);
        this.testClass3 = new CharacterClass("Fighter", 10);
        this.testClass4 = new CharacterClass("Bard", 8, 3);

        this.testAttack1 = new ItemAttack("Rapier", 8, 1, 6, 4);
        this.testAttack2 = new ItemAttack("Shortbow", 6, 1, 4, 6);

        this.testAction1 = new ItemAction("testAction");

        this.basicItem1 = new BasicItem("Piton", "PitonDesc", 2.5, 0.5);
        this.basicItem2 = new BasicItem("Thieves' Tools", "ToolsDesc", 1, 25);

        this.weapon1 = new Weapon("Rapier", "RapierDesc", 2, 25, testAttack1);
        this.weapon2 = new Weapon("Shortbow", "ShortbowDesc", 2, 25,
                                  testAttack2);

        this.armor1 = new Armor("Leather", "LeatherDesc", 10, 10, 11, 4);
        this.armor2 = new Armor("Ring Mail", "RingMailDesc", 30, 40, 14, 0);

        this.magicItem1 = new MagicItem("Amulet of Health", "AmuletDesc", 2,
                                        40, true, false, testAction1);
        this.magicItem2 = new MagicItem("Ring of Animal Influence", "RingDesc",
                                        0.5, 40, false, false, testAction1);

        char1Name = "Saryon";
        char2Name = "Joram";
    }

    [TestMethod]
    public void SanityTest()
    {
        testChar1 = new PlayerCharacter(testClass1, char1Name);
        Assert.AreEqual(testChar1.CharClasses.Classes[0], testClass1);
        Assert.AreEqual(testChar1.Name, char1Name);
        Assert.AreEqual(testClass2, testClass4);
    }

    [TestMethod, TestCategory("AbilityScores")]
    public void Manual_AbilityScores_ProperSet()
    {
        int strSc = 13;
        int dexSc = 18;
        int conSc = 10;
        int intSc = 14;
        int wisSc = 9;
        int chaSc = 6;
        testChar1 = new PlayerCharacter(strSc, dexSc, conSc, intSc, wisSc,
                                        chaSc, testClass1, char1Name);

        AbilityScores expected = new AbilityScores(strSc, dexSc, conSc, intSc,
                                                   wisSc, chaSc);

        Assert.AreEqual(testChar1.CharAbi, expected);
        Assert.AreEqual(testChar1.CharAbi.getScore("str"), strSc);
        Assert.AreEqual(testChar1.CharAbi.getScore("dex"), dexSc);
        Assert.AreEqual(testChar1.CharAbi.getScore("con"), conSc);
        Assert.AreEqual(testChar1.CharAbi.getScore("int"), intSc);
        Assert.AreEqual(testChar1.CharAbi.getScore("wis"), wisSc);
        Assert.AreEqual(testChar1.CharAbi.getScore("cha"), chaSc);
    }

    [TestMethod, TestCategory("AbilityScores")]
    public void Random_AbilityScores_InRange()
    {
        testChar1 = new PlayerCharacter(testClass1, char1Name);
        testChar2 = new PlayerCharacter(testClass3, char2Name);

        // testChar1
        Assert.IsTrue(testChar1.CharAbi.getScore("str") >= 3);
        Assert.IsTrue(testChar1.CharAbi.getScore("str") <  19);

        Assert.IsTrue(testChar1.CharAbi.getScore("dex") >= 3);
        Assert.IsTrue(testChar1.CharAbi.getScore("dex") < 19);

        Assert.IsTrue(testChar1.CharAbi.getScore("con") >= 3);
        Assert.IsTrue(testChar1.CharAbi.getScore("con") < 19);

        Assert.IsTrue(testChar1.CharAbi.getScore("int") >= 3);
        Assert.IsTrue(testChar1.CharAbi.getScore("int") < 19);

        Assert.IsTrue(testChar1.CharAbi.getScore("wis") >= 3);
        Assert.IsTrue(testChar1.CharAbi.getScore("wis") < 19);

        Assert.IsTrue(testChar1.CharAbi.getScore("cha") >= 3);
        Assert.IsTrue(testChar1.CharAbi.getScore("cha") < 19);

        // testChar2
        Assert.IsTrue(testChar2.CharAbi.getScore("str") >= 3);
        Assert.IsTrue(testChar2.CharAbi.getScore("str") < 19);

        Assert.IsTrue(testChar2.CharAbi.getScore("dex") >= 3);
        Assert.IsTrue(testChar2.CharAbi.getScore("dex") < 19);

        Assert.IsTrue(testChar2.CharAbi.getScore("con") >= 3);
        Assert.IsTrue(testChar2.CharAbi.getScore("con") < 19);

        Assert.IsTrue(testChar2.CharAbi.getScore("int") >= 3);
        Assert.IsTrue(testChar2.CharAbi.getScore("int") < 19);

        Assert.IsTrue(testChar2.CharAbi.getScore("wis") >= 3);
        Assert.IsTrue(testChar2.CharAbi.getScore("wis") < 19);

        Assert.IsTrue(testChar2.CharAbi.getScore("cha") >= 3);
        Assert.IsTrue(testChar2.CharAbi.getScore("cha") < 19);
    }

    [TestMethod, TestCategory("AbilityScores")]
    public void Manual_AbilityScores_ModifierCorrect()
    {
        int strSc = 13;
        int dexSc = 18;
        int conSc = 10;
        int intSc = 14;
        int wisSc = 9;
        int chaSc = 6;

        int expectedStrMod = 1;
        int expectedDexMod = 4;
        int expectedConMod = 0;
        int expectedIntMod = 2;
        int expectedWisMod = -1;
        int expectedChaMod = -2;
        testChar1 = new PlayerCharacter(strSc, dexSc, conSc, intSc, wisSc,
                                        chaSc, testClass1, char1Name);

        Assert.AreEqual(expectedStrMod, testChar1.CharAbi.getModifier("str"));
        Assert.AreEqual(expectedDexMod, testChar1.CharAbi.getModifier("dex"));
        Assert.AreEqual(expectedConMod, testChar1.CharAbi.getModifier("con"));
        Assert.AreEqual(expectedIntMod, testChar1.CharAbi.getModifier("int"));
        Assert.AreEqual(expectedWisMod, testChar1.CharAbi.getModifier("wis"));
        Assert.AreEqual(expectedChaMod, testChar1.CharAbi.getModifier("cha"));
    }

    [TestMethod, TestCategory("AbilityScores")]
    public void Manual_AbilityScores_NegativeModifiersAllCorrect()
    {
        int strSc = 1;
        int dexSc = 2;
        int conSc = 3;
        int intSc = 4;
        int wisSc = 5;
        int chaSc = 6;


        int expectedStrMod = -5;
        int expectedDexMod = -4;
        int expectedConMod = -4;
        int expectedIntMod = -3;
        int expectedWisMod = -3;
        int expectedChaMod = -2;
        AbilityScores actual = new AbilityScores(strSc, dexSc, conSc, intSc, wisSc,
                                                 chaSc);

        Assert.AreEqual(expectedStrMod, actual.getModifier("str"));
        Assert.AreEqual(expectedDexMod, actual.getModifier("dex"));
        Assert.AreEqual(expectedConMod, actual.getModifier("con"));
        Assert.AreEqual(expectedIntMod, actual.getModifier("int"));
        Assert.AreEqual(expectedWisMod, actual.getModifier("wis"));
        Assert.AreEqual(expectedChaMod, actual.getModifier("cha"));
    }

    [TestMethod, TestCategory("AbilityScores")]
    public void Manual_AbilityScores_ModifiersNear10AllCorrect()
    {
        int strSc = 7;
        int dexSc = 8;
        int conSc = 9;
        int intSc = 10;
        int wisSc = 11;
        int chaSc = 12;


        int expectedStrMod = -2;
        int expectedDexMod = -1;
        int expectedConMod = -1;
        int expectedIntMod = -0;
        int expectedWisMod = -0;
        int expectedChaMod = 1;
        AbilityScores actual = new AbilityScores(strSc, dexSc, conSc, intSc, wisSc,
                                                 chaSc);

        Assert.AreEqual(expectedStrMod, actual.getModifier("str"));
        Assert.AreEqual(expectedDexMod, actual.getModifier("dex"));
        Assert.AreEqual(expectedConMod, actual.getModifier("con"));
        Assert.AreEqual(expectedIntMod, actual.getModifier("int"));
        Assert.AreEqual(expectedWisMod, actual.getModifier("wis"));
        Assert.AreEqual(expectedChaMod, actual.getModifier("cha"));
    }

    [TestMethod, TestCategory("Inventory")]
    public void InventoryConstructorTest()
    {
        int expectedMaxLoad = 150;
        int expectedLoad = 0;

        Inventory testInventory = new Inventory(10);

        Assert.AreEqual(expectedMaxLoad, testInventory.MaxLoad);
        Assert.AreEqual(expectedLoad, testInventory.Load);
        Assert.IsTrue(testInventory.Items.Count == 0);
    }

    [TestMethod, TestCategory("Inventory")]
    public void Add_OneItem_ToInventory()
    {
        double expectedLoad = basicItem1.Weight;

        Inventory testInventory = new Inventory(10);
        testInventory.AddItemToInventory(basicItem1);

        Assert.IsTrue(testInventory.ContainsItem(basicItem1));
        Assert.IsTrue(testInventory.Items.Count == 1);
        Assert.AreEqual(expectedLoad, testInventory.Load);
    }

    [TestMethod, TestCategory("Inventory")]
    public void Add_TwoItems_ToInventory()
    {
        double expectedLoad = basicItem1.Weight + basicItem2.Weight;

        Inventory testInventory = new Inventory(10);
        testInventory.AddItemToInventory(basicItem1);
        testInventory.AddItemToInventory(basicItem2);

        Assert.IsTrue(testInventory.ContainsItem(basicItem1));
        Assert.IsTrue(testInventory.ContainsItem(basicItem2));
        Assert.IsTrue(testInventory.Items.Count == 2);
        Assert.AreEqual(expectedLoad, testInventory.Load);
    }

    [TestMethod, TestCategory("Inventory")]
    public void Add_ItemsOfDifferentType_ToInventory()
    {
        double expectedLoad = basicItem1.Weight + weapon1.Weight
                              + armor1.Weight + magicItem1.Weight;

        Inventory testInventory = new Inventory(15);
        testInventory.AddItemToInventory(basicItem1);
        testInventory.AddItemToInventory(weapon1);
        testInventory.AddItemToInventory(armor1);
        testInventory.AddItemToInventory(magicItem1);

        Assert.IsTrue(testInventory.ContainsItem(basicItem1));
        Assert.IsTrue(testInventory.ContainsItem(weapon1));
        Assert.IsTrue(testInventory.ContainsItem(armor1));
        Assert.IsTrue(testInventory.ContainsItem(magicItem1));
        Assert.IsTrue(testInventory.Items.Count == 4);
        Assert.AreEqual(expectedLoad, testInventory.Load);
    }

    [TestMethod, TestCategory("Inventory")]
    public void Add_ItemTooHeavy_ToInventory()
    {
        double expectedLoad = 0;
        int expectedCapacity = 0;

        Inventory testInventory = new Inventory(1);
        try
        {
            testInventory.AddItemToInventory(armor2);
            Assert.Fail();
        } catch (Exception e)
        {
            // expected behaviour
        }

        Assert.AreEqual(expectedCapacity, testInventory.Items.Count);
        Assert.AreEqual(expectedLoad, testInventory.Load);
    }

    [TestMethod, TestCategory("Inventory")]
    public void Add_ItemWeightSameAsMaxLoad_ToInventory()
    {
        double expectedLoad = 30;
        int expectedCapacity = 1;

        Inventory testInventory = new Inventory(2);
        try
        {
            testInventory.AddItemToInventory(armor2);
        } catch (Exception e)
        {
            Assert.Fail();
        }

        Assert.IsTrue(testInventory.ContainsItem(armor2));
        Assert.AreEqual(expectedCapacity, testInventory.Items.Count);
        Assert.AreEqual(expectedLoad, testInventory.Load);
    }

    [TestMethod, TestCategory("Inventory")]
    public void ListEquippableItems_InInventory()
    {
        int expectedCount = 3;

        Inventory testInventory = new Inventory(15);
        testInventory.AddItemToInventory(basicItem1);
        testInventory.AddItemToInventory(weapon1);
        testInventory.AddItemToInventory(armor1);
        testInventory.AddItemToInventory(magicItem1);

        List<Equippable> actual = testInventory.ListEquippableItems();
        Assert.IsTrue(actual.Contains(weapon1));
        Assert.IsTrue(actual.Contains(armor1));
        Assert.IsTrue(actual.Contains(magicItem1));
        Assert.AreEqual(expectedCount, actual.Count);
    }

    [TestMethod, TestCategory("Inventory")]
    public void ListEquippedItems_InInventory()
    {
        int expectedCount = 2;

        Inventory testInventory = new Inventory(15);
        testInventory.AddItemToInventory(basicItem1);
        testInventory.AddItemToInventory(weapon1);
        testInventory.AddItemToInventory(armor1);
        testInventory.AddItemToInventory(magicItem1);

        weapon1.equipped = true;
        magicItem1.equipped = true;

        List<Equippable> actual = testInventory.ListEquippedItems();
        Assert.IsTrue(actual.Contains(weapon1));
        Assert.IsTrue(actual.Contains(magicItem1));
        Assert.AreEqual(expectedCount, actual.Count);
    }

    [TestMethod, TestCategory("Inventory")]
    public void ListUnequippableItems_InInventory()
    {
        int expectedCount = 1;

        Inventory testInventory = new Inventory(15);
        testInventory.AddItemToInventory(basicItem1);
        testInventory.AddItemToInventory(weapon1);
        testInventory.AddItemToInventory(armor1);
        testInventory.AddItemToInventory(magicItem1);

        List<BasicItem> actual = testInventory.ListUnequippableItems();
        Assert.IsTrue(actual.Contains(basicItem1));
        Assert.AreEqual(expectedCount, actual.Count);
    }

    // could I add more tests? yes.
    // will I? probably not. At least not right now.
}
