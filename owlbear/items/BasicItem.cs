
//Represents a BasicItem having name, description, weight, and value.
public class BasicItem 
{
    protected string name;
    protected string desc;
    protected int weight;
    protected int value;

    public BasicItem(string n, string d, int w, int v) {
        name    = n;
        desc    = d;
        weight  = w;
        value   = v;
    }
}