using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NewType.Seeker.Control.TabView
{
    [Serializable]
    public partial class TabView : UserControl
    {
        #region property

        public string TabName { get; set; } = "C";
        public TabControls this[string Key] { get { return TabList[Key]; } }
        public Color SelectionTabColor { get; set; } = Color.Gray;
        public Color TabBackColor { get { return tabBar.BackColor; } set { tabBar.BackColor = value; } }
        public Color DgvBackColor
        {
            get
            {
                return TabList[TabName + "1"].Dgv.BackgroundColor;
            }
            set
            {
                foreach (var t in TabList) { t.Value.Dgv.BackgroundColor = value; }
            }
        }
        public Color DgvCellColor
        {
            get
            {
                return TabList[TabName + "1"].Dgv.DefaultCellStyle.BackColor;
            }
            set
            {
                foreach (var t in TabList) { t.Value.Dgv.DefaultCellStyle.BackColor = value; }
            }
        }
        public Color DgvHeaderBackColor
        {
            get
            {
                return TabList[TabName + "1"].Dgv.RowHeadersDefaultCellStyle.BackColor;
            }
            set
            {
                foreach (var t in TabList) { t.Value.Dgv.RowHeadersDefaultCellStyle.BackColor = value; }
                foreach (var t in TabList) { t.Value.Dgv.ColumnHeadersDefaultCellStyle.BackColor = value; }
            }
        }
        public Dictionary<string, TabControls> TabList;

        #endregion

        #region method

        public TabView()
        {
            InitializeComponent();
            TabList = new Dictionary<string, TabControls>();

            for (int i = 1; i <= 9; i++)
            {
                AddDataGridSetToTabControl();
                TabList[TabName + i.ToString()].Dgv.ColumnHeaderMouseClick += dgv_HeaderClick;
            }
            TabList[TabName + "1"].Visible = true;
            TabList[TabName + "1"].Item.BackColor = SelectionTabColor;

            basePanel.Controls.Add(tabBar);
        }

        private void AddDataGridSetToTabControl()
        {
            TabControls ct = new TabControls(tabControl, TabName);

            ct.Panel.Parent = basePanel;
            ct.Item.Click += new EventHandler(tabItem_Click);

            tabBar.Items.Insert(ct.Index - 1, ct.Item);
            TabList.Add(ct.Item.Name, ct);
        }

        private void tabItem_Click(object sender, EventArgs e)
        {
            foreach (var d in TabList)
            {
                d.Value.Item.BackColor = Color.Transparent;
                d.Value.Visible = false;
            }

            string Index = ((ToolStripMenuItem)sender).Name;
            TabList[Index].Visible = true;
            TabList[Index].Item.BackColor = SelectionTabColor;

            FuncClickArgs ex = new FuncClickArgs(e, TabList[Index]);
            tabItemClick?.Invoke(this, ex);
        }

        private void addDgv_Click(object sender, EventArgs e)
        {
            AddDataGridSetToTabControl();
        }

        #endregion

        #region CustumEvent
        public delegate void DgvHeaderClickHandler(object sender, DataGridViewCellMouseEventArgs e);
        public event DgvHeaderClickHandler DgvHeaderClick;
        public delegate void ConfigClickHandler(object sender, EventArgs e);
        public event ConfigClickHandler ConfigClick;
        public delegate void DconClickHandler(object sender, EventArgs e);
        public event DconClickHandler DconClick;
        public delegate void FunctionClickHandler(object sender, FuncClickArgs e);
        public event FunctionClickHandler tabItemClick;

        public class FuncClickArgs : EventArgs
        {
            private TabControls custumTab;
            public TabControls CustumTab { get { return custumTab; } }
            public FuncClickArgs(EventArgs e, TabControls ct) { custumTab = ct; }
        }
        private void dgv_HeaderClick(object sender, DataGridViewCellMouseEventArgs e) { DgvHeaderClick?.Invoke(this, e); }
        private void configBtn_Click(object sender, EventArgs e) { ConfigClick?.Invoke(this, e); }
        private void disconnect_Click(object sender, EventArgs e) { DconClick?.Invoke(this, e); }
        #endregion

    }
}
