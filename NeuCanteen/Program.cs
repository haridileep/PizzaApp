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
        
        public List<string> ItemList { get; set; } = new List<string>();
   
        public int PizzaCost { get; set; }
        public int SideCost { get; set; }
        public int BevarageCost { get; set; }
        public int CostSide { get; set; }
        public int CostBevarage { get; set; }
        public event Neupizzahandler Bill;


        static void Main(string[] args)
        {
            
            int TotalCost=0;
       
        var side = new Side();
        var pizza = new Pizza();
        var bevarage = new Bevarage();
        

        

      menu:
            var checkout = new Program();
            checkout.Bill += Purchase;
            Console.WriteLine("\n\n\t\t\tNeuPizzA");
            Console.WriteLine("\n1.Pizza \t2.Side  \t3.Bevarages \t4.Check Out");
            Console.WriteLine("Total Cost :\t");
            TotalCost = TotalCost + pizza.PizzaCost;
            TotalCost = TotalCost + side.SideCost;
            TotalCost = TotalCost + bevarage.BevarageCost;
            Console.WriteLine(TotalCost);
            pizza.PizzaCost = side.SideCost = bevarage.BevarageCost =0;
            Console.WriteLine("\nEnter your Choice :\t");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (userChoice)
            {
                case 1:
                    pizza.PizzaType();
                    goto menu;
                case 2:
                    side.SideType();
                    goto menu;

                case 3:
                    bevarage.BevarageType();
                    goto menu;
                case 4:
                    checkout.Bill?.Invoke();
                    break;
                default:
                    break;
            }

            void Purchase()
            {
                
                Console.Write("TotalCost : ");
                Console.Write(TotalCost);
                Console.ReadKey();
                throw new NotImplementedException();
            }

        }

       


        
    }
   
}
