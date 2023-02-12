using System;


namespace Structure
{
    public class AbilityScores
    {
        //keeping track of the modifiers is kind of redundant because the modifier can be determined from the ability score 
        private int strSc;  //encoded as 1
        private int dexSc;  //encoded as 2
        private int conSc;  //encoded as 3
        private int intSc;  //encoded as 4
        private int wisSc;  //encoded as 5
        private int chaSc;  //encoded as 6

        //Constructor for randomly generating ability scores
        public AbilityScores()
        {
            Random rnd = new Random();

            strSc = rnd.Next(1, 19);
            dexSc = rnd.Next(1, 19);
            conSc = rnd.Next(1, 19);
            intSc = rnd.Next(1, 19);
            wisSc = rnd.Next(1, 19);
            chaSc = rnd.Next(1, 19);
        }

        //Constructor for manually setting ability scores 
        public AbilityScores(int strIn, int dexIn, int conIn, int intIn, int wisIn, int chaIn)
        {
            strSc = strIn;
            dexSc = dexIn;
            conSc = conIn;
            intSc = intIn;
            wisSc = wisIn;
            chaSc = chaIn;
        }

        //Would like to add constructor for manually setting ability scores with point buy system,
        //but I feel like that'd work better in a runtime context I guess. Can probably just
        //reuse the above constructor and do the checking of within points in the frontend stuff. 

        //GETTERS AND SETTERS
        public int getScore(string stat)
        {
            switch (stat)
            {
                case "str":
                    return strSc;
                case "dex":
                    return dexSc;
                case "con":
                    return conSc;
                case "int":
                    return intSc;
                case "wis":
                    return wisSc;
                case "cha":
                    return chaSc;
                default:
                    return -1;
            }
        }

        public int getModifier(string select)
        {
            int score = getScore(select);
            return modifier(score);
        }

        private int modifier(int score)
        {
            return (score - 10) / 2;
        }

        //Change an individual score
        public void setScore(string select, int val)
        {
            switch (select)
            {
                case "str":
                    strSc = val;
                    break;
                case "dex":
                    dexSc = val;
                    break;
                case "con":
                    conSc = val;
                    break;
                case "int":
                    intSc = val;
                    break;
                case "wis":
                    wisSc = val;
                    break;
                case "cha":
                    chaSc = val;
                    break;
                default:
                    break;
                    //do nothing.
                    //there should probably be some exception handling here 
            }
        } 
    }
}