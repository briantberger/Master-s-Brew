using System;

namespace Structure
{

	public class CharacterClasses
	{
		private List<CharacterClass> classes;

		public CharacterClasses()
		{
			classes = new List<CharacterClass>();
		}

        public int getHitDie()
        {
            return 0;
        }



        private class CharacterClass
        {
            // There's a lot more that needs to be added here, but I don't want
            // to move to fast in here - classes can get tricky
            private string className;
            private int hitDie;

            public CharacterClass(string className, int hitDie)
            {
                this.className = className;
                this.hitDie = hitDie;
            }
        }
    }
}

