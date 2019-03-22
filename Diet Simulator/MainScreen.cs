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
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form F = this.FindForm();
            F.Controls.Remove(this);

            gameScreen gs = new gameScreen();
            F.Controls.Add(gs);
            gs.Focus();
        }

        private void insButton_Click(object sender, EventArgs e)
        {
            Form F = this.FindForm();
            F.Controls.Remove(this);

            InstructionsScreen Is = new InstructionsScreen();
            F.Controls.Add(Is);
            Is.Focus();
        }

        private void scorButton_Click(object sender, EventArgs e)
        {
            Form F = this.FindForm();
            F.Controls.Remove(this);

            ScoreboardScreen ss = new ScoreboardScreen();
            F.Controls.Add(ss);
            ss.Focus();

        }
    }
}
