using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace chooseyourOwnAdventure
{
    public partial class Form1 : Form
    {
        int scene = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void b(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.B)
            {
                outputLabel.Text = "";
                choiceRed.Text = "";
                choiceBlue.Text = "";
                choiceYellow.Text = "";
                Refresh();
                Thread.Sleep(200);
                if (scene == 0) { scene = 1; }
               else if (scene == 1) { scene = 11; }
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
                else if (scene == 20) { scene = 1; }
                
            }
            else if (e.KeyCode == Keys.N)
            {
                outputLabel.Text = "";
                choiceRed.Text = "";
                choiceBlue.Text = "";
                choiceYellow.Text = "";
                Refresh();
                Thread.Sleep(200);
                if (scene == 0) { this.Close(); }
                else if (scene == 1) { scene = 2; }
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
                else if (scene == 20) { this.Close(); }

            }
            else if (e.KeyCode == Keys.M)
            {
                outputLabel.Text = "";
                choiceRed.Text = "";
                choiceBlue.Text = "";
                choiceYellow.Text = "";
                Refresh();
                Thread.Sleep(200);
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
                case 0:
                    outputLabel.Text = "welcome to dungeon simulator";
                    choiceBlue.Text = "Begin";
                    choiceYellow.Text = "Close";
                    choiceRed.Text = "";
                    break;
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
                    choiceBlue.Text = "Continue";
                    choiceRed.Text = "";
                    choiceYellow.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "you begin to cry. The figure begins to walk out of the shadows, its... Tom Cruise??!?!?!??";
                    choiceBlue.Text = "Keep crying";
                    choiceYellow.Text = "Stop crying";
                    choiceRed.Text = "Mock him for his height";
                    break;
                case 5:
                    outputLabel.Text = "you continue to cry, You can see that this makes tom uncomfterble. he tells you to stop crying.";
                    choiceBlue.Text = "Stop crying";
                    choiceYellow.Text = "Continue crying";
                    choiceRed.Text = "";
                    break;
                case 6:
                    outputLabel.Text = "you continue to cry, You can see that this makes tom uncomfterble. he tells you to stop crying.";
                    choiceBlue.Text = "Stop crying";
                    choiceYellow.Text = "Continue crying";
                    choiceRed.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "you continue to cry, You can see that this makes tom uncomfterble. he tells you to stop crying.";
                    choiceBlue.Text = "Stop crying";
                    choiceYellow.Text = "Continue crying";
                    choiceRed.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "You've cried so much that Tom is visibly upset, he says 'Fine, just leave. Anything to make you stop crying'. you are let out of the dungeon and go about your life.";
                    choiceBlue.Text = "Continue";
                    choiceYellow.Text = "";
                    choiceRed.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "as you stop crying you see Tom is relieved. 'God, i hate when people cry, its icky.'";
                    choiceBlue.Text = "Start crying again";
                    choiceYellow.Text = "Mock him for his height";
                    choiceRed.Text = "Try to escape";
                    break;
                case 10:
                    outputLabel.Text = "You manage to slip out of the shackles and bolt for the door. The door is locked. you see tom slowly walk up behind you. you died";
                    choiceBlue.Text = "Continue";
                    choiceYellow.Text = "";
                    choiceRed.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "You begin to scream. 'WHO ARE YOU? WHERE AM I? LET ME OUT!' this continues for quite some time. Eventually the figure emerges from the shadows its... Tom Cruise?!!?!?!?";
                    choiceBlue.Text = "Question Tom";
                    choiceYellow.Text = "Mock his height";
                    choiceRed.Text = "Fake being a fan";
                    break;
                case 12:
                    outputLabel.Text = "You say 'No way!Tom Cruise? I'm your biggest fan! I loved you in Mission Impossible.' 'Really?' Tom replies. 'Name any other movie i was in.'";
                    choiceBlue.Text = "The Fast and the Furious";
                    choiceYellow.Text = "Iron Man";
                    choiceRed.Text = "Kingsmen";
                    break;
                case 13:
                    outputLabel.Text = "'Wrong!' Tom begins to shuffle towards you catch a glimpse of the rage in his eyes. you died.";
                    choiceBlue.Text = "Continue";
                    choiceYellow.Text = "";
                    choiceRed.Text = "";
                    break;
                case 14:
                    outputLabel.Text = "'um... sure, yeah i think.that sounds about right.' Tom seems to be thinking. Tom walks over to you, 'well i guess i cant chain up a fan in good conscious, you're free to go.'";
                    choiceBlue.Text = "Continue";
                    choiceYellow.Text = "";
                    choiceRed.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "You begin to chastise Tom about his height. 'shut up' tom mumbles. You call him a 'short baby-man.' this goes on for minutes. eventually Tom snaps, and lunges at you. the last thing you see is Tomff with tears streaming down his face. you died.";
                    choiceBlue.Text = "Continue";
                    choiceYellow.Text = "";
                    choiceRed.Text = "";
                    break;
                case 16:
                    outputLabel.Text = "You ask tom 'where am I?' He does not respond.";
                    choiceBlue.Text = "Ask him again";
                    choiceYellow.Text = "Try to escape";
                    choiceRed.Text = "Mock his height";
                    break;
                case 17:
                    outputLabel.Text = "you try to break out of your shackles, tom warns you 'don't try it.'";
                    choiceBlue.Text = "Give up";
                    choiceYellow.Text = "Keep pulling on the shackles";
                    choiceRed.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "you give up, and live the rest of your life locked in the dungeon.";
                    choiceBlue.Text = "Continue";
                    choiceYellow.Text = "";
                    choiceRed.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "Tom says 'I warned you' he then starts  walking towards you. You died";
                    choiceBlue.Text = "Continue";
                    choiceYellow.Text = "";
                    choiceRed.Text = "";
                    break;
                case 20:
                    outputLabel.Text = "Game Over! would you like to play again?";
                    choiceBlue.Text = "Yes";
                    choiceYellow.Text = "No";
                    choiceRed.Text = "";
                    break;
                case 21:
                    outputLabel.Text = "tom starts to rant 'ok, you know what, i'm out of here. I show up every day just to do my job and every time people start crying. You dont deserve me.' you live out the rest of your life in the dungeon.";
                    choiceBlue.Text = "Continue";
                    choiceYellow.Text = "";
                    choiceRed.Text = "";
                    break;
            }
        }




    }
}
