using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuCanteen;

namespace NeuCanteen
{
    public class Pizza : Program
    {

        public void PizzaType()
        {
            Console.WriteLine("\n\n\t\tPizzA");
            Console.WriteLine("\n1.Veg \t2.Non Veg\n");
            Console.WriteLine("\nEnter your Choice :\t");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("\n\n\t\tVeg PizzA");
                    Console.WriteLine("\n1.Regular\t2.Medium\t3.Large\n");
                    Console.WriteLine("\nEnter your Choice :\t");
                    int pizzaSize = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if(pizzaSize == 1)
                        PizzaCost = 150;
                    else if (pizzaSize == 2)
                        PizzaCost = 250;
                    else
                        PizzaCost = 350;
                    break;

                case 2:
                    Console.WriteLine("\n\n\t\tNon Veg PizzA");
                    Console.WriteLine("\n1.Regular\t2.Medium\t3.Large\n");
                    Console.WriteLine("\nEnter your Choice :\t");
                    pizzaSize = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (pizzaSize == 1)
                        PizzaCost = 100;
                    else if (pizzaSize == 2)
                        PizzaCost = 200;
                    else
                        PizzaCost = 300;
                    break;

                default:
                    break;

            }


                   }
    }

    
}
