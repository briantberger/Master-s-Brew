using System;

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
    public AbilityScores() {
        Random rnd = new Random();

        strSc = rnd.Next(1, 21);
        dexSc = rnd.Next(1, 21);
        conSc = rnd.Next(1, 21);
        intSc = rnd.Next(1, 21);
        wisSc = rnd.Next(1, 21);
        chaSc = rnd.Next(1, 21);
    }

    //Constructor for manually setting ability scores 
    public AbilityScores(int strIn, int dexIn, int conIn, int intIn, int wisIn, int chaIn) {
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
    public int getScore(int select) {
        switch(select)
        {
            case 1:
                return strSc;
            case 2:
                return dexSc;
            case 3: 
                return conSc;
            case 4:
                return intSc;
            case 5:
                return wisSc;
            case 6:
                return chaSc;
            default:
                return -1;
        }
    }

    public int getModifier(int select) {
        int score = getScore(select);
        return modifier(score);
    }

    private int modifier(int score) {
        return (score - 10) / 2;
    }

    //Change an individual score
    public void setScore(int select, int val) {
        switch(select)
        {
            case 1:
                strSc = val;
                break;
            case 2:
                dexSc = val;
                break;
            case 3: 
                conSc = val;
                break;
            case 4:
                intSc = val;
                break;
            case 5:
                wisSc = val;
                break;
            case 6:
                chaSc = val;
                break;
            default:
                //do nothing.
                //there should probably be some exception handling here 
        }
    }
    //Change multiple scores at the same time
    //Might be easier to just call the above method multiple times - we'll see
    public void setScores(int[] selections, int[] vals) {
        for (int i = 0; i < selections.Length; i++) {
            switch(selections[i])
            {
                case 1:
                    strSc = vals[i];
                    break;
                case 2:
                    dexSc = vals[i];
                    break;
                case 3: 
                    conSc = vals[i];
                    break;
                case 4:
                    intSc = vals[i];
                    break;
                case 5:
                    wisSc = vals[i];
                    break;
                case 6:
                    chaSc = vals[i];
                    break;
                default:
                    //do nothing.
                    //there should probably be some exception handling here 
            }
        }
    }
}