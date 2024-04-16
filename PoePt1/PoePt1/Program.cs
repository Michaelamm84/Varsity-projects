
namespace PoePt1
{
    public class main
    {

        static void Main(string[] args)
        {
     
        
        //variables 

        List<Ingredients> ingss = new List<Ingredients>();
        List<Ingredients> origIngredientsList = new List<Ingredients>();
        List<String> stepsList = new List<string>();
        Recipe recipe = new Recipe();
        string menu = null;
        string IngName = null;
        string Quant = null;
        int Amount = 0;
        string oIngName = null;
        string oQuant = null;
        int oAmount = 0;
        string name = null;
        int menuNum = 0;

        // A while loop to keep my menu active

        while (menuNum != 5)
        {
            Console.WriteLine("welcome to recipe maker:" +
                              "\n enter '1' to create new recipe" +
                              "\n enter '2' to change details of a saved recipe" +
                              "\n enter '3' to display full recipe " +
                              "\n enter '4' ro return recipe to original values" +
                              "\n enter '5' to exit"
            );

            menu = Console.ReadLine();

            menuNum = int.Parse(menu);
            
            switch (menuNum)
            {
                
                //case 1 is adding a new recipe
                case 1:
                    // using for loops to wipe strings of previous recipe 
                    for (int i = 0; i < ingss.Count; i++)
                    {
                        ingss.RemoveAt(i);
                    }
                    
                    for (int i = 0; i < origIngredientsList.Count; i++)
                    {
                        origIngredientsList.RemoveAt(i);
                    }


                    name = null;
                    new Recipe();

                    int ing = 0;

                    Console.WriteLine("Enter recipe name ");
                    name = Console.ReadLine();
                    

                    Console.WriteLine("Enter number of ingrediants: ");
                    recipe.ingredients = int.Parse(Console.ReadLine());
                    
                    
                    //using a for loop to capture ingredients


                    for (int i = 1; i <= recipe.ingredients; i++)
                    {
                        
                        
                        //using a class to capture recipe 



                        Console.WriteLine("What is the name of the ingrediant you would like to add");
                        IngName = Console.ReadLine();
                        oIngName = IngName;
                        
                        Console.WriteLine("What metric would you like to use ?" +
                                          "\n enter between teaspoons, cups or liters ");
                        Quant = Console.ReadLine();
                        oQuant = Quant;

                        
                        
                        Console.WriteLine("How many of the previous metric would you like to add");
                        Amount = int.Parse(Console.ReadLine());
                        oAmount = Amount;
                        Console.WriteLine(IngName);

                       
                        Ingredients ings = new Ingredients(IngName, Quant, Amount);
                        Ingredients oIngs = new Ingredients(oIngName, oQuant, oAmount);
                        

                        ingss.Add(ings);
                        origIngredientsList.Add(oIngs);

                    }
                    //using a string list to capture steps 
                    Console.WriteLine("how many steps does the recipe have ?");
                    int steps = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= steps; i++)
                    {
                        Console.WriteLine($"please enter the {i}th step details ");
                        stepsList.Add(Console.ReadLine());
                    }
                    

                    break;
            
                case 2:
                    
                    //implementing a method that scales ingredient 

                    recipe.editList(ingss);
                
                    break;
            
            
                case 3 :
                    //printing recipe 

                    Console.WriteLine($"Recipe Name  : {name}");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine(" Ingredients: ");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"{recipe.PrintIngredients(ingss)}");
                    Console.WriteLine("-------------------"+"\n Steps:");
                    Console.WriteLine($"\n {printSteps(stepsList)}");
                    
                
                    break;
                
                case 4:
                    
                   // case four resets recipe to original amounts 
                    recipe.SaveOrigionals(ingss, origIngredientsList);
                   
                    break;
                
                case 5:

                   //case 5 exists program 
                   
                    break;
                


            }
        }
        //printing steps method
        List<String> printSteps(List<string> stepsList)
        {
           
            for (int i = 0; i < stepsList.Count; i++)
            {
                Console.WriteLine($"the {i + 1}th step: {stepsList[i]}" +
                                  $"\n -------------------------");
            }

            return stepsList;
        }
    }
    
            
            
            
            // List<string> Recipe = new List<string>();
            //
            // Tools tools = new Tools();
            //
            // tools.CreateList(Recipe);
            //
            // tools.printRecipe(Recipe);
            //
            // tools.EditingrediantsName(Recipe);
            //
            // tools.printRecipe(Recipe);
            //
            // tools.Quantity(Recipe);
            //
            // tools.printRecipe(Recipe);
            //
            // Console.WriteLine("Hello, World!");

        }





    }
