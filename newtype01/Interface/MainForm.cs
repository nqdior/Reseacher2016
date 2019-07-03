using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using NewType.Seeker.Properties;
using NewType.Seeker.DataBase;
using NewType.Seeker.Control.Azuki;
using NewType.Seeker.Control.TabView;
using NewType.Seeker.Interface.Common;
using NewType.Seeker.Common;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Collections.Generic;

namespace NewType.Seeker.Interface
{
    public partial class MainForm : Form
    {
        #region global
        private ToolStripTextBox toolText;
        public string Index { get; set; } = "C1";
        private SqlServerManager SqlManager { get; set; } = new SqlServerManager();
        public string Commnad { get { return CommandBox.Text; } set { CommandBox.Text = value; } }
        public bool useNewLine { get; set; } = false;

        public bool rightNewLine { get; set; } = false;
        #endregion

        #region 1. Form

        #region Start & End
        public MainForm()
        {
            InitializeComponent();
            InitializeCommandBox();

            LoadConfigFile();
            MenuBarEvent();
            Image = Resources.SSRICON;
            ChangeColors(Settings.Default.color);

            
        }

        public void ChangeColors(string pattern)
        {
            Color color1 = Color.DarkGray;
            Color color2 = Color.Silver;
            Color color3 = Color.White;
            
            switch (pattern)
            {
                case "Shinra":
                    color1 = Color.FromArgb(120, 120, 120);
                    color2 = Color.FromArgb(120, 120, 120);
                    color3 = Color.FromArgb(120, 120, 120);

                    DBcombo.ForeColor = Color.White;

                    menuBar.ForeColor = Color.White;
                    toolBar.ForeColor = Color.White;

                    tabView.TabList["C1"].Dgv.DefaultCellStyle.ForeColor = Color.White;
                    tabView.TabList["C1"].Dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                    foreach (var t in tabView.TabList)
                    {
                        t.Value.Dgv.DefaultCellStyle.ForeColor = Color.White;
                        t.Value.Dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                        t.Value.Item.ForeColor = Color.White;
                    }

                    CommandBox.ForeColor = Color.White;

                    break;
                case "Reseach":
                    color1 = Color.GhostWhite;
                    color2 = Color.AliceBlue;
                    color3 = Color.White;
                    break;
                case "Default":
                    color1 = Color.DarkGray;
                    color2 = Color.Silver;
                    color3 = Color.White;
                    break;
            }

            BackColor = color1;
            tabView.BackColor = color1;
            toolBar.BackColor = color1;
            menuBar.BackColor = color2;
            formBar.BackColor = color2;
            DBcombo.BackColor = color2;
            underBar.BackColor = color2;
            tabView.DgvBackColor = color3;
            tabView.DgvCellColor = color3;
            tabView.DgvHeaderBackColor = color3;
            CommandBox.BackColor = color3;
        }

