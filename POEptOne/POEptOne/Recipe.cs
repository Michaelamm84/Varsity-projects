namespace POEptOne;

public class Recipe
{
    
    public int quant { get; set; }


    public string name { get; set; }



    public string UnOfMes { get; set; }

    public int ingrediants { get; set; }

    //printing method 
    public string PrintIngrediants(List<Ingrediants> ingss)
    {
       
        foreach (Ingrediants ignsIngrediants in ingss)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($" The name of the ingrdiant: {ignsIngrediants.IngName}");
            Console.WriteLine($" The Quantity of the ingrdiant: {ignsIngrediants.Quant}");
            Console.WriteLine($" The Amount of the ingrdiant: {ignsIngrediants.Amount}");
            Console.WriteLine("------------------------------------------");
        }

        return null;
    }

    
    //scaling up method 
    public List<Ingrediants> editList(List<Ingrediants> ingss )
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

    
    // reset to original values method 
    public List<Ingrediants> SaveOrigionals(List<Ingrediants> ingss, List<Ingrediants> origIngrediantsList )
    {
        for (int i = 0; i < origIngrediantsList.Count; i++)
        {
            ingss[i] = origIngrediantsList[i];
        }
        
        return ingss;

    }


}