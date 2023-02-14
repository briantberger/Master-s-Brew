using System;
using Items;

namespace Structure
{
    public class Inventory
    {
        private List<BasicItem> items;
        private int load;
        private int maxLoad;

        public Inventory(int str)
        {
            items = new List<BasicItem>();
            load = 0;
            maxLoad = str * 15;
        }

        /*
         * MODIFIES: this
         * EFFECTS : Attempts to add item to item list. If item weight would 
         *           make load > maxLoad, throws an error. 
         */
        public void AddItemToInventory(BasicItem item)
        {
            // STUB
        }

        /*
         * MODIFIES: this
         * EFFECTS : Removes item from inventory, and decreases load by item
         *           weight. 
         */
        public void RemoveItemFromInventory(int slot)
        {
            // STUB
        }

        
        private class InventorySlot
        {
            private BasicItem item;
            private int quantity;

            protected InventorySlot(BasicItem item, int quantity)
            {
                this.item = item;
                this.quantity = quantity;
            }
        }
    }
}