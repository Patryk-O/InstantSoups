using Microsoft.VisualStudio.TestTools.UnitTesting;
using InstantSoupShop;
using System;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace InstantSoupShopTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSell()
        {
            var shopNr1 = new SoupShop();
            var cmd = new SoupShopCommand(shopNr1, SoupShopCommand.Task.Sell);
            
            using (var consoleOutput = new ConsoleOutput())
            {
                cmd.execute();
                Assert.AreEqual("U sell soup", consoleOutput.GetOuput().Trim());
            }
        }
        [TestMethod]
        public void TestSellOutOfStock()
        {
            var shopNr1 = new SoupShop();
            var cmd = new SoupShopCommand(shopNr1, SoupShopCommand.Task.Sell);
            for(int i=0; i < 100; i++)
            {
                cmd.execute();
            }

            using (var consoleOutput = new ConsoleOutput())
            {
                cmd.execute();
                Assert.AreEqual("Shop don't have more soup", consoleOutput.GetOuput().Trim());
            }
        }
        [TestMethod]
        public void TestRestockWithFullStock()
        {
            var shopNr1 = new SoupShop();
            var cmd = new SoupShopCommand(shopNr1, SoupShopCommand.Task.Restock);
            using (var consoleOutput = new ConsoleOutput())
            {
                cmd.execute();
                Assert.AreEqual("Shop don't need more soups", consoleOutput.GetOuput().Trim());
            }
        }
        [TestMethod]
        public void TestRestock()
        {
            var shopNr1 = new SoupShop();
            var cmd = new SoupShopCommand(shopNr1, SoupShopCommand.Task.Sell);
            for (int i = 0; i < 50; i++)
            {
                cmd.execute();
            }
            var cmd2 = new SoupShopCommand(shopNr1, SoupShopCommand.Task.Restock);

            using (var consoleOutput = new ConsoleOutput())
            {
                cmd2.execute();
                Assert.AreEqual("U restock a soups", consoleOutput.GetOuput().Trim());
            }
        }
        [TestMethod]
        public void TestCheckStock()
        {
            var shopNr1 = new SoupShop();
            var cmd = new SoupShopCommand(shopNr1, SoupShopCommand.Task.Stock);

            using (var consoleOutput = new ConsoleOutput())
            {
                cmd.execute();
                Assert.AreEqual("Soup stock is: 100", consoleOutput.GetOuput().Trim());
            }
        }
    }
}
