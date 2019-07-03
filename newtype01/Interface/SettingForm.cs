using NewType.Seeker.Interface.Common;
using System;
using System.Windows.Forms;
using NewType.Seeker.Properties;

namespace NewType.Seeker.Interface
{
    public partial class SettingForm : Form
    {
        MainForm form;

        public SettingForm(MainForm form)
        {
            InitializeComponent();

            comboBox1.Items.Add("Shinra");
            comboBox1.Items.Add("Reseach");
            comboBox1.Items.Add("Default");

            this.form = form;
            TopMost = true;
            comboBox1.Text = Settings.Default.color;
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            rightNewLine.Checked = form.rightNewLine;
            newLine.Checked = form.useNewLine;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            FormManager.ConvertMessagePoint(ref m, this);
        }

        private void menuBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormManager.ConvertMessageMove(e, Handle);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text)) return;

            Settings.Default.color = comboBox1.Text;
            form.ChangeColors(comboBox1.Text);
            Settings.Default.Save();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newLine_CheckedChanged(object sender, EventArgs e)
        {
            form.useNewLine = newLine.Checked;

            Settings.Default.UseNewline = form.useNewLine;
            Settings.Default.Save();     
        }

        private void rightNewLine_CheckedChanged(object sender, EventArgs e)
        {
            form.rightNewLine = rightNewLine.Checked;

            Settings.Default.RightNewline = form.rightNewLine;
            Settings.Default.Save();

            if (rightNewLine.Checked)
            {
                form.CommandBox.Resize += (object s, EventArgs ex) 
                    => form.CommandBox.ViewWidth = form.CommandBox.ClientSize.Width;
            }
            else
            {
                form.CommandBox.Resize += (object s, EventArgs ex)
                    => form.CommandBox.ViewWidth = form.CommandBox.ClientSize.Width;
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Close(); }
        }
    }
}
