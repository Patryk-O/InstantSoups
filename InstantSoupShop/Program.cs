using System;

namespace InstantSoupShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopNr1 = new SoupShop();

            var cmd = new SoupShopCommand(shopNr1, SoupShopCommand.Task.Sell);
            cmd.execute();
        }
    }
}
