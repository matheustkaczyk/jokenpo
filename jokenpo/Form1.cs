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
                MessageBox.Show("Você venceu!");
                p1Score += 1;
                label5.Text = $"Pontuação = {p1Score}";
                label6.Text = $"Pontuação = {p2Score}";
            } else if(game.options[game.pickN1] == game.options[game.pickN2])
            {
                MessageBox.Show("Empatou!");
            } else
            {
                MessageBox.Show("Voce perdeu!");
                p2Score += 1;
                label5.Text = $"Pontuação = {p1Score}";
                label6.Text = $"Pontuação = {p2Score}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.roll();

            label1.Text = game.options[game.pickN1];
            label2.Text = game.options[game.pickN2];
            winner();
        }
    }
}
