namespace POEptOne;
// a class to hold ingredients 
public class Ingrediants
{
    public string IngName
    {
        get;
        set;
    }

    public string Quant
    {
        get;
        set;
    }

    public int Amount
    {
        get;
        set;
    }
// constructor
    public Ingrediants(string IngName,string Quant,int Amount)
    {
        this.IngName = IngName;
        this.Quant = Quant;
        this.Amount = Amount;

    }

    
    
}