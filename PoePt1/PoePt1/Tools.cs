namespace PoePt1;

public class Tools
{
    

        public List<string> CreateList(List<string> Recipe)
        {
        
            Console.WriteLine("hello what is the name of your Recipe ?");
        
            Recipe.Add(Console.ReadLine());
        
            Console.WriteLine("how many ingrediants in your recipe ?");
        
            Recipe.Add(Console.ReadLine());
        
            Console.WriteLine("what is the name of the ingrediant ");
        
        
        
        
            return Recipe;
        }

        public void printRecipe(List<string> Recipe)
        {
            string recipe = null;

            recipe = Recipe.ToString();


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