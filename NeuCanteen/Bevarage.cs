using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuCanteen
{
    public class Bevarage : Program
    {

        public void BevarageType()
        {
            Console.WriteLine("\n\n\t\tSidE");
            Console.WriteLine("\n1.Coke :40 \n2.Sprite :40\n");
            Console.WriteLine("\nEnter your Choice :\t");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (userChoice)
            {
                case 1:
                    BevarageCost = 40;
                    break;

                case 2:
                    BevarageCost = 40;
                    break;

                default:
                    break;

            }


        }
    }
}
