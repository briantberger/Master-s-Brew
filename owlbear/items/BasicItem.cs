using System;


namespace Items
{
    //Represents a BasicItem having name, description, weight, and value.
    public class BasicItem
    {
        private string name;
        private string desc;
        private int weight;
        private int value;

        public BasicItem(string n, string d, int w, int v)
        {
            name = n;
            desc = d;
            weight = w;
            value = v;
        }

        public string Name { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Value { get => value; set => this.value = value; }

    }
}