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
            int randN1 = rand.Next(0, 3);
            int randN2 = rand.Next(0, 3);

            pickN1 = randN1;
            pickN2 = randN2;
        }
    }
}
