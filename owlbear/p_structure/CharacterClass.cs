using System;

namespace Structure
{
    /*
     * Represents a list of Character Classes. Since Player Characters can have
     * multiple classes and there is no limit to how many, a list is necessary.
     */
	public class CharacterClasses
	{
		private List<CharacterClass> classes;

		public CharacterClasses()
		{
			classes = new List<CharacterClass>();
		}

        public int[] getHitDie()
        {
            // STUB
            return Array.Empty<int>();
        }


        /*
         * Represents a Character Class, having a name, associate hitDie, and 
         * the class' current level.
         * 
         * TODO: Classes have a lot of other features not listed here - this is
         *       just a bare bones implementation for now. 
         */
        private class CharacterClass
        {
            // There's a lot more that needs to be added here, but I don't want
            // to move to fast in here - classes can get tricky
            private string className;
            private int hitDie;
            private int level;

            public CharacterClass(string className, int hitDie)
            {
                this.className = className;
                this.hitDie = hitDie;
                this.level = 1;
            }
        }
    }
}

