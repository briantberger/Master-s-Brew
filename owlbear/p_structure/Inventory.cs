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
    }
}