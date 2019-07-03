using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using NewType.Seeker.Properties;
using NewType.Seeker.DataBase;
using NewType.Seeker.Interface.Common;

namespace NewType.Seeker.Interface
{
    public partial class ConnectionForm : Form
    {
        private SqlServerManager tableManager;
        private SqlConnectionStringBuilder sql = new SqlConnectionStringBuilder();

        public ConnectionForm(SqlServerManager tableManager)
        {
            try
            {
                InitializeComponent();

                Text = "DataSeeker";
                this.tableManager = tableManager;

                TopMost = true;
                sql.ConnectionString = Settings.Default.ConnectionString;
                propertyGrid.SelectedObject = sql;
            }
            catch
            {
                sql.ConnectionString = null;
                propertyGrid.SelectedObject = sql;
            }
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            var msg = tableManager.Connect(sql.ConnectionString)
                ? MessageBox.Show(Resources.Message9, Text)
                : MessageBox.Show(Resources.Message1, Text);

            tableManager.DisConnect();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (tableManager.Connect(sql.ConnectionString))
            {
                MessageBox.Show(Resources.Message9, Text);

                Settings.Default.ConnectionString = sql.ConnectionString.ToString();
                Settings.Default.Save();

                Close(); return;
            }
            MessageBox.Show(Resources.Message1, Text);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var msg = tableManager.Connect(Settings.Default.ConnectionString, false);
            Close();
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
