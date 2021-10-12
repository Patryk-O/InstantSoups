using System;
using System.Collections.Generic;
using System.Text;

namespace InstantSoupShop
{
    public class SoupShop
    {
        private int SoupStock = 100;
        
        public void Sell()
        {
            if(SoupStock > 0)
            {
                SoupStock -= 1;
                Console.WriteLine("U sell soup");
            }
            else
            {
                Console.WriteLine("Shop don't have more soup");
            }
        }
        public void Restock()
        {
            if(SoupStock == 100)
            {
                Console.WriteLine("Shop don't need more soups");
            }
            else
            {
                SoupStock = 100;
                Console.WriteLine("U restock a soups");
            }  
        }
        public void Stock()
        {
            Console.WriteLine($"Soup stock is: {SoupStock}");
        }
    }
}
