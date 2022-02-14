using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperRockScissor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int ScoreUser = 0;
        int ScoreComputer = 0;
        private void btnRock_Click(object sender, EventArgs e)
        {
            int q = Game();

            int a = 1;
            

            if (a == 1)
            {
                pbxPlayer.ImageLocation = "D:\\Masaüstü\\CSharpProjelerim\\TaşKağıtMakas\\Images\\Rock.png";
                if (q == 3)
                {
                    pbxComputer.ImageLocation = "D:\\Masaüstü\\CSharpProjelerim\\TaşKağıtMakas\\Images\\Scissors.png";
                    ScoreUser += 1;
                    lblScorePlayer.Text = (Convert.ToString(ScoreUser));
                }
                if (q == 2)
                {
                    pbxComputer.ImageLocation = "D:\\Masaüstü\\CSharpProjelerim\\TaşKağıtMakas\\Images\\Paper.png";
                    ScoreComputer += 1;
                    lblScoreComputer.Text = (Convert.ToString(ScoreComputer));
                }
                if (q==1)
                {
                    pbxComputer.ImageLocation = "D:\\Masaüstü\\CSharpProjelerim\\TaşKağıtMakas\\Images\\Rock.png";
                }

            }

            
            

        }

        private static int Game()
        {
            int q;
            Random random = new Random();
            q = random.Next(1, 4);
            return q;
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            int q = Game();
            int b = 2;
            if (b == 2)
            {
                pbxPlayer.ImageLocation = "D:\\Masaüstü\\CSharpProjelerim\\TaşKağıtMakas\\Images\\Paper.png";
                if (q == 1)
                {
                    pbxComputer.ImageLocation = "D:\\Masaüstü\\CSharpProjelerim\\TaşKağıtMakas\\Images\\Rock.png";
                    ScoreUser += 1;
                    lblScorePlayer.Text = (Convert.ToString(ScoreUser));
                }
                if (q == 3)
                {
                    pbxComputer.ImageLocation = "D:\\Masaüstü\\CSharpProjelerim\\TaşKağıtMakas\\Images\\Scissors.png";
                    ScoreComputer += 1;
                    lblScoreComputer.Text = (Convert.ToString(ScoreComputer));
                }
                if (q==2)
                {
                    pbxComputer.ImageLocation = "D:\\Masaüstü\\CSharpProjelerim\\TaşKağıtMakas\\Images\\Paper.png";
                }

            }
            
            
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            int q = Game();
            int c = 3;
            if (c == 3)
            {
                pbxPlayer.ImageLocation = "D:\\Masaüstü\\CSharpProjelerim\\TaşKağıtMakas\\Images\\Scissors.png";
                if (q == 2)
                {
                    pbxComputer.ImageLocation = "D:\\Masaüstü\\CSharpProjelerim\\TaşKağıtMakas\\Images\\Paper.png";
                    ScoreUser += 1;
                    lblScorePlayer.Text = (Convert.ToString(ScoreUser));
                }
                if (q == 1)
                {
                    pbxComputer.ImageLocation = "D:\\Masaüstü\\CSharpProjelerim\\TaşKağıtMakas\\Images\\Rock.png";
                    ScoreComputer += 1;
                    lblScoreComputer.Text = (Convert.ToString(ScoreComputer));
                }
                if (q==3)
                {
                    pbxComputer.ImageLocation = "D:\\Masaüstü\\CSharpProjelerim\\TaşKağıtMakas\\Images\\Scissors.png";
                }
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblScorePlayer.Text = "-";
            lblScoreComputer.Text = "-";
            ScoreUser = 0;
            ScoreComputer = 0;
        }
    }
}
