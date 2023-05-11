using Items;

namespace Structure
{
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
/// <summary>
/// Represents a single inventory slot, consisting of the item in that
/// slot and the quantity of item.
/// </summary>
