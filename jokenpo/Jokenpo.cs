using System;
using System.Collections.Generic;
using System.Drawing;
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

        enum images
        {

        }

        public int pickN1;
        public int pickN2;

        public Image rockImage = Image.FromFile("C:\\Users\\PC\\source\\repos\\jokenpo\\jokenpo\\assets\\pedra.png");
        public Image paperImage = Image.FromFile("C:\\Users\\PC\\source\\repos\\jokenpo\\jokenpo\\assets\\papel.png");
        public Image scissorsImage = Image.FromFile("C:\\Users\\PC\\source\\repos\\jokenpo\\jokenpo\\assets\\tesoura.png");

        public void roll()
        {
            Random rand = new Random();
            pickN1 = rand.Next(0, 3);
            pickN2 = rand.Next(0, 3);
        }
    }
}
