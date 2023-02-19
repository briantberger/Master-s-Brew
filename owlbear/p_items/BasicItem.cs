using System;


namespace Items
{
    /// <summary>
    /// Represents a BasicItem having name, description, weight, and value.
    /// </summary>
    public class BasicItem
    {
        private string  m_name;
        private string  m_desc;
        private int     m_weight;
        private int     m_value;

        public BasicItem(string name, string desc, int weight, int value)
        {
            m_name   = name;
            m_desc   = desc;
            m_weight = weight;
            m_value  = value;
        }

        public string Name  { get => m_name;   set => m_name   = value; }
        public string Desc  { get => m_desc;   set => m_desc   = value; }
        public int Weight   { get => m_weight; set => m_weight = value; }
        public int Value    { get => m_value;  set => m_value  = value; }

    }
}