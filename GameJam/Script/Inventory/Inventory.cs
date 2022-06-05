using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    class Inventory
    {
        internal Dictionary<string, Item> inventory = new Dictionary<string, Item>();

        public Inventory()
        {
            
        }

        internal void AddItem(Item item)
        {
            inventory.Add(item.name, item);
        }

        internal void RemoveItem(string ItemName)
        {
            inventory.Remove(ItemName);
        }
    }
}