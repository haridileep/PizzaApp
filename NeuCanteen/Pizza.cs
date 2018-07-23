using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuCanteen;
using NeuCanteen.Models;

namespace NeuCanteen
{
    public class Pizza : NeuCanteenModel
    {
        public string SelectPizzaType()
        {
            string pizzaChoice = "";
            Console.WriteLine("\n\n\t\tPizzas");
            Console.WriteLine("\n1.Veg \t2.Non Veg\n");
            Console.WriteLine("Enter your Choice : ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("\n\n\t\tVeg Pizzas");
                    Console.WriteLine("\n1.Regular\t2.Medium\t3.Large\n");
                    Console.WriteLine("\nEnter your Choice :\t");
                    int pizzaSize = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (pizzaSize == 1)
                    {
                        PizzaCost = 150;
                        pizzaChoice = "Veg Regular Pizza : 150";
                        break;
                    }
                    else if (pizzaSize == 2)
                    {
                        PizzaCost = 250;
                        pizzaChoice = "Veg Medium Pizza : 250";
                        break;
                    }
                    else
                    {
                        PizzaCost = 350;
                        pizzaChoice = "Veg Large Pizza : 350";
                        break;
                    }
               case 2:
                    Console.WriteLine("\n\n\t\tNon Veg Pizzas");
                    Console.WriteLine("\n1.Regular\t2.Medium\t3.Large\n");
                    Console.WriteLine("\nEnter your Choice :\t");
                    pizzaSize = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (pizzaSize == 1)
                    {
                        PizzaCost = 200;
                        pizzaChoice = "Non Veg Regular Pizza : 200";
                        break;
                    }
                    else if (pizzaSize == 2)
                    {
                        PizzaCost = 300;
                        pizzaChoice = "Non Veg Medium Pizza : 300";
                        break;
                    }
                    else
                    {
                        PizzaCost = 400;
                        pizzaChoice = "Non Veg Large Pizza : 400";
                        break;
                    }
                default:
                    break;
            }
            return pizzaChoice;
        }
    }  
}
