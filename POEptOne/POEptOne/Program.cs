namespace POEptOne;

class Program
{
    static void Main(string[] args)
    {

        string menu = null;
        int menuNum;
        
        Console.WriteLine("welcome to recipe maker:" +
                          "\n enter '1' to add new recipe" +
                          "\n enter '2' to change details of a saved recipe" +
                          "\n enter '3' to display full recipe ");

        menu = Console.ReadLine();
        
        menuNum = int.Parse(menu);

        if (menuNum == 1)
        {
            Recipe recipe = new Recipe();

            Console.WriteLine("Enter recipe name ");
            recipe.name = Console.ReadLine();

            Console.WriteLine("Enter number of ingrediants: ");
            

        } 
        else if (menuNum == 2)
        {
            
        }



    
    Console.WriteLine(recipe.name);


} 

}
