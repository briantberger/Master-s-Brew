using System;
using Items;
using Items.Properties;


namespace Structure
{
    /// <summary>
    /// Represents a character's inventory
    /// </summary>
    public class Inventory
    {
        private List<InventorySlot> m_items;
        private double m_load;
        private double m_maxLoad;

        public Inventory(int str)
        {
            m_items = new List<InventorySlot>();
            m_load = 0;
            m_maxLoad = str * 15;
        }

        public List<InventorySlot> Items { get => m_items;
                                           set => m_items = value; }
        public double Load { get => m_load; set => m_load = value; }
        public double MaxLoad { get => m_maxLoad; set => m_maxLoad = value; }

        /// <summary>
        /// <para>MODIFIES: this</para>
        /// <para>EFFECTS : attempts to add item to inventory. If weight of item
        /// would bring inventory load over max load, throws an exception.
        /// </para>
        /// </summary>
        /// <param name="item"></param>
        public void AddItemToInventory(BasicItem item)
        {
            if ((this.Load + item.Weight) > MaxLoad)
            {
                // TODO: actually define the exception to be thrown.
                throw new Exception();
            }

            if (item.stackable && this.ContainsItem(item))
            {
                this.FindSlot(item).IncQuantity();
            } else
            {
                Items.Add(new InventorySlot(item, 1));
            }
            this.Load += item.Weight;
        }

        /// <summary>
        /// <para>MODIFIES: this</para>
        /// <para>EFFECTS : removes item from inventory, and decreases load by
        /// item weight.</para>
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItemFromInventory(BasicItem item)
        {
            try {
                InventorySlot toRemove = this.FindSlot(item);
                if (item.stackable)
                {
                    toRemove.DecQuantity();
                    if (toRemove.Quantity == 0)
                    {
                        Items.Remove(toRemove);
                    }
                }
                else
                {
                    Items.Remove(toRemove);
                }
                this.Load -= item.Weight;
            } catch (Exception e)
            {
                throw;
            }
        }

        /// <summary>
        /// EFFECTS : returns a list of all currently equipped items
        /// </summary>
        /// <returns></returns>
        public List<Equippable> ListEquippedItems()
        {
            List<Equippable> ret = new List<Equippable>();
            foreach (InventorySlot slot in Items)
            {
                if (slot.Item is Equippable &&
                    ((Equippable)slot.Item).equipped == true)
                {
                    ret.Add((Equippable)slot.Item);
                }
            }
            return ret;
        }

        /// <summary>
        /// EFFECTS: returns a list of all equippable items in inventory,
        /// including those already equipped
        /// </summary>
        /// <returns></returns>
        public List<Equippable> ListEquippableItems()
        {
            List<Equippable> ret = new List<Equippable>();
            foreach (InventorySlot slot in Items)
            {
                if (slot.Item is Equippable)
                {
                    ret.Add((Equippable)slot.Item);
                }
            }
            return ret;
        }

        /// <summary>
        /// EFFECTS : returns a list of all items in inventory that cannot be
        /// equipped.
        /// </summary>
        /// <returns></returns>
        public List<BasicItem> ListUnequippableItems()
        {
            List<BasicItem> ret = new List<BasicItem>();
            foreach (InventorySlot slot in Items)
            {
                if (!(slot.Item is Equippable))
                {
                    ret.Add(slot.Item);
                }
            }
            return ret;
        }

        /// <summary>
        /// EFFECTS : returns true if item can be found in inventory in any
        ///           quantity, false if not. 
        /// </summary>
        /// <returns></returns>
        public Boolean ContainsItem(BasicItem item)
        {
            foreach (InventorySlot slot in Items)
            {
                if (slot.Item == item) return true;
            }
            return false;
        }

        /// <summary>
        /// Finds slot with item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public InventorySlot FindSlot(BasicItem item)
        {
            foreach (InventorySlot slot in Items)
            {
                if (slot.Item == item) return slot;
            }
            // TODO: actually define the Exception
            throw new Exception();
        }

        /// <summary>
        /// Represents a single inventory slot, consisting of the item in that
        /// slot and the quantity of item.
        /// </summary>
        public class InventorySlot
        {
            private BasicItem m_item;
            private int m_quantity;

            public InventorySlot(BasicItem item, int quantity)
            {
                this.m_item = item;
                this.m_quantity = quantity;
            }

            public BasicItem Item { get => m_item; set => m_item = value; }
            public int Quantity { get => m_quantity; set => m_quantity = value; }

            public void IncQuantity()
            {
                this.m_quantity++;
            }

            public void DecQuantity()
            {
                this.m_quantity--;
            }
        }
    }
}