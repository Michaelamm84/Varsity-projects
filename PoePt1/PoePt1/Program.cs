
namespace PoePt1
{
    public class main
    {

        static void Main(string[] args)
        {
            List<string> Recipe = new List<string>();
            
            Tools tools = new Tools();

            tools.CreateList(Recipe);
            
            tools.printRecipe(Recipe);

            tools.EditingrediantsName(Recipe);
            
            tools.printRecipe(Recipe);
            
            tools.Quantity(Recipe);
            
            tools.printRecipe(Recipe);
            
            Console.WriteLine("Hello, World!");

        }





    }
}