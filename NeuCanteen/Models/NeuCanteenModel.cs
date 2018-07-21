using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuCanteen.Models
{
   public class NeuCanteenModel
    {
        public List<string> ItemList { get; set; } = new List<string>();
        public int PizzaCost { get; set; }
        public int SideCost { get; set; }
        public int BevarageCost { get; set; }

    }
}
