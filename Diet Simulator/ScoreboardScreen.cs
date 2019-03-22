using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diet_Simulator
{
    public partial class ScoreboardScreen : UserControl
    {
        //lists and variables
        static List<string> letters = new List<string>(new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
        static List<string> names = new List<string>();
        static int FDOrder = 0;
        static int SDOrder = 0;
        static int TDOrder = 0;
        string name;
        int counter = 1;
        string FD = letters[FDOrder];
        string SD = letters[SDOrder];
        string TD = letters[TDOrder];
        Boolean upArrowDown, downArrowDown, spaceDown;


        public ScoreboardScreen()
        {
            InitializeComponent();
            fdBorder.Visible = false;
            sdBorder.Visible = false;
            tdBorder.Visible = false;
        }

        //tracking key presses
        private void ScoreboardScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Form F = this.FindForm();
                    F.Controls.Remove(this);

                    MainScreen ms = new MainScreen();
                    F.Controls.Add(ms);
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Enter:
                    spaceDown = true;
                    break;
            }
        }

        private void ScoreboardScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Enter:
                    spaceDown = false;
                    break;
            }
        }

        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            //tracks the counter of how many times space has been presses
            if (spaceDown == true)
            {
                counter++;
            }

            //sets the labels to the letter they should be
            nameLabel1.Text = FD;
            nameLabel2.Text = SD;
            nameLabel3.Text = TD;

            //makes the boarders visable
            if(counter == 1)
            {
                fdBorder.Visible = true;
            }

            if (counter == 2)
            {
                fdBorder.Visible = false;
                sdBorder.Visible = true;
            }

            if (counter == 3)
            {
                sdBorder.Visible = false;
                tdBorder.Visible = true;
            }

            //tracks the arrows to change the letter
            if (upArrowDown == true && counter == 1)
            {
                FDOrder++;
            }

            if (upArrowDown == true && counter == 2)
            {
                SDOrder++;
            }

            if (upArrowDown == true && counter == 3)
            {
                TDOrder++;
            }

            if (FDOrder == 26)
            {
                FDOrder = 0;
            }

            if (SDOrder == 26)
            {
                SDOrder = 0;
            }

            if (TDOrder == 26)
            {
                TDOrder = 0;
            }

            FD = letters[FDOrder];
            SD = letters[SDOrder];
            TD = letters[TDOrder];

            //adds the name to the list
            if (counter == 4)
            {
                name = FD + SD + TD;
                nameLabel1.Visible = false;
                nameLabel2.Visible = false;
                nameLabel3.Visible = false;
                fdBorder.Visible = false;
                sdBorder.Visible = false;
                tdBorder.Visible = false;
                names.Add(name);
                counter++;
            }

            //displays names
            for (int i = 0; i < names.Count(); i++)
            {
                outputLabel.Text += "\n" + names[i];
            }
        }


    }
}
