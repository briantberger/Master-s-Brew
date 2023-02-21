using System;
using Items.Properties; 


namespace Items
{
    /// <summary>
    /// Represents a BasicItem having name, description, weight, and value.
    /// </summary>
    public class BasicItem : Stackable
    {
        private string  m_name;
        private string  m_desc;
        private double  m_weight;
        private double  m_value;
        private bool m_stackable;

        public BasicItem(string name, string desc, double weight, double value,
                         bool stackable)
        {
            m_name   = name;
            m_desc   = desc;
            m_weight = weight;
            m_value  = value;
            m_stackable = stackable;
        }

        public string Name  { get => m_name;   set => m_name   = value; }
        public string Desc  { get => m_desc;   set => m_desc   = value; }
        public double Weight   { get => m_weight; set => m_weight = value; }
        public double Value    { get => m_value;  set => m_value  = value; }
        public bool stackable { get => m_stackable; set => m_stackable = value;}

    }
}