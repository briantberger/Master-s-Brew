using System;
using Items;

namespace Structure
{
    public class Equipment
    {
        //TODO
        //eventually, need to switch this to be 3 (maybe more) lists of different equippables.
        private List<BasicItem> equipped;

        public Equipment()
        {
            // is list the best choice here?
            equipped = new List<BasicItem>();
        }
    }
}