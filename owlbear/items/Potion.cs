
/*
This has to be a pretty robust class because potions can do a lot of different things in DND.
I think the key thing is to focus on just making it so a potion can have however many effects
and each effect is basically just a function in here. Like the potion just calls a bunch of 
function pointers when it goes, I guess.
*/

public class Potion : BasicItem
{

    public Potion(string n, string d, int w, int v) : base(n, d, w, v) {
        //Potion-specific properties 
    }
}