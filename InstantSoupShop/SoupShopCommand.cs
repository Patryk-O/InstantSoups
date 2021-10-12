using System;
using System.Collections.Generic;
using System.Text;

namespace InstantSoupShop
{
    public class SoupShopCommand : ICommand
    {
        public SoupShop _shop;
        public enum Task
        {
            Sell, Restock, Stock
        }
        private Task _task;
        public SoupShopCommand(SoupShop shop, Task task)
        {
            _shop = shop;
            _task = task;
        }
        public void execute()
        {
            switch (_task)
            {
                case Task.Sell: _shop.Sell(); break;
                case Task.Stock: _shop.Stock(); break;
                case Task.Restock: _shop.Restock(); break;
                default:
                    throw new ArgumentOutOfRangeException(); 
            }
        }
    }
}
