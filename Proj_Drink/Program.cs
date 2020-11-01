using System;

namespace Proj_Drink
{
    class Program
    {
        /**/
        static void Main(string[] args)
        {
            //var drinks = new List<Drink> //Test
            //{
            //    new Juice("Orange Juice", "not carbonated", "made from oranges."),
            //    new Beer("Budweiser", "carbonated", 5.0),
            //    new Soda("Pepsi", "carbonated")

            //};
            Drink[] drinks = new Drink[3]; 
            drinks[0] = new Juice("Orange Juice", "not carbonated", "made from oranges.");
            drinks[1] = new Beer("Budweiser", "carbonated", 5.0);
            drinks[2] = new Soda("Pepsi", "carbonated");

            foreach(var drink in drinks)
            {
                Console.WriteLine(drink.description());
                
            }

            
            
            
            
            Console.Read();
           
           

        }
    }
}
