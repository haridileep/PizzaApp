using NeuCanteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuCanteen
{
    public class Bevarage :NeuCanteenModel
    {  
        public string SelectBevarageType()
        {
            string bevarageChoice = "";
            Console.WriteLine("\n\n\t\tBevarages");
            Console.WriteLine("\n1.Coke :40 \t2.Sprite :40\n");
            Console.WriteLine("\nEnter your Choice :\t");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (userChoice)
            {
                 case 1:
                       BevarageCost = 40;
                       bevarageChoice="Coke : 40";
                       break;
                 case 2:
                       BevarageCost = 40;
                       bevarageChoice = "Sprite : 40";
                       break;
                 default:
                       break;
            }
            return bevarageChoice;
        }
    }
}
