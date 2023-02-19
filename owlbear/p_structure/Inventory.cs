using System;
using Items;

namespace Structure
{
    /// <summary>
    /// Represents a character's inventory
    /// </summary>
    public class Inventory
    {
        private List<InventorySlot> m_items;
        private int m_load;
        private int m_maxLoad;

        public Inventory(int str)
        {
            m_items = new List<InventorySlot>();
            m_load = 0;
            m_maxLoad = str * 15;
        }

        public List<InventorySlot> Items { get => m_items;
                                           set => m_items = value; }
        public int Load { get => m_load; set => m_load = value; }
        public int MaxLoad { get => m_maxLoad; set => m_maxLoad = value; }

        /// <summary>
        /// <para>MODIFIES: this</para>
        /// <para>EFFECTS : attempts to add item to inventory. If weight of item
        /// would bring inventory load over max load, throws an exception.
        /// </para>
        /// </summary>
        /// <param name="item"></param>
        public void AddItemToInventory(BasicItem item)
        {
            // STUB
        }

        /// <summary>
        /// <para>MODIFIES: this</para>
        /// <para>EFFECTS : removes item from inventory, and decreases load by
        /// item weight.</para>
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItemFromInventory(BasicItem item)
        {
            // STUB
        }

        /// <summary>
        /// EFFECTS : returns a list of all currently equipped items
        /// </summary>
        /// <returns></returns>
        public List<BasicItem> ListEquippedItems()
        {
            // STUB
            return new List<BasicItem>();
        }

        /// <summary>
        /// EFFECTS: returns a list of all equippable items in inventory,
        /// including those already equipped
        /// </summary>
        /// <returns></returns>
        public List<BasicItem> ListEquippableItems()
        {
            // STUB
            return new List<BasicItem>();
        }

        /// <summary>
        /// EFFECTS: returns a list of all items in inventory that cannot be
        /// equipped.
        /// </summary>
        /// <returns></returns>
        public List<BasicItem> ListUnequippableItems()
        {
            // STUB
            return new List<BasicItem>();
        }

        /// <summary>
        /// Represents a single inventory slot, consisting of the item in that
        /// slot and the quantity of item.
        /// </summary>
        // TODO: we probably need a "stackable" interface
        public class InventorySlot
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