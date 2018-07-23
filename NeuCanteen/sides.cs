using NeuCanteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuCanteen
{
    public class Side : NeuCanteenModel
    {
        public string SelectSideType()
        {
            string sideChoice = "";
            Console.WriteLine("\n\n\t\t\tSides");
            Console.WriteLine("\n1.Nugget :130 \t2.French Fries :150");
            Console.WriteLine("\nEnter your Choice :");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (userChoice)
            {
                case 1:
                    SideCost = 130;
                    sideChoice = "Nugget : 130";
                    break;
       
                case 2:
                    SideCost = 150;
                    sideChoice = "French fries : 150" ;
                    break;
                default:
                    break;
            }
            return sideChoice;
        }
    }
}
