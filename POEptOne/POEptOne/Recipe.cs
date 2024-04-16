namespace POEptOne;

public class Recipe
{
    private List<string> names = new List<string>();

    private List<int> amount = new List<int>();

   

    public int quant { get; set; }


    public string name { get; set; }



    public string UnOfMes { get; set; }

    public int ingrediants { get; set; }

    
    public string PrintIngrediants(List<Ingredients> ingss)
    {
        // for ( int i =0 ; )
        foreach (Ingredients ignsIngrediants in ingss)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($" The name of the ingredient: {ignsIngrediants.IngName}");
            Console.WriteLine($" The Quantity of the ingredient: {ignsIngrediants.Quant}");
            Console.WriteLine($" The Amount of the ingredient: {ignsIngrediants.Amount}");
            Console.WriteLine("------------------------------------------");
        }

        return null;
    }

    public List<Ingredients> editList(List<Ingredients> ingss )
    {
        Console.WriteLine("what is the name of the ingrediant you would like to search for ?");
        string search = Console.ReadLine();
        Console.WriteLine("how would you like to scale up the ingrediant:" +
                          "\n 1. a factor of 0,5" +
                          "\n 2. a factor of 2" +
                          "\n 3. a factor of 3");

        int scale = int.Parse(Console.ReadLine());
        int index = ingss.FindIndex(x => x.IngName == search);
        ingss[index].Amount = ingss[index].Amount * scale;
        

        return ingss;
    }

    public List<Ingredients> SaveOrigionals(List<Ingredients> ingss, List<Ingredients> origIngrediantsList )
    {
        for (int i = 0; i < origIngrediantsList.Count; i++)
        {
            ingss[i] = origIngrediantsList[i];
        }
        
        return ingss;

    }


}