        private void InitializeCommandBox()
        {
            CommandBox.ShowsHScrollBar = false;
            CommandBox.Highlighter = AzukiManager.LoadHighlighter();

            if (rightNewLine)
            {
                CommandBox.Resize += (object s, EventArgs e) 
                => CommandBox.ViewWidth = CommandBox.ClientSize.Width;
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            if (!SqlManager.Connect(Settings.Default.ConnectionString, false))
            {
                MessageBox.Show(Resources.Message3, Text);
                tabView_ConfigClick(sender, e);
            }

            if (SqlManager.DBinfo.conFlg == true)
            {
                SettingDBComboBox();

                if (!SqlManager.GetData(Resources.Tables, "Tables").ToBoolean() ||
                    !SqlManager.GetData(Resources.Columns, "Columns").ToBoolean())
                {
                    MessageBox.Show(Resources.Message1, Text);
                }
            }
        }

        private void LoadConfigFile()
        {
            ConfigManager.LoadConfig(tabView);

            Opacity = Settings.Default.Opacity;
            useNewLine = Settings.Default.UseNewline;
            rightNewLine = Settings.Default.RightNewline;
            menuBar.Visible = Settings.Default.ToolBarVisible;
            splitContainer.SplitterDistance = Settings.Default.SplitterDistance;

            CommandBox.Text = tabView[Index].SqlCommand;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveConfigFile();
        }

        private void SaveConfigFile()
        {
            Settings.Default.Opacity = Opacity;
            Settings.Default.ToolBarVisible = menuBar.Visible;
            Settings.Default.SplitterDistance = splitContainer.SplitterDistance;

            ConfigManager.SaveConfig(tabView);
        }

        private void MenuBarEvent()
        {
            fNewTool.Click += (object sender, EventArgs e) => 
            {
                CommandBox.ClearText();
                tabView[Index].Dgv.DataSource = null;
            };
            F0_Open.Click += (object sender, EventArgs e) => { OpenFileDialog(); };
            fOpenTool.Click += (object sender, EventArgs e) => { OpenFileDialog(); };
            F0_Save.Click += (object sender, EventArgs e) => { SaveFileDialog(false); };
            fSaveTool.Click += (object sender, EventArgs e) => { SaveFileDialog(false); };
            F0_Overwrite.Click += (object sender, EventArgs e) => { SaveFileDialog(true); };
            fOverwriteTool.Click += (object sender, EventArgs e) => { SaveFileDialog(true); };
            fOutputTool.Click += (object sender, EventArgs e) => { OutputCsvFile(); };
            fCloseTool.Click += (object sender, EventArgs e) => { closeBtn_Click(sender, e); };

            F0_Undo.Click += (object sender, EventArgs e) => { CommandBox.Undo(); };
            eUndo.Click += (object sender, EventArgs e) => { CommandBox.Undo(); };
            F0_Redo.Click += (object sender, EventArgs e) => { CommandBox.Redo(); };
            eRedo.Click += (object sender, EventArgs e) => { CommandBox.Redo(); };
            eCutTool.Click += (object sender, EventArgs e) => { CommandBox.Cut(); };
            eCopyTool.Click += (object sender, EventArgs e) => { CommandBox.Copy(); };
            ePasteTool.Click += (object sender, EventArgs e) => { CommandBox.Paste(); };
            eSelectTool.Click += (object sender, EventArgs e) => { CommandBox.SelectAll(); };

            vMenuTool.Click += (object sender, EventArgs e) => { menuBar.Visible = !menuBar.Visible; };
            vToolTool.Click += (object sender, EventArgs e) => { toolBar.Visible = !toolBar.Visible; };
            vTabTool.Click += (object sender, EventArgs e) => { tabView.tabBar.Visible = !tabView.tabBar.Visible; };
            vInfoTool.Click += (object sender, EventArgs e) => { underBar.Visible = !underBar.Visible; };   

            hVersionTool.Click += (object sender, EventArgs e) =>
            {
                using (VerInfoDialog form = new VerInfoDialog()) { form.ShowDialog();}
            };
        }

        #endregion

        #region FormBar

        private Size tmpsize = new Size();
        public Image Image { set { text.Image = value; } }

        [SecurityPermission(SecurityAction.Demand, 
            Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x232) Invalidate(); PerformLayout();
            if (m.Msg == 0x400 + 1) SetForceFocus.SetForceForegroundWindow(m.HWnd);

            base.WndProc(ref m);
            FormManager.ConvertMessagePoint(ref m, this);
        }

        private void formBar_MouseDown(object sender, MouseEventArgs e)
        {
            FormManager.ConvertMessageMove(e, Handle);
        }
        private void maxBtn_Click(object sender, EventArgs e)
        {
            tmpsize = Size;
            WindowState = FormWindowState.Maximized;
            maxBtn.Visible = false; flatBtn.Visible = true;
        }
        private void flatBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Size = tmpsize;
            maxBtn.Visible = true; flatBtn.Visible = false;
        }
        private void minBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            notifyIcon.Visible = true;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Resources.Message7, Text, MessageBoxButtons.OKCancel)
                == DialogResult.OK) { Application.Exit(); }

            SaveConfigFile();
        }
        private void topMost_Click(object sender, EventArgs e)
        {
            topMost.BackColor = Color.Transparent;

            TopMost = !TopMost;
            if (TopMost) { topMost.BackColor = Color.DimGray; }
        }
        protected override void OnResize(EventArgs e) { /* Nothing */ }

        #endregion

        #region NotifiyIcon
        private void keyboardHook_KeyboardHooked(object sender, KeyboardHookedEventArgs e)
        {
            if ((ModifierKeys & Keys.Control) != Keys.Control) return;
            if (e.KeyCode != Keys.Q) return;
             
            notifyIcon_DoubleClick(sender, e);
            SetForceFocus.PostMessage(new HandleRef(this, Handle), 0x400 + 1, (IntPtr)0, (IntPtr)0);
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e) { Visible = true; }

        private void closeItem_Click(object sender, EventArgs e) { closeBtn_Click(sender, e); }
        #endregion

        #endregion

        #region 2. MenuBar

        #region DBcombo
        private void SettingDBComboBox()
        {
            if (SqlManager.DBinfo.conFlg == false) { return; }

            string tmpCatalog = SqlManager.DBinfo.connectionString.InitialCatalog;
            SqlManager.DBinfo.connectionString.InitialCatalog = "master";

            if (SqlManager.Connect(SqlManager.DBinfo.connectionString.ToString()))
            {
                SqlManager.GetData(Resources.DataBases, "DataBases");

                SqlManager.DBinfo.connectionString.InitialCatalog = tmpCatalog;
                SqlManager.Connect(SqlManager.DBinfo.connectionString.ToString());
            }

            DBcombo.Items.Clear();
            foreach (DataRow r in SqlManager.GetTable("DataBases").Rows) { DBcombo.Items.Add(r["Name"]); }

            DBcombo.Text = SqlManager.DBinfo.sqlConnection.Database;
        }

        private void DBcombo_TextChanged(object sender, EventArgs e)
        {
            if (tableBrowser != null) { tableBrowser.Close(); }

            SqlManager.DBinfo.connectionString.InitialCatalog = DBcombo.Text;

            if (SqlManager.Connect(SqlManager.DBinfo.connectionString.ToString()))
            {
                Settings.Default.ConnectionString = SqlManager.DBinfo.connectionString.ToString();
                Settings.Default.Save();

                SqlManager.GetData(Resources.Tables, "Tables");
                SqlManager.GetData(Resources.Columns, "Columns");
            }
        }
        #endregion

        #region F1 to F12

        public void SetSqlAndGetData(string Sql)
        {
            object sender = new object();
            EventArgs e = new EventArgs();

            CommandBox.Text = Sql;
            F5_Execute_Click(sender, e);

            Focus();
        }

        private TableBrowser tableBrowser = null;
        private void F1_Tables_Click(object sender, EventArgs e)
        {
            if (tableBrowser == null || tableBrowser.IsDisposed)
            {
                tableBrowser = new TableBrowser(SqlManager.GetTable("Tables"), SqlManager.GetTable("Columns"), this);
                tableBrowser.Location = Location;
                if (WindowState != FormWindowState.Maximized) { tableBrowser.Top += Height; }

                tableBrowser.FormBarColor = formBar.BackColor;
                tableBrowser.DgvBackColor = tabView.DgvBackColor;

                tableBrowser.Show();
            }
            tableBrowser.Focus();
        }

        private void F2_Rename_Click(object sender, EventArgs e)
        {
            F2_Rename.DropDownItems.Clear();
            toolText = new ToolStripTextBox("toolText");
            toolText.Size = new Size(200, 25);

            F2_Rename.DropDownItems.AddRange(new ToolStripItem[] { toolText });
            toolText.KeyDown += new KeyEventHandler(renameText_KeyDown);
            toolText.TextChanged += new EventHandler(renameText_TextChanged);
            toolText.Text = tabView[Index].Item.Text;

            F2_Rename.ShowDropDown();
            toolText.Focus();
        }

        private void F3_Search_Click(object sender, EventArgs e)
        {
            F3_Search.DropDownItems.Clear();
            toolText = new ToolStripTextBox("toolText");
            toolText.Size = new Size(200, 25);

            F3_Search.DropDownItems.AddRange(new ToolStripItem[] { toolText });
            toolText.TextChanged += new EventHandler(toolText_TextChanged);
            toolText.KeyDown += new KeyEventHandler(toolText_KeyDown);

            F3_Search.ShowDropDown();
            toolText.Focus();
        }

        private void F4_BarVisible_Click(object sender, EventArgs e)
        {
            menuBar.Visible = !(menuBar.Visible);
        }

        private void F5_Execute_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SqlManager.DBinfo.conFlg) { MessageBox.Show(Resources.Message4, Text); return; }

                // Set SQL Command & GetData
                CommandBox.RemakeText(useNewLine);
                tabView[Index].SqlCommand = CommandBox.Text;

                Cursor.Current = Cursors.WaitCursor;
                System.Threading.Thread.Sleep(200);

                SqlManager.GetData(CommandBox.Text, Index);

                // Bind
                tabView[Index].Dgv.DataSource = SqlManager.GetTable(Index);
                ShowTableInfomation();
            }
            catch { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void ShowTableInfomation()
        {
            if (tabView[Index].Dgv.DataSource != null)
            {
                tableInfomation.Text = string.Format("Columns:{0}  Rows:{1}",
                                                                        tabView[Index].Dgv.Columns.Count,
                                                                        tabView[Index].Dgv.Rows.Count - 1);
            }
            else
            {
                tableInfomation.Text = "Columns:0  Rows:0";
            }
        }

        private void F6_MoveNext_Click(object sender, EventArgs e)
        {
            if (!CommandBox.Focused)
            {
                CommandBox.Focus();         
            }
            else
            {
                tabView[Index].Dgv.Focus();
            }   
        }

        private void F7_Combo_Click(object sender, EventArgs e)
        {
            DBcombo.DroppedDown = true;
            DBcombo.Focus();
        }

        private void F8_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabView[Index].Dgv.DataSource == null) { return; }
                var context = new DataGridViewDataErrorContexts();
                tabView[Index].Dgv.CommitEdit(context);

                Cursor.Current = Cursors.WaitCursor;
                System.Threading.Thread.Sleep(200);

                if (SqlManager.Update(Index))
                {
                    MessageBox.Show(Resources.Message5, Text); return;
                }
                MessageBox.Show(Resources.Message6, Text);
            }
            catch { }
            finally { Cursor.Current = Cursors.Default; }
        }

        private OpacityForm opacityForm = null;
        private void F9_Opacity_Click(object sender, EventArgs e)
        {
            double opacity = Opacity;
            if (opacityForm != null) { opacityForm.Activate(); }
            opacityForm = new OpacityForm(ref opacity, this);

            opacityForm.StartPosition = FormStartPosition.Manual;
            opacityForm.Location = Location;

            opacityForm.ShowDialog();
        }

        private void F10_TopMost_Click(object sender, EventArgs e) { topMost_Click(sender, e); }

        private void F11_FullScreen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                flatBtn_Click(sender, e);
            }
            else
            {
                maxBtn_Click(sender, e);
            }
        }

        private void F12_Setting_Click(object sender, EventArgs e)
        {
            var form = new SettingForm(this);

            form.Location = Location;
            form.ShowDialog();
        }

        #endregion

        #region RenameText

        private void renameText_TextChanged(object sender, EventArgs e)
        {
            tabView[Index].Item.Text = toolText.Text;
        }

        private void renameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) F2_Rename.DropDown.Close();
        }

        private void F2_Rename_DropDownClosed(object sender, EventArgs e)
        {
            F2_Rename.DropDownItems.Remove(F2_Rename.DropDownItems["toolText"]);
        }

        #endregion

        #region SearchText
        private void toolText_TextChanged(object sender, EventArgs e)
        {
            DataGridView dgv = tabView[Index].Dgv;
            dgv.CurrentCell = dgv.Rows[0].Cells[0]; 
        }

        private void toolText_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    FocusDataGridViewCell(toolText.Text);
                    break;
                default: return;
            }
        }

        private void F3_Search_DropDownClosed(object sender, EventArgs e)
        {
            F3_Search.DropDownItems.Remove(F3_Search.DropDownItems["toolText"]);
        }

        private void FocusDataGridViewCell(string keyword)
        {
            bool firstSelectRowIndex = true;
            if (tabView[Index].Dgv.DataSource == null) { return; }

            DataGridView dgv = tabView[Index].Dgv;

            foreach (DataGridViewRow dr in dgv.Rows)
            {
                if (dgv.CurrentCell == null) { return; }
                if (dr.Index <= dgv.CurrentCell.RowIndex) { continue; }

                foreach (DataGridViewColumn dc in dgv.Columns)
                {
                    dr.Cells[dc.Name].Selected = false;
                    if (dr.Cells[dc.Name].Value == null) { continue; }
                    string data = dr.Cells[dc.Name].Value.ToString();

                    // Find
                    if (data.IndexOf(keyword) == -1) { continue; }

                    dr.Cells[dc.Name].Selected = true;

                    // First Index
                    if (firstSelectRowIndex)
                    {
                        firstSelectRowIndex = false;
                        dgv.CurrentCell = dr.Cells[dc.Name];
                        dgv.FirstDisplayedScrollingRowIndex = dr.Cells[dc.Name].RowIndex;
                    }
                }
            }
        }
        #endregion

        #region FileOperate

        string fileAddress = string.Empty;
        private void OpenFileDialog()
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "ファイルを開く";
            dialog.Filter = "クエリファイル(*.sql;*.txt)|*.sql;*.txt|すべてのファイル(*.*)|*.*";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DataSeeker\QUERY";        

            try
            {
                if (dialog.ShowDialog().Equals(DialogResult.OK))
                {
                    Cursor.Current = Cursors.WaitCursor;

                    if (string.IsNullOrEmpty(dialog.FileName)) { return; }
                    fileAddress = dialog.FileName;
                    var sr = new StreamReader(dialog.FileName, Encoding.GetEncoding("Shift_JIS"));

                    SetSqlAndGetData(sr.ReadToEnd());
                    sr.Close();
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void SaveFileDialog(bool overwrite)
        {
            try
            {
                if (overwrite.Equals(false) || string.IsNullOrEmpty(fileAddress))
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = "クエリを保存する";
                    dialog.Filter = "クエリファイル(*.sql;)|*.sql;|すべてのファイル(*.*)|*.*";
                    dialog.FileName = tabView[Index].Item.Text;
                    dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DataSeeker\QUERY";

                    if (dialog.ShowDialog().Equals(DialogResult.OK))
                    {
                        fileAddress = dialog.FileName;
                    }
                    else if (string.IsNullOrEmpty(dialog.FileName))
                    {
                        return;
                    }
                }
                Cursor.Current = Cursors.WaitCursor;
                System.Threading.Thread.Sleep(200);

                var sw = new StreamWriter(fileAddress, false, Encoding.GetEncoding("Shift_JIS"));
                sw.Write(CommandBox.Text);
                sw.Close();
            }
            catch { /* Nothing */ }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void OutputCsvFile()
        {
            var Dgv = tabView[Index].Dgv;

            try
            {
                var dialog = new SaveFileDialog();
                dialog.Title = "データを出力する";
                dialog.Filter = "CSVファイル(*.csv;)|*.csv;|すべてのファイル(*.*)|*.*";
                dialog.FileName = tabView[Index].Item.Text;
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DataSeeker\OUTPUT";

                if (dialog.ShowDialog().Equals(DialogResult.OK))
                {
                    fileAddress = dialog.FileName;
                }
                else if (string.IsNullOrEmpty(dialog.FileName))
                {
                    return;
                }

                using (StreamWriter writer = new StreamWriter(dialog.FileName, false, Encoding.GetEncoding("shift_jis")))
                {
                    int rowCount = Dgv.Rows.Count;
                    if (Dgv.AllowUserToAddRows == true)
                    {
                        rowCount = rowCount - 1;
                    }

                    for (int i = 0; i < rowCount; i++)
                    {
                        List<string> strList = new List<string>();

                        for (int j = 0; j < Dgv.Columns.Count; j++)
                        {
                            strList.Add(Dgv[j, i].Value.ToString());
                        }
                        string[] strArray = strList.ToArray();
                        string strCsvData = string.Join(",", strArray);

                        writer.WriteLine(strCsvData);
                    }
                }
                Cursor.Current = Cursors.WaitCursor;
                System.Threading.Thread.Sleep(200);
            }
            catch { /* Nothing */ }
            finally { Cursor.Current = Cursors.Default; }
        }

        #endregion

        #endregion

        #region 3. TabActions
        private void CommandBox_Enter(object sender, EventArgs e)
        {
            CommandBox.SetSelection(CommandBox.TextLength, CommandBox.TextLength);
        }

        private void tabView_FunctionClick(object sender, TabView.FuncClickArgs e)
        {
            fileAddress = string.Empty;

            // Set SQL Command
            if (string.IsNullOrEmpty(CommandBox.Text))
            {
                tabView[Index].Dgv.DataSource = null;
            }
            tabView[Index].SqlCommand = CommandBox.Text;

            // Set new SQLCommand &
            Index = e.CustumTab.TabName;
            CommandBox.Text = tabView[Index].SqlCommand;

            // Set Update Command 
            SqlManager.ComSqlServer.cmd.CommandText = CommandBox.Text;

            ShowTableInfomation();
        }

        private void tabView_ConfigClick(object sender, EventArgs e)
        {
            var form = new ConnectionForm(SqlManager);
            form.Location = Location;
            form.ShowDialog();

            // SettingOK -> DBcombo
            if (SqlManager.DBinfo.conFlg) SettingDBComboBox();
        }

        private void tabView_DconClick(object sender, EventArgs e)
        {
            SqlManager.DisConnect();
            DBcombo.Items.Clear();

            MessageBox.Show(Resources.Message8, Text);
        }

        int escCount = 0;
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // ExitKey
            if (e.KeyData == Keys.Escape)
            {
                if (escCount++ == 5) Close(); 
            }
            else { escCount = 0; }

            // Mini
            if (e.KeyCode == Keys.F11 && e.Modifiers == Keys.Shift)
            {
                minBtn_Click(sender, e);
            }

            if (e.KeyCode == Keys.Menu && e.Modifiers == Keys.Alt)
            {
                F6_MoveNext_Click(sender, e);
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Up && e.Modifiers == Keys.Control)
            {
                maxBtn_Click(sender, e);
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Down && e.Modifiers == Keys.Control)
            {
                minBtn_Click(sender, e);
                e.Handled = true;
            }
        }

        #endregion

        string tmpColumn;

        private void tabView_DgvHeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) return;

            searchStrip.Visible = true;
            searchStrip.Show(Cursor.Position);
            tmpColumn = tabView[Index].Dgv.Columns[e.ColumnIndex].HeaderText;

            ToolSearchData.Focus();
        }

        private void ToolSearchData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (ToolSearchData.Text == "") return;

                CommandBox.Text +=
                    CommandBox.Text.Contains("WHERE")
                    ? string.Format(" AND {0} LIKE '%{1}%'", tmpColumn, ToolSearchData.Text)
                    : string.Format(" WHERE {0} LIKE '%{1}%'", tmpColumn, ToolSearchData.Text);

                F5_Execute_Click(sender, e);

                searchStrip.Hide();
                ToolSearchData.Text = "抽出対象文字列";
                CommandBox.Focus();
            }
        }

        #region 4. Function
        private void CommandBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop)
                           ? e.Effect = DragDropEffects.Copy
                           : e.Effect = DragDropEffects.None;
        }

        private void CommandBox_DragDrop(object sender, DragEventArgs e)
        {
            var savePass = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (File.Exists(savePass[0]) == true)
            {
                var sr = new StreamReader(savePass[0], Encoding.GetEncoding("Shift_JIS"));

                CommandBox.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void F0_adComment_Click(object sender, EventArgs e)
        {
            var select = CommandBox.GetSelectedText();
            if (select.Length.Equals(0)) return;

            var comment = select.Insert(0, "--").Replace("\r\n", "\r\n--");

            CommandBox.Text = CommandBox.Text.Replace(select, comment);
        }

        private void F0_unComment_Click(object sender, EventArgs e)
        {
            var select = CommandBox.GetSelectedText();
            if (select.Length.Equals(0)) return;

            var comment = select.Replace("\r\n--", "\r\n");
            if (comment.Substring(0, 2).Equals("--")) comment = comment.Substring(2);

            CommandBox.Text = CommandBox.Text.Replace(select, comment);
        }
        #endregion

        private void tSearchTool_Click(object sender, EventArgs e)
        {
            F3_Search_Click(sender, e);
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.XButton1)
            {
                F1_Tables_Click(sender, new EventArgs());
            }

            if (e.Button == MouseButtons.XButton2)
            {
                F5_Execute_Click(sender, new EventArgs());
            }
        }
    }
}

