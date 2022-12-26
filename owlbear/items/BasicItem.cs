using System;


namespace Items
{
    //Represents a BasicItem having name, description, weight, and value.
    public class BasicItem
    {
        private string  m_name;
        private string  m_desc;
        private int     m_weight;
        private int     m_value;

        public BasicItem(string n, string d, int w, int v)
        {
            m_name   = n;
            m_desc   = d;
            m_weight = w;
            m_value  = v;
        }

        public string Name  { get => m_name;   set => m_name   = value; }
        public string Desc  { get => m_desc;   set => m_desc   = value; }
        public int Weight   { get => m_weight; set => m_weight = value; }
        public int Value    { get => m_value;  set => m_value  = value; }

    }
}