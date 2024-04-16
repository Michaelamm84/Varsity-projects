namespace PoePt1;

public class Tools
{


    public List<string> CreateList(List<string> Recipe)
    {

        List<string> Ing = new List<string>();
        string numberOfIngrediants = null;
        int? numIng = null;

        Console.WriteLine("hello what is the name of your Recipe ?");

        Recipe.Add(Console.ReadLine());

        Console.WriteLine("how many ingrediants in your recipe ?");

        numberOfIngrediants = Console.ReadLine();

        Recipe.Add(numberOfIngrediants);


        numIng = int.Parse(numberOfIngrediants);
        for (int i = 0; i < numIng; i++)
        {
            Console.WriteLine("what is the name of the ingrdiant");
            Recipe.Add(Console.ReadLine());

            Console.WriteLine("what is the unit of measuremt for this ingrdiant");
            Recipe.Add(Console.ReadLine());

            Console.WriteLine("how many units of the ingrdiant?");
            Recipe.Add(Console.ReadLine());
        }
        
        
        return Recipe;
    }

    public List<string> EditingrediantsName(List<string> Recipe)
    {
        Console.WriteLine("is there a particular ingrdiant you would like to change ? answer with yes or no");

        if (Console.ReadLine() == "yes")
        {
            Console.WriteLine("which ingrediant ?");

            string test = Console.ReadLine();
            
            for (int i = 0; i <= Recipe.Count; i++)
            {

                if (test == Recipe[i])
                {
                    Console.WriteLine("what would you like to change the ingrediant to ?");
                    string hello = Console.ReadLine();
                    Recipe[i] = hello;


                    break;


                }


            }

        }

        return Recipe;
    }

    

    public void printRecipe(List<string> Recipe)
    {
        string recipe = null;

        Recipe.ToString();


        foreach (var VARIABLE in Recipe)
        {

            Console.WriteLine(VARIABLE);

        }

        Console.WriteLine(Recipe.ToString() + "array");
        Console.WriteLine(recipe);
    }

    public List<string> Quantity(List<string> Recipe)
    {
        Console.WriteLine("would you like to change the quatities of all the ingrediants ? type yes or no");
        string answer = Console.ReadLine();

        if (answer == "yes")
        {
            // ReSharper disable once EmptyForStatement
            for (int i = 0; i < Recipe.Count; i++)
            {
                if (i > 3)
                {
                    int q = int.Parse(Recipe[i]);
                    int w = q * 2;
                    Recipe[i] = w.ToString();
                    i += 2;
                }
            }
        }
        return Recipe;
    }
    
    public Tools()
        {
        
        }



}