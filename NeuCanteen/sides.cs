using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuCanteen
{
    public class Side : Program
    {

        public void SideType()
        {
            Console.WriteLine("\n\n\t\t\tSidE");
            Console.WriteLine("\n1.Nugget :130 \t2.French Fries :150");
            Console.WriteLine("\nEnter your Choice :");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (userChoice)
            {
                case 1:
                    SideCost = 130;
                    ItemList.Add("Nugget : 130");
                    break;
       
                case 2:
                    SideCost = 150;
                    ItemList.Add("French fries : 150");
                    break;
                default:
                    break;

            }


        }
    }
}
