using System;
using Items;

namespace Structure
{
    public class BrewUser
    {
        private List<CharacterClass> m_userClasses;
        private List<PlayerCharacter> m_userCharacters;
        private List<BasicItem> m_userItems;

        public BrewUser()
        {
            m_userClasses = new List<CharacterClass>();
            m_userCharacters = new List<PlayerCharacter>();
            m_userItems = new List<BasicItem>();
        }

        public BrewUser(List<CharacterClass> classes,
                        List<PlayerCharacter> characters,
                        List<BasicItem> items)
        {
            m_userClasses = classes;
            m_userCharacters = characters;
            m_userItems = items;
        }


    }
}