
//Represents a BasicItem having name, description, weight, and value.
public class BasicItem 
{
    private string name;
    private string desc;
    private int weight;
    private int value;

    public BasicItem(string n, string d, int w, int v) {
        name    = n;
        desc    = d;
        weight  = w;
        value   = v;
    }
}