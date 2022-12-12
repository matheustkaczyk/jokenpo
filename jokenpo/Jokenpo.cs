using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jokenpo
{
    internal class Jokenpo
    {
        public List<string> options = new List<string>(3)
        {
            "Pedra",
            "Papel",
            "Tesoura"
        };

        public int pickN1;
        public int pickN2;

        public void roll()
        {
            Random rand = new Random();
            pickN1 = rand.Next(0, 3);
            pickN2 = rand.Next(0, 3);
        }
    }
}
