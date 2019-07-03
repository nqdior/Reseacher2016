using NewType.Seeker.Interface.Common;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NewType.Seeker.Interface
{
    public partial class TableBrowser : Form
    {
        #region Property
        private DataTable tables;
        private DataTable columns;
        private MainForm form;
        public Color FormBarColor
        {
            set
            {
                formBar.BackColor = value; formBar.BackColor = value;
                panel1.BackColor = value; panel2.BackColor = value;
            }
        }
        public Color DgvBackColor { set { Dgv.BackgroundColor = value; Dgv2.BackgroundColor = value; } }
        public Color DgvCellColor { set { Dgv.DefaultCellStyle.BackColor = value; Dgv2.DefaultCellStyle.BackColor = value; } }
        public Color DgvHeaderColor
        {
            set
            {
                Dgv.ColumnHeadersDefaultCellStyle.BackColor = value;
                Dgv.RowsDefaultCellStyle.BackColor = value;
                Dgv2.ColumnHeadersDefaultCellStyle.BackColor = value;
                Dgv2.RowsDefaultCellStyle.BackColor = value;
            }
        }
        public Image Image { set { text.Image = value; } }
        public override string Text { set { text.Text = value; } }
        #endregion

        #region Start & End
        public TableBrowser(DataTable tables, DataTable columns, MainForm form)
        {
            InitializeComponent();

            this.tables = tables;
            this.columns = columns;
            this.form = form;

            KeyPreview = true;
            Opacity = form.Opacity;
            Text += string.Format("TableBrowser ({0})", form.DBcombo.Text);
            Image = Properties.Resources.DataTable_8468;

            if (form.CommandBox.ForeColor == Color.White)
            {
                Dgv.DefaultCellStyle.ForeColor = Color.White;
                Dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                Dgv2.DefaultCellStyle.ForeColor = Color.White;
                Dgv2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void BrowseTable_Load(object sender, EventArgs e)
        {
            if (tables == null || tables.Rows.Count == 0) { return; }

            BackColor = form.BackColor;
            DgvBackColor = form.tabView.TabList[form.Index].Dgv.BackgroundColor;
            DgvCellColor = form.tabView.TabList[form.Index].Dgv.DefaultCellStyle.BackColor;
            DgvHeaderColor = form.tabView.TabList[form.Index].Dgv.ColumnHeadersDefaultCellStyle.BackColor;

            foreach (var dt in tables.AsEnumerable())
            {
                Dgv.Rows.Add(dt.Field<string>("Name"), dt.Field<int>("Rows"), dt.Field<int>("Columns"));
            }
        }

        private void closeBtn_Click(object sender, EventArgs e) { Close(); }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            FormManager.ConvertMessagePoint(ref m, this);
        }

        private void menuBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormManager.ConvertMessageMove(e, Handle);
        }
        #endregion

        #region Event

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dgv2.Rows.Clear();
            if (e.RowIndex < 0) { return; }

            string tableName = Dgv[0, e.RowIndex].Value.ToString();
            var dt = columns.AsEnumerable();
            var Infomaion = dt.Where(c => c.Field<string>("tableName").Equals(tableName));

            foreach (var i in Infomaion)
            {
                Dgv2.Rows.Add(i.Field<string>("columnName"), i.Field<string>("type"), i.Field<short>("length"), i.Field<string>("boolnull"), i.Field<string>("PK"));
            }
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            string tableName = Dgv[0, e.RowIndex].Value.ToString();
            string strSql = CreateSqlCommand(tableName);
            
            form.SetSqlAndGetData(strSql);
            SetMaxLength();
        }

        private string CreateSqlCommand(string tableName)
        {
            string strSql = string.Empty;

            // SQLCommand Create
            if (ModifierKeys == Keys.Control)
            {
                strSql = "SELECT ";
                foreach (DataGridViewRow dr in Dgv2.Rows)
                {
                    strSql += string.Format("{0}, ", dr.Cells[0].Value.ToString());
                }
                strSql = strSql.Substring(0, strSql.Length - 2);
                strSql += string.Format(" FROM {0}.dbo.{1}", form.DBcombo.Text, tableName);
            }
            else
            {
                strSql = string.Format("SELECT * FROM {0}.dbo.{1}", form.DBcombo.Text, tableName);
            }

            return strSql;
        }

        private void SetMaxLength()
        {
            try
            {
                // MaxLength & Alignment
                int roopCount = 0;
                var columns = form.tabView.TabList[form.Index].Dgv.Columns;
                foreach (DataGridViewTextBoxColumn dc in columns)
                {
                    dc.MaxInputLength = Convert.ToInt16(Dgv2["length", roopCount].Value);

                    if (Dgv2["type", roopCount].Value.Equals("int") ||
                        Dgv2["type", roopCount].Value.Equals("double") ||
                        Dgv2["type", roopCount].Value.Equals("int") ||
                        Dgv2["type", roopCount].Value.Equals("money") ||
                        Dgv2["type", roopCount].Value.Equals("float"))
                    {
                        dc.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }

                    roopCount++;
                }
            }
            catch { /* throw */ }
        } 

        private void Dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (Dgv.CurrentCell == null) { return; }

            var ex = new DataGridViewCellEventArgs(Dgv.CurrentCell.ColumnIndex, Dgv.CurrentCell.RowIndex);
            if (e.KeyData == Keys.Enter || e.KeyCode == Keys.Enter && e.Control == true)
            {
                Dgv_CellClick(sender, ex);
                Dgv_CellDoubleClick(sender, ex);

                e.Handled = true;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left)
            {
                Dgv_CellClick(sender, ex);

                e.Handled = true;
            }
        }

        private void TableBrowser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape) { Close(); }

            if (e.KeyCode == Keys.Menu && e.Modifiers == Keys.Alt)
            {
                if (Dgv.Focused) Dgv2.Focus(); else Dgv.Focus();
                e.Handled = true;
            }
        }
        #endregion

        private void 表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCellEventArgs ex = new DataGridViewCellEventArgs(0, 0);
            Dgv_CellClick(sender, ex);
        }

        private void テーブルを表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strSql = CreateSqlCommand(tmpTable);

            form.SetSqlAndGetData(strSql);
            SetMaxLength();
        }

        private string tmpTable;

        private void Dgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            tmpTable = Dgv[e.ColumnIndex, e.RowIndex].Value.ToString();
        }
    }
}
