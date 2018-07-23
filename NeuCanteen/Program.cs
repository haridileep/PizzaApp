using NeuCanteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuCanteen
{
    public delegate void Neupizzahandler();
    public class Program
    {
        public List<string> Cart { get; set; } = new List<string>();
        public event Neupizzahandler Bill;
        static void Main(string[] args)
        {
            int TotalCost = 0;
            bool menu = true;
            var side = new Side();
            var pizza = new Pizza();
            var bevarage = new Bevarage();
            var canteen = new NeuCanteenModel();
            var checkout = new Program();
            checkout.Bill += Purchase;
            while (menu == true)
            {
                Console.WriteLine("\n\n\t\t\tNeuPizzas");
                Console.WriteLine("\n1.Pizza \t2.Side  \t3.Bevarages \t4.Check Out");
                Console.WriteLine("Total Cost :\t");
                TotalCost = TotalCost + pizza.PizzaCost;
                TotalCost = TotalCost + side.SideCost;
                TotalCost = TotalCost + bevarage.BevarageCost;
                Console.WriteLine(TotalCost);
                pizza.PizzaCost = side.SideCost = bevarage.BevarageCost = 0;
                Console.WriteLine("\nEnter your Choice :\t");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (userChoice)
                {
                    case 1:
                        checkout.Cart.Add(pizza.SelectPizzaType());
                        break;
                    case 2:
                        checkout.Cart.Add(side.SelectSideType());
                        break;
                    case 3:
                        checkout.Cart.Add(bevarage.SelectBevarageType());
                        break;
                    case 4:
                        checkout.Bill?.Invoke();
                        break;
                    default:
                        menu = false;
                        break;
                }
            }
            void Purchase()
            {
                Console.Write("\n\n\tYour Cart\n");
                for (int cartItem = 0; cartItem < checkout.Cart.Count; cartItem++)
                {
                    Console.Write(checkout.Cart[cartItem]);
                    Console.Write("\n");
                }
                Console.Write("TotalCost : ");
                Console.Write(TotalCost);
                Console.ReadLine();
                throw new NotImplementedException();
            }
        }
    }
}
