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

        public void SelectPizzaType()
        {
            var canteen = new NeuCanteenModel();
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
                    if (pizzaSize == 1)
                    {
                        PizzaCost = 150;
                        Cart.Add("Veg Regular Pizza = 150");
                    }
                    else if (pizzaSize == 2)
                    {
                        PizzaCost = 250;
                       Cart.Add("Veg Medium Pizza = 250");
                    }

                    else
                    {
                        PizzaCost = 350;
                        Cart.Add("Veg Large Pizza = 350");
                    }
                    break;

                case 2:
                    Console.WriteLine("\n\n\t\tNon Veg PizzA");
                    Console.WriteLine("\n1.Regular\t2.Medium\t3.Large\n");
                    Console.WriteLine("\nEnter your Choice :\t");
                    pizzaSize = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (pizzaSize == 1)
                    {
                        PizzaCost = 200;
                       Cart.Add("Non Veg Small Pizza = 200");
                    }
                    else if (pizzaSize == 2)
                    {
                        PizzaCost = 300;
                        Cart.Add("Non Veg Medium Pizza = 300");
                    }
                    else
                    {
                        PizzaCost = 400;
                        Cart.Add("Non Veg Medium Pizza = 400");
                    }
                    break;
                default:
                    break;
            }
        }
    }  
}
