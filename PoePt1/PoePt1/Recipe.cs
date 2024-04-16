namespace PoePt1;

public class Recipe
{
 
    public int quant { get; set; }


    public string name { get; set; }



    public string UnOfMes { get; set; }

    public int ingredients { get; set; }

    //printing method 
    public string PrintIngredients(List<Ingredients> ingss)
    {
       
        foreach (Ingredients ignsIngredients in ingss)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($" The name of the ingrdiant: {ignsIngredients.IngName}");
            Console.WriteLine($" The Quantity of the ingrdiant: {ignsIngredients.Quant}");
            Console.WriteLine($" The Amount of the ingrdiant: {ignsIngredients.Amount}");
            Console.WriteLine("------------------------------------------");
        }

        return null;
    }

    
    //scaling up method 
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

    
    // reset to original values method 
    public List<Ingredients> SaveOrigionals(List<Ingredients> ingss, List<Ingredients> origIngrediantsList )
    {
        for (int i = 0; i < origIngrediantsList.Count; i++)
        {
            ingss[i] = origIngrediantsList[i];
        }
        
        return ingss;

    }


    // public List<string> CreateList(List<string> Recipe)
    // {
    //
    //     List<string> Ing = new List<string>();
    //     string numberOfIngrediants = null;
    //     int? numIng = null;
    //
    //     Console.WriteLine("hello what is the name of your Recipe ?");
    //
    //     Recipe.Add(Console.ReadLine());
    //
    //     Console.WriteLine("how many ingrediants in your recipe ?");
    //
    //     numberOfIngrediants = Console.ReadLine();
    //
    //     Recipe.Add(numberOfIngrediants);
    //
    //
    //     numIng = int.Parse(numberOfIngrediants);
    //     for (int i = 0; i < numIng; i++)
    //     {
    //         Console.WriteLine("what is the name of the ingrdiant");
    //         Recipe.Add(Console.ReadLine());
    //
    //         Console.WriteLine("what is the unit of measuremt for this ingrdiant");
    //         Recipe.Add(Console.ReadLine());
    //
    //         Console.WriteLine("how many units of the ingrdiant?");
    //         Recipe.Add(Console.ReadLine());
    //     }
    //     
    //     
    //     return Recipe;
    // }
    //
    // public List<string> EditingrediantsName(List<string> Recipe)
    // {
    //     Console.WriteLine("is there a particular ingrdiant you would like to change ? answer with yes or no");
    //
    //     if (Console.ReadLine() == "yes")
    //     {
    //         Console.WriteLine("which ingrediant ?");
    //
    //         string test = Console.ReadLine();
    //         
    //         for (int i = 0; i <= Recipe.Count; i++)
    //         {
    //
    //             if (test == Recipe[i])
    //             {
    //                 Console.WriteLine("what would you like to change the ingrediant to ?");
    //                 string hello = Console.ReadLine();
    //                 Recipe[i] = hello;
    //
    //
    //                 break;
    //
    //
    //             }
    //
    //
    //         }
    //
    //     }
    //
    //     return Recipe;
    // }
    //
    //
    //
    // public void printRecipe(List<string> Recipe)
    // {
    //     string recipe = null;
    //
    //     Recipe.ToString();
    //
    //
    //     foreach (var VARIABLE in Recipe)
    //     {
    //
    //         Console.WriteLine(VARIABLE);
    //
    //     }
    //
    //     Console.WriteLine(Recipe.ToString() + "array");
    //     Console.WriteLine(recipe);
    // }
    //
    // public List<string> Quantity(List<string> Recipe)
    // {
    //     Console.WriteLine("would you like to change the quatities of all the ingrediants ? type yes or no");
    //     string answer = Console.ReadLine();
    //
    //     if (answer == "yes")
    //     {
    //         // ReSharper disable once EmptyForStatement
    //         for (int i = 0; i < Recipe.Count; i++)
    //         {
    //             if (i > 3)
    //             {
    //                 int q = int.Parse(Recipe[i]);
    //                 int w = q * 2;
    //                 Recipe[i] = w.ToString();
    //                 i += 2;
    //             }
    //         }
    //     }
    //     return Recipe;
    // }
    //
    // public Tools()
    //     {
    //     
    //     }



}