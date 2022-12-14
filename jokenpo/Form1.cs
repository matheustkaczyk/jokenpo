using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jokenpo
{
    public partial class Form1 : Form
    {
        Jokenpo game = new Jokenpo();
        int p1Score = 0;
        int p2Score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void winner()
        {
            if (
                (game.options[game.pickN1] == "Pedra" && game.options[game.pickN2] == "Tesoura") ||
                (game.options[game.pickN1] == "Tesoura" && game.options[game.pickN2] == "Papel") ||
                (game.options[game.pickN1] == "Papel" && game.options[game.pickN2] == "Pedra")
                )
            {

                p1Score += 1;
                label7.Text = "Você venceu!";
                label5.Text = $"Pontuação = {p1Score}";
                label6.Text = $"Pontuação = {p2Score}";
            } else if(game.options[game.pickN1] == game.options[game.pickN2])
            {
                label7.Text = "Empatou!";
            } else
            {
                p2Score += 1;
                label7.Text = "Você perdeu!";
                label5.Text = $"Pontuação = {p1Score}";
                label6.Text = $"Pontuação = {p2Score}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.roll();
            label1.Text = game.options[game.pickN1];
            label2.Text = game.options[game.pickN2];

            switch(game.pickN1)
            {
                case 0:
                    pictureBox1.Image = game.rockImage;
                    break;
                case 1:
                    pictureBox1.Image = game.paperImage;
                    break;
                case 2:
                    pictureBox1.Image = game.scissorsImage;
                    break;
            }

            switch (game.pickN2)
            {
                case 0:
                    pictureBox2.Image = game.rockImage;
                    break;
                case 1:
                    pictureBox2.Image = game.paperImage;
                    break;
                case 2:
                    pictureBox2.Image = game.scissorsImage;
                    break;
            }

            winner();
        }
    }
}
