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
                Console.WriteLine("\n\n\t\t\tNeuPizzA");
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
                        pizza.SelectPizzaType();
                        break;
                    case 2:
                        side.SelectSideType();
                        break;
                    case 3:
                        bevarage.SelectBevarageType();
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
                for (int cartItem = 0; cartItem < canteen.Cart.Count; cartItem++)
                {
                    Console.Write(canteen.Cart[cartItem]);
                }
                Console.ReadLine();
                Console.Write("TotalCost : ");
                Console.Write(TotalCost);
                Console.ReadLine();
                throw new NotImplementedException();
            }
        }
    }
}
