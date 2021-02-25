using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chooseyourOwnAdventure
{
    public partial class Form1 : Form
    {
        int scene = 1;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void b(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                if (scene == 1) { scene = 11; }
                else if (scene == 2) { scene = 2; }
                else if (scene == 3) { scene = 20; }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 21; }
                else if (scene == 6) { scene = 21; }
                else if (scene == 7) { scene = 21; }
                else if (scene == 8) { scene = 20; }
                else if (scene == 9) { scene = 6; }
                else if (scene == 10) { scene = 20; }
                else if (scene == 11) { scene = 16; }
                else if (scene == 12)
                {
                    int chance = rnd.Next(1, 11);
                    if (chance == 1)
                    {
                        scene = 14;
                    }
                    else
                    {
                        scene = 13;
                    }
                }
                else if (scene == 13) { scene = 20; }
                else if (scene == 14) { scene = 20; }
                else if (scene == 15) { scene = 20; }
                else if (scene == 16) { scene = 16; }
                else if (scene == 18) { scene = 20; }
                else if (scene == 19) { scene = 20; }
                else if (scene == 21) { scene = 20; }
            }
            else if (e.KeyCode == Keys.N)
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 3; }
                else if (scene == 4) { scene = 9; }
                else if (scene == 5) { scene = 6; }
                else if (scene == 6) { scene = 7; }
                else if (scene == 7) { scene = 8; }
                else if (scene == 9) { scene = 15; }
                else if (scene == 11) { scene = 15; }
                else if (scene == 12)
                {
                    int chance = rnd.Next(1, 11);
                    if (chance == 1)
                    {
                        scene = 14;
                    }
                    else
                    {
                        scene = 13;
                    }
                }
                else if (scene == 16) { scene = 17; }
                else if (scene == 17) { scene = 18; }
            }
            else if (e.KeyCode == Keys.M)
            {
                if (scene == 1) { scene = 1; }
                else if (scene == 2) { scene = 4; }
                else if (scene == 4) { scene = 15; }
                else if (scene == 9) { scene = 10; }
                else if (scene == 11) { scene = 12; }
                else if (scene == 12)
                {
                    int chance = rnd.Next(1, 11);
                    if (chance == 1)
                    {
                        scene = 14;
                    }
                    else
                    {
                        scene = 13;
                    }
                }
                else if (scene == 16) { scene = 15; }
                else if (scene == 17) { scene = 19; }
            }

            switch (scene)
            {
                case 1:
                    outputLabel.Text = "You wake up in an unfamiliar place. you're shackled to the wall, and you see a small figure glaring at you from the shadows";
                    choiceBlue.Text = "Freak out";
                    choiceYellow.Text = "Question the figure";
                    choiceRed.Text = "Go back to sleep";
                    break;
                case 2:
                    outputLabel.Text = "you ask the figure 'why am i here?' it does not respond.";
                    choiceBlue.Text = "Ask again";
                    choiceYellow.Text = "Give them the silent treatment";
                    choiceRed.Text = "cry";
                    break;
                case 3:
                    outputLabel.Text = "You remain silent, in an attempt to goad them into talking to you. You are so petty that you remain silent for the rest of your life.";
                    choiceBlue.Text = "Game Over";
                    choiceRed.Text = "";
                    choiceYellow.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "you begin to cry. The figure begins to walk out of the shadows, its... Tom Cruise??!?!?!??";
                    choiceBlue.Text = "Keep crying";
                    choiceYellow.Text = "Stop Crying";
                    choiceRed.Text = "Mock him for his height";
                    break;


            }
        }




    }
}
