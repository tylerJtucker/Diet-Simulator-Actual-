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
    public partial class InstructionsScreen : UserControl
    {

        public InstructionsScreen()
        {
            InitializeComponent();
        }

        private void InstructionsScreen_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Form F = this.FindForm();
                    F.Controls.Remove(this);

                    MainScreen ms = new MainScreen();
                    F.Controls.Add(ms);
                    break;
            }
        }
    }
}
