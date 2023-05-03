using System;

namespace Structure
{
    /*
     * Represents a list of Character Classes. Since Player Characters can have
     * multiple classes and there is no limit to how many, a list is necessary.
     * The list must include at least one class.
     */
	public class CharacterClasses
	{
		private List<CharacterClass> m_classes;

		public CharacterClasses(CharacterClass charClass)
		{
			m_classes = new List<CharacterClass>();
            m_classes.Add(charClass);
		}

        public List<CharacterClass> Classes { get => m_classes; }

        /// <summary>
        /// EFFECTS : returns list of each class' hit die
        /// </summary>
        public int[] getHitDie()
        {
            int[] hitDie = new int[sumLevels()];
            int i = 0;
            foreach (CharacterClass characterClass in m_classes)
            {
                hitDie[i++] = characterClass.HitDie;
            }
            return hitDie;
        }

        private int sumLevels()
        {
            int result = 0;
            foreach (CharacterClass characterClass in m_classes)
            {
                result += characterClass.Level;
            }
            return result;
        }

        /// <summary>
        /// Adds a new CharacterClass to classes.
        /// </summary>
        /// <param name="charClass"></param>
        public void addClass(CharacterClass charClass)
        {
            // STUB
        }
    }
}

