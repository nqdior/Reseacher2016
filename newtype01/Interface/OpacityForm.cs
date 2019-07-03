using System;
using System.Windows.Forms;

namespace NewType.Seeker.Interface
{
    public partial class OpacityForm : Form
    {
        MainForm main;

        public OpacityForm(ref double opacity, MainForm main)
        {
            InitializeComponent();

            Opacity = opacity;
            this.main = main;
            BackColor = main.BackColor;

            trackBar1.BackColor = main.BackColor;
            trackBar1.Value = (int)(opacity * 10);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 0) { trackBar1.Value = 1; }

            Opacity = trackBar1.Value * 0.1;
            main.Opacity = Opacity;
        }

        private void trackBar1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left || e.KeyData == Keys.Right) { return; }

            Close();           
        }
    }
}
