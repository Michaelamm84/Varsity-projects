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

        public List<string> Editingrediants(List<string> Recipe)
        {
            Console.WriteLine("is there a particular ingrdiant you would like to change ? answer with yes or no");

            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("which ingrediant ?");
                
                foreach (var item in Recipe)
                {
                    
                    if (item == Console.ReadLine())
                    {
                        int a = Recipe.IndexOf(item);
                        
                        Console.WriteLine("what would you like to change the ingrediant to ?");

                        string hello = Console.ReadLine();

                        Recipe[a] = hello;

                        
                    }

                    return Recipe;
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
   

        public Tools()
        {
        
        }



}