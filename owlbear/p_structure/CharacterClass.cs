using System;

namespace Structure
{
    public class CharacterClass
    {
        // There's a lot more that needs to be added here, but I don't want
        // to move to fast in here - classes can get tricky
        private string className;
        private int hitDie;
        private int level;

        /// <summary>
        /// Default constructor, sets level to 1.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="hitDie"></param>
        public CharacterClass(string className, int hitDie)
        {
            this.className = className;
            this.hitDie = hitDie;
            this.level = 1;
        }

        public int HitDie { get => hitDie; set => hitDie = value; }
        public int Level { get => level; set => level = value; }

        /// <summary>
        /// Constructor for manually setting level.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="hitDie"></param>
        /// <param name="level"></param>
        public CharacterClass(string className, int hitDie, int level)
        {
            this.className = className;
            this.hitDie = hitDie;
            this.level = level;
        }

        public override bool Equals(object? obj)
        {
            return obj is CharacterClass @class &&
                   className == @class.className &&
                   hitDie == @class.hitDie &&
                   level == @class.level;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(className, hitDie, level);
        }
    }
}

