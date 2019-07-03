using NewType.Seeker.Interface.Common;
using System.Windows.Forms;

namespace NewType.Seeker.Interface
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Sgry.Azuki.FontInfo fontInfo1 = new Sgry.Azuki.FontInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tabView = new NewType.Seeker.Control.TabView.TabView();
            this.CommandBox = new Sgry.Azuki.WinForms.AzukiControl();
            this.toolBar = new System.Windows.Forms.MenuStrip();
            this.F0_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.F0_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.F0_Overwrite = new System.Windows.Forms.ToolStripMenuItem();
            this.sep = new System.Windows.Forms.ToolStripSeparator();
            this.F0_Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.F0_Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.F0_adComment = new System.Windows.Forms.ToolStripMenuItem();
            this.F0_unComment = new System.Windows.Forms.ToolStripMenuItem();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.F1_Tables = new System.Windows.Forms.ToolStripMenuItem();
            this.F2_Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.F3_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.F4_BarVisible = new System.Windows.Forms.ToolStripMenuItem();
            this.sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.F5_Execute = new System.Windows.Forms.ToolStripMenuItem();
            this.F6_MoveFocus = new System.Windows.Forms.ToolStripMenuItem();
            this.F7_Combo = new System.Windows.Forms.ToolStripMenuItem();
            this.F8_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.sep4 = new System.Windows.Forms.ToolStripSeparator();
            this.F9_Opacity = new System.Windows.Forms.ToolStripMenuItem();
            this.F10_TopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.F11_FullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.F12_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.sep5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.FileTool = new System.Windows.Forms.ToolStripMenuItem();
            this.fNewTool = new System.Windows.Forms.ToolStripMenuItem();
            this.fOpenTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.fOverwriteTool = new System.Windows.Forms.ToolStripMenuItem();
            this.fSaveTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fOutputTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fCloseTool = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTool = new System.Windows.Forms.ToolStripMenuItem();
            this.eUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.eRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.eCutTool = new System.Windows.Forms.ToolStripMenuItem();
            this.eCopyTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ePasteTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.eSelectTool = new System.Windows.Forms.ToolStripMenuItem();
            this.VisualTool = new System.Windows.Forms.ToolStripMenuItem();
            this.vMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.vToolTool = new System.Windows.Forms.ToolStripMenuItem();
            this.vTabTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.vInfoTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tTablesTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tRenameTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tSearchTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tExecuteTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tDBcomboTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tUpdateTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tOpacityTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tTopmostTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tFullScreenTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tSettingTool = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hVersionTool = new System.Windows.Forms.ToolStripMenuItem();
            this.DBcombo = new System.Windows.Forms.ToolStripComboBox();
            this.formBar = new System.Windows.Forms.MenuStrip();
            this.closeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.flatBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.maxBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.minBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.text = new System.Windows.Forms.ToolStripMenuItem();
            this.topMost = new System.Windows.Forms.ToolStripMenuItem();
            this.underBar = new System.Windows.Forms.StatusStrip();
            this.tableInfomation = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.closeStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolSearchData = new System.Windows.Forms.ToolStripTextBox();
            this.keyboardHook = new NewType.Seeker.Interface.Common.KeyboardHook();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.formBar.SuspendLayout();
            this.underBar.SuspendLayout();
            this.closeStrip.SuspendLayout();
            this.searchStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.splitContainer);
            this.mainPanel.Controls.Add(this.toolBar);
            this.mainPanel.Controls.Add(this.menuBar);
            this.mainPanel.Controls.Add(this.formBar);
            this.mainPanel.Controls.Add(this.underBar);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(479, 294);
            this.mainPanel.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 54);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tabView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.CommandBox);
            this.splitContainer.Size = new System.Drawing.Size(479, 218);
            this.splitContainer.SplitterDistance = 125;
            this.splitContainer.TabIndex = 3;
            // 
            // tabView
            // 
            this.tabView.BackColor = System.Drawing.Color.DarkGray;
            this.tabView.DgvBackColor = System.Drawing.Color.Silver;
            this.tabView.DgvCellColor = System.Drawing.SystemColors.Window;
            this.tabView.DgvHeaderBackColor = System.Drawing.SystemColors.Control;
            this.tabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabView.Location = new System.Drawing.Point(0, 0);
            this.tabView.Name = "tabView";
            this.tabView.SelectionTabColor = System.Drawing.Color.Gray;
            this.tabView.Size = new System.Drawing.Size(479, 125);
            this.tabView.TabBackColor = System.Drawing.Color.Transparent;
            this.tabView.TabIndex = 0;
            this.tabView.TabName = "C";
            this.tabView.DgvHeaderClick += new NewType.Seeker.Control.TabView.TabView.DgvHeaderClickHandler(this.tabView_DgvHeaderClick);
            this.tabView.ConfigClick += new NewType.Seeker.Control.TabView.TabView.ConfigClickHandler(this.tabView_ConfigClick);
            this.tabView.DconClick += new NewType.Seeker.Control.TabView.TabView.DconClickHandler(this.tabView_DconClick);
            this.tabView.tabItemClick += new NewType.Seeker.Control.TabView.TabView.FunctionClickHandler(this.tabView_FunctionClick);
            // 
            // CommandBox
            // 
            this.CommandBox.AllowDrop = true;
            this.CommandBox.BackColor = System.Drawing.Color.LightGray;
            this.CommandBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommandBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CommandBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommandBox.DrawingOption = ((Sgry.Azuki.DrawingOption)(((((((Sgry.Azuki.DrawingOption.DrawsFullWidthSpace | Sgry.Azuki.DrawingOption.DrawsTab) 
            | Sgry.Azuki.DrawingOption.DrawsEol) 
            | Sgry.Azuki.DrawingOption.HighlightCurrentLine) 
            | Sgry.Azuki.DrawingOption.ShowsLineNumber) 
            | Sgry.Azuki.DrawingOption.ShowsDirtBar) 
            | Sgry.Azuki.DrawingOption.HighlightsMatchedBracket)));
            this.CommandBox.FirstVisibleLine = 0;
            this.CommandBox.Font = new System.Drawing.Font("メイリオ", 9F);
            fontInfo1.Name = "メイリオ";
            fontInfo1.Size = 9;
            fontInfo1.Style = System.Drawing.FontStyle.Regular;
            this.CommandBox.FontInfo = fontInfo1;
            this.CommandBox.ForeColor = System.Drawing.Color.Black;
            this.CommandBox.Location = new System.Drawing.Point(0, 0);
            this.CommandBox.Name = "CommandBox";
            this.CommandBox.ScrollPos = new System.Drawing.Point(0, 0);
            this.CommandBox.ScrollsBeyondLastLine = false;
            this.CommandBox.ShowsHScrollBar = false;
            this.CommandBox.ShowsVScrollBar = false;
            this.CommandBox.Size = new System.Drawing.Size(479, 89);
            this.CommandBox.TabIndex = 0;
            this.CommandBox.ViewType = Sgry.Azuki.ViewType.WrappedProportional;
            this.CommandBox.ViewWidth = 4133;
            this.CommandBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.CommandBox_DragDrop);
            this.CommandBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.CommandBox_DragEnter);
            this.CommandBox.Enter += new System.EventHandler(this.CommandBox_Enter);
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.DarkGray;
            this.toolBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.F0_Open,
            this.F0_Save,
            this.F0_Overwrite,
            this.sep,
            this.F0_Undo,
            this.F0_Redo,
            this.F0_adComment,
            this.F0_unComment,
            this.sep2,
            this.F1_Tables,
            this.F2_Rename,
            this.F3_Search,
            this.F4_BarVisible,
            this.sep3,
            this.F5_Execute,
            this.F6_MoveFocus,
            this.F7_Combo,
            this.F8_Update,
            this.sep4,
            this.F9_Opacity,
            this.F10_TopMost,
            this.F11_FullScreen,
            this.F12_Setting,
            this.sep5});
            this.toolBar.Location = new System.Drawing.Point(0, 27);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(479, 27);
            this.toolBar.TabIndex = 4;
            this.toolBar.Text = "menuStrip1";
            // 
            // F0_Open
            // 
            this.F0_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F0_Open.Image = ((System.Drawing.Image)(resources.GetObject("F0_Open.Image")));
            this.F0_Open.Name = "F0_Open";
            this.F0_Open.Size = new System.Drawing.Size(28, 23);
            this.F0_Open.Text = "n";
            // 
            // F0_Save
            // 
            this.F0_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F0_Save.Image = ((System.Drawing.Image)(resources.GetObject("F0_Save.Image")));
            this.F0_Save.Name = "F0_Save";
            this.F0_Save.Size = new System.Drawing.Size(28, 23);
            this.F0_Save.Text = "o";
            // 
            // F0_Overwrite
            // 
            this.F0_Overwrite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F0_Overwrite.Image = ((System.Drawing.Image)(resources.GetObject("F0_Overwrite.Image")));
            this.F0_Overwrite.Name = "F0_Overwrite";
            this.F0_Overwrite.Size = new System.Drawing.Size(28, 23);
            this.F0_Overwrite.Text = "s";
            // 
            // sep
            // 
            this.sep.Name = "sep";
            this.sep.Size = new System.Drawing.Size(6, 23);
            // 
            // F0_Undo
            // 
            this.F0_Undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F0_Undo.Image = ((System.Drawing.Image)(resources.GetObject("F0_Undo.Image")));
            this.F0_Undo.Name = "F0_Undo";
            this.F0_Undo.Size = new System.Drawing.Size(28, 23);
            this.F0_Undo.Text = "r";
            // 
            // F0_Redo
            // 
            this.F0_Redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F0_Redo.Image = ((System.Drawing.Image)(resources.GetObject("F0_Redo.Image")));
            this.F0_Redo.Name = "F0_Redo";
            this.F0_Redo.Size = new System.Drawing.Size(28, 23);
            this.F0_Redo.Text = "u";
            // 
            // F0_adComment
            // 
            this.F0_adComment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F0_adComment.Image = ((System.Drawing.Image)(resources.GetObject("F0_adComment.Image")));
            this.F0_adComment.Name = "F0_adComment";
            this.F0_adComment.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.F0_adComment.Size = new System.Drawing.Size(28, 23);
            this.F0_adComment.Text = "a";
            this.F0_adComment.Click += new System.EventHandler(this.F0_adComment_Click);
            // 
            // F0_unComment
            // 
            this.F0_unComment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F0_unComment.Image = ((System.Drawing.Image)(resources.GetObject("F0_unComment.Image")));
            this.F0_unComment.Name = "F0_unComment";
            this.F0_unComment.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.F0_unComment.Size = new System.Drawing.Size(28, 23);
            this.F0_unComment.Text = "u";
            this.F0_unComment.Click += new System.EventHandler(this.F0_unComment_Click);
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 23);
            // 
            // F1_Tables
            // 
            this.F1_Tables.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F1_Tables.Image = ((System.Drawing.Image)(resources.GetObject("F1_Tables.Image")));
            this.F1_Tables.Name = "F1_Tables";
            this.F1_Tables.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.F1_Tables.Size = new System.Drawing.Size(28, 23);
            this.F1_Tables.Text = "F1";
            this.F1_Tables.Click += new System.EventHandler(this.F1_Tables_Click);
            // 
            // F2_Rename
            // 
            this.F2_Rename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F2_Rename.Image = ((System.Drawing.Image)(resources.GetObject("F2_Rename.Image")));
            this.F2_Rename.Name = "F2_Rename";
            this.F2_Rename.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.F2_Rename.Size = new System.Drawing.Size(28, 23);
            this.F2_Rename.Text = "F2";
            this.F2_Rename.DropDownClosed += new System.EventHandler(this.F2_Rename_DropDownClosed);
            this.F2_Rename.Click += new System.EventHandler(this.F2_Rename_Click);
            // 
            // F3_Search
            // 
            this.F3_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F3_Search.Image = ((System.Drawing.Image)(resources.GetObject("F3_Search.Image")));
            this.F3_Search.Name = "F3_Search";
            this.F3_Search.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.F3_Search.Size = new System.Drawing.Size(28, 23);
            this.F3_Search.Text = "F3";
            this.F3_Search.DropDownClosed += new System.EventHandler(this.F3_Search_DropDownClosed);
            this.F3_Search.Click += new System.EventHandler(this.F3_Search_Click);
            // 
            // F4_BarVisible
            // 
            this.F4_BarVisible.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F4_BarVisible.Image = ((System.Drawing.Image)(resources.GetObject("F4_BarVisible.Image")));
            this.F4_BarVisible.Name = "F4_BarVisible";
            this.F4_BarVisible.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.F4_BarVisible.Size = new System.Drawing.Size(28, 23);
            this.F4_BarVisible.Text = "F4";
            this.F4_BarVisible.Click += new System.EventHandler(this.F4_BarVisible_Click);
            // 
            // sep3
            // 
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(6, 23);
            // 
            // F5_Execute
            // 
            this.F5_Execute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F5_Execute.Image = ((System.Drawing.Image)(resources.GetObject("F5_Execute.Image")));
            this.F5_Execute.Name = "F5_Execute";
            this.F5_Execute.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.F5_Execute.Size = new System.Drawing.Size(28, 23);
            this.F5_Execute.Text = "F5";
            this.F5_Execute.Click += new System.EventHandler(this.F5_Execute_Click);
            // 
            // F6_MoveFocus
            // 
            this.F6_MoveFocus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F6_MoveFocus.Image = ((System.Drawing.Image)(resources.GetObject("F6_MoveFocus.Image")));
            this.F6_MoveFocus.Name = "F6_MoveFocus";
            this.F6_MoveFocus.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.F6_MoveFocus.Size = new System.Drawing.Size(28, 23);
            this.F6_MoveFocus.Text = "F6";
            this.F6_MoveFocus.Click += new System.EventHandler(this.F6_MoveNext_Click);
            // 
            // F7_Combo
            // 
            this.F7_Combo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F7_Combo.Image = ((System.Drawing.Image)(resources.GetObject("F7_Combo.Image")));
            this.F7_Combo.Name = "F7_Combo";
            this.F7_Combo.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.F7_Combo.Size = new System.Drawing.Size(28, 23);
            this.F7_Combo.Text = "F7";
            this.F7_Combo.Click += new System.EventHandler(this.F7_Combo_Click);
            // 
            // F8_Update
            // 
            this.F8_Update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F8_Update.Image = ((System.Drawing.Image)(resources.GetObject("F8_Update.Image")));
            this.F8_Update.Name = "F8_Update";
            this.F8_Update.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.F8_Update.Size = new System.Drawing.Size(28, 23);
            this.F8_Update.Text = "F8";
            this.F8_Update.Click += new System.EventHandler(this.F8_Update_Click);
            // 
            // sep4
            // 
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(6, 23);
            // 
            // F9_Opacity
            // 
            this.F9_Opacity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F9_Opacity.Image = ((System.Drawing.Image)(resources.GetObject("F9_Opacity.Image")));
            this.F9_Opacity.Name = "F9_Opacity";
            this.F9_Opacity.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.F9_Opacity.Size = new System.Drawing.Size(28, 23);
            this.F9_Opacity.Text = "F9";
            this.F9_Opacity.Click += new System.EventHandler(this.F9_Opacity_Click);
            // 
            // F10_TopMost
            // 
            this.F10_TopMost.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F10_TopMost.Image = ((System.Drawing.Image)(resources.GetObject("F10_TopMost.Image")));
            this.F10_TopMost.Name = "F10_TopMost";
            this.F10_TopMost.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.F10_TopMost.Size = new System.Drawing.Size(28, 23);
            this.F10_TopMost.Text = "F10";
            this.F10_TopMost.Click += new System.EventHandler(this.F10_TopMost_Click);
            // 
            // F11_FullScreen
            // 
            this.F11_FullScreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F11_FullScreen.Image = ((System.Drawing.Image)(resources.GetObject("F11_FullScreen.Image")));
            this.F11_FullScreen.Name = "F11_FullScreen";
            this.F11_FullScreen.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.F11_FullScreen.Size = new System.Drawing.Size(28, 23);
            this.F11_FullScreen.Text = "F11";
            this.F11_FullScreen.Click += new System.EventHandler(this.F11_FullScreen_Click);
            // 
            // F12_Setting
            // 
            this.F12_Setting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.F12_Setting.Image = ((System.Drawing.Image)(resources.GetObject("F12_Setting.Image")));
            this.F12_Setting.Name = "F12_Setting";
            this.F12_Setting.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.F12_Setting.Size = new System.Drawing.Size(28, 23);
            this.F12_Setting.Text = "F12";
            this.F12_Setting.Click += new System.EventHandler(this.F12_Setting_Click);
            // 
            // sep5
            // 
            this.sep5.Name = "sep5";
            this.sep5.Size = new System.Drawing.Size(6, 23);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.Silver;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTool,
            this.EditTool,
            this.VisualTool,
            this.ToolTool,
            this.ヘルプHToolStripMenuItem,
            this.DBcombo});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(479, 27);
            this.menuBar.TabIndex = 6;
            this.menuBar.Text = "MenuBar";
            // 
            // FileTool
            // 
            this.FileTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fNewTool,
            this.fOpenTool,
            this.toolStripSeparator,
            this.fOverwriteTool,
            this.fSaveTool,
            this.toolStripSeparator1,
            this.fOutputTool,
            this.toolStripSeparator2,
            this.fCloseTool});
            this.FileTool.Name = "FileTool";
            this.FileTool.Size = new System.Drawing.Size(67, 23);
            this.FileTool.Text = "ファイル(&F)";
            // 
            // fNewTool
            // 
            this.fNewTool.Image = ((System.Drawing.Image)(resources.GetObject("fNewTool.Image")));
            this.fNewTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fNewTool.Name = "fNewTool";
            this.fNewTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.fNewTool.Size = new System.Drawing.Size(184, 22);
            this.fNewTool.Text = "新規作成(&N)";
            // 
            // fOpenTool
            // 
            this.fOpenTool.Image = ((System.Drawing.Image)(resources.GetObject("fOpenTool.Image")));
            this.fOpenTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fOpenTool.Name = "fOpenTool";
            this.fOpenTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fOpenTool.Size = new System.Drawing.Size(184, 22);
            this.fOpenTool.Text = "開く(&O)";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(181, 6);
            // 
            // fOverwriteTool
            // 
            this.fOverwriteTool.Image = ((System.Drawing.Image)(resources.GetObject("fOverwriteTool.Image")));
            this.fOverwriteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fOverwriteTool.Name = "fOverwriteTool";
            this.fOverwriteTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fOverwriteTool.Size = new System.Drawing.Size(184, 22);
            this.fOverwriteTool.Text = "上書き保存(&S)";
            // 
            // fSaveTool
            // 
            this.fSaveTool.Image = ((System.Drawing.Image)(resources.GetObject("fSaveTool.Image")));
            this.fSaveTool.Name = "fSaveTool";
            this.fSaveTool.Size = new System.Drawing.Size(184, 22);
            this.fSaveTool.Text = "名前を付けて保存(&A)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // fOutputTool
            // 
            this.fOutputTool.Image = ((System.Drawing.Image)(resources.GetObject("fOutputTool.Image")));
            this.fOutputTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fOutputTool.Name = "fOutputTool";
            this.fOutputTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.fOutputTool.Size = new System.Drawing.Size(184, 22);
            this.fOutputTool.Text = "出力(&P)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // fCloseTool
            // 
            this.fCloseTool.Name = "fCloseTool";
            this.fCloseTool.Size = new System.Drawing.Size(184, 22);
            this.fCloseTool.Text = "終了(&X)";
            // 
            // EditTool
            // 
            this.EditTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eUndo,
            this.eRedo,
            this.toolStripSeparator3,
            this.eCutTool,
            this.eCopyTool,
            this.ePasteTool,
            this.toolStripSeparator4,
            this.eSelectTool});
            this.EditTool.Name = "EditTool";
            this.EditTool.Size = new System.Drawing.Size(57, 23);
            this.EditTool.Text = "編集(&E)";
            // 
            // eUndo
            // 
            this.eUndo.Image = ((System.Drawing.Image)(resources.GetObject("eUndo.Image")));
            this.eUndo.Name = "eUndo";
            this.eUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.eUndo.Size = new System.Drawing.Size(173, 22);
            this.eUndo.Text = "元に戻す(&U)";
            // 
            // eRedo
            // 
            this.eRedo.Image = ((System.Drawing.Image)(resources.GetObject("eRedo.Image")));
            this.eRedo.Name = "eRedo";
            this.eRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.eRedo.Size = new System.Drawing.Size(173, 22);
            this.eRedo.Text = "やり直し(&R)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(170, 6);
            // 
            // eCutTool
            // 
            this.eCutTool.Image = ((System.Drawing.Image)(resources.GetObject("eCutTool.Image")));
            this.eCutTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eCutTool.Name = "eCutTool";
            this.eCutTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.eCutTool.Size = new System.Drawing.Size(173, 22);
            this.eCutTool.Text = "切り取り(&T)";
            // 
            // eCopyTool
            // 
            this.eCopyTool.Image = ((System.Drawing.Image)(resources.GetObject("eCopyTool.Image")));
            this.eCopyTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eCopyTool.Name = "eCopyTool";
            this.eCopyTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.eCopyTool.Size = new System.Drawing.Size(173, 22);
            this.eCopyTool.Text = "コピー(&C)";
            // 
            // ePasteTool
            // 
            this.ePasteTool.Image = ((System.Drawing.Image)(resources.GetObject("ePasteTool.Image")));
            this.ePasteTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ePasteTool.Name = "ePasteTool";
            this.ePasteTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.ePasteTool.Size = new System.Drawing.Size(173, 22);
            this.ePasteTool.Text = "貼り付け(&P)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(170, 6);
            // 
            // eSelectTool
            // 
            this.eSelectTool.Name = "eSelectTool";
            this.eSelectTool.Size = new System.Drawing.Size(173, 22);
            this.eSelectTool.Text = "すべて選択(&A)";
            // 
            // VisualTool
            // 
            this.VisualTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vMenuTool,
            this.toolStripSeparator9,
            this.vToolTool,
            this.vTabTool,
            this.toolStripSeparator10,
            this.vInfoTool});
            this.VisualTool.Name = "VisualTool";
            this.VisualTool.Size = new System.Drawing.Size(58, 23);
            this.VisualTool.Text = "表示(&V)";
            // 
            // vMenuTool
            // 
            this.vMenuTool.Checked = true;
            this.vMenuTool.CheckOnClick = true;
            this.vMenuTool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vMenuTool.Name = "vMenuTool";
            this.vMenuTool.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.vMenuTool.Size = new System.Drawing.Size(144, 22);
            this.vMenuTool.Text = "メニューバー";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(141, 6);
            // 
            // vToolTool
            // 
            this.vToolTool.Checked = true;
            this.vToolTool.CheckOnClick = true;
            this.vToolTool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vToolTool.Name = "vToolTool";
            this.vToolTool.Size = new System.Drawing.Size(144, 22);
            this.vToolTool.Text = "ツールバー";
            // 
            // vTabTool
            // 
            this.vTabTool.Checked = true;
            this.vTabTool.CheckOnClick = true;
            this.vTabTool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vTabTool.Name = "vTabTool";
            this.vTabTool.Size = new System.Drawing.Size(144, 22);
            this.vTabTool.Text = "タブバー";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(141, 6);
            // 
            // vInfoTool
            // 
            this.vInfoTool.Checked = true;
            this.vInfoTool.CheckOnClick = true;
            this.vInfoTool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vInfoTool.Name = "vInfoTool";
            this.vInfoTool.Size = new System.Drawing.Size(144, 22);
            this.vInfoTool.Text = "テーブル情報";
            // 
            // ToolTool
            // 
            this.ToolTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tTablesTool,
            this.tRenameTool,
            this.tSearchTool,
            this.toolStripSeparator6,
            this.tExecuteTool,
            this.tDBcomboTool,
            this.tUpdateTool,
            this.toolStripSeparator7,
            this.tOpacityTool,
            this.tTopmostTool,
            this.tFullScreenTool,
            this.toolStripSeparator8,
            this.tSettingTool});
            this.ToolTool.Name = "ToolTool";
            this.ToolTool.Size = new System.Drawing.Size(60, 23);
            this.ToolTool.Text = "ツール(&T)";
            // 
            // tTablesTool
            // 
            this.tTablesTool.Name = "tTablesTool";
            this.tTablesTool.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tTablesTool.Size = new System.Drawing.Size(184, 22);
            this.tTablesTool.Text = "テーブル一覧";
            // 
            // tRenameTool
            // 
            this.tRenameTool.Name = "tRenameTool";
            this.tRenameTool.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tRenameTool.Size = new System.Drawing.Size(184, 22);
            this.tRenameTool.Text = "タブ名の変更";
            // 
            // tSearchTool
            // 
            this.tSearchTool.Name = "tSearchTool";
            this.tSearchTool.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tSearchTool.Size = new System.Drawing.Size(184, 22);
            this.tSearchTool.Text = "データの検索";
            this.tSearchTool.Click += new System.EventHandler(this.tSearchTool_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(181, 6);
            // 
            // tExecuteTool
            // 
            this.tExecuteTool.Name = "tExecuteTool";
            this.tExecuteTool.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tExecuteTool.Size = new System.Drawing.Size(184, 22);
            this.tExecuteTool.Text = "コマンドの実行";
            // 
            // tDBcomboTool
            // 
            this.tDBcomboTool.Name = "tDBcomboTool";
            this.tDBcomboTool.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.tDBcomboTool.Size = new System.Drawing.Size(184, 22);
            this.tDBcomboTool.Text = "カタログの変更";
            // 
            // tUpdateTool
            // 
            this.tUpdateTool.Name = "tUpdateTool";
            this.tUpdateTool.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.tUpdateTool.Size = new System.Drawing.Size(184, 22);
            this.tUpdateTool.Text = "変更をDBに反映";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(181, 6);
            // 
            // tOpacityTool
            // 
            this.tOpacityTool.Name = "tOpacityTool";
            this.tOpacityTool.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.tOpacityTool.Size = new System.Drawing.Size(184, 22);
            this.tOpacityTool.Text = "フォーム濃度の設定";
            // 
            // tTopmostTool
            // 
            this.tTopmostTool.Name = "tTopmostTool";
            this.tTopmostTool.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.tTopmostTool.Size = new System.Drawing.Size(184, 22);
            this.tTopmostTool.Text = "最前面に表示";
            // 
            // tFullScreenTool
            // 
            this.tFullScreenTool.Name = "tFullScreenTool";
            this.tFullScreenTool.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.tFullScreenTool.Size = new System.Drawing.Size(184, 22);
            this.tFullScreenTool.Text = "全画面表示";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(181, 6);
            // 
            // tSettingTool
            // 
            this.tSettingTool.Name = "tSettingTool";
            this.tSettingTool.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.tSettingTool.Size = new System.Drawing.Size(184, 22);
            this.tSettingTool.Text = "オプション";
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hVersionTool});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // hVersionTool
            // 
            this.hVersionTool.Name = "hVersionTool";
            this.hVersionTool.Size = new System.Drawing.Size(167, 22);
            this.hVersionTool.Text = "バージョン情報(&A)...";
            // 
            // DBcombo
            // 
            this.DBcombo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DBcombo.BackColor = System.Drawing.Color.Silver;
            this.DBcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DBcombo.Name = "DBcombo";
            this.DBcombo.Size = new System.Drawing.Size(121, 23);
            this.DBcombo.SelectedIndexChanged += new System.EventHandler(this.DBcombo_TextChanged);
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.Silver;
            this.formBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeBtn,
            this.flatBtn,
            this.maxBtn,
            this.minBtn,
            this.text,
            this.topMost});
            this.formBar.Location = new System.Drawing.Point(0, 0);
            this.formBar.Name = "formBar";
            this.formBar.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.formBar.Size = new System.Drawing.Size(479, 29);
            this.formBar.TabIndex = 1;
            this.formBar.Text = "formBar";
            this.formBar.Visible = false;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formBar_MouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 23);
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // flatBtn
            // 
            this.flatBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.flatBtn.Image = ((System.Drawing.Image)(resources.GetObject("flatBtn.Image")));
            this.flatBtn.Name = "flatBtn";
            this.flatBtn.Size = new System.Drawing.Size(28, 23);
            this.flatBtn.Visible = false;
            this.flatBtn.Click += new System.EventHandler(this.flatBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.maxBtn.Image = ((System.Drawing.Image)(resources.GetObject("maxBtn.Image")));
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(28, 23);
            this.maxBtn.Click += new System.EventHandler(this.maxBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minBtn.Image = ((System.Drawing.Image)(resources.GetObject("minBtn.Image")));
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(28, 23);
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // text
            // 
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(77, 23);
            this.text.Text = "DataSeeker";
            // 
            // topMost
            // 
            this.topMost.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.topMost.Image = ((System.Drawing.Image)(resources.GetObject("topMost.Image")));
            this.topMost.Name = "topMost";
            this.topMost.Size = new System.Drawing.Size(28, 23);
            this.topMost.Click += new System.EventHandler(this.topMost_Click);
            // 
            // underBar
            // 
            this.underBar.BackColor = System.Drawing.Color.Silver;
            this.underBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableInfomation});
            this.underBar.Location = new System.Drawing.Point(0, 272);
            this.underBar.Name = "underBar";
            this.underBar.Size = new System.Drawing.Size(479, 22);
            this.underBar.SizingGrip = false;
            this.underBar.TabIndex = 5;
            this.underBar.Text = "underBar";
            // 
            // tableInfomation
            // 
            this.tableInfomation.Name = "tableInfomation";
            this.tableInfomation.Size = new System.Drawing.Size(99, 17);
            this.tableInfomation.Text = "Version 4.6.1055.0";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.closeStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SQL Seeker";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // closeStrip
            // 
            this.closeStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeItem});
            this.closeStrip.Name = "contextMenuStrip1";
            this.closeStrip.Size = new System.Drawing.Size(99, 26);
            // 
            // closeItem
            // 
            this.closeItem.Name = "closeItem";
            this.closeItem.Size = new System.Drawing.Size(98, 22);
            this.closeItem.Text = "終了";
            this.closeItem.Click += new System.EventHandler(this.closeItem_Click);
            // 
            // searchStrip
            // 
            this.searchStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolSearchData});
            this.searchStrip.Name = "searchStrip";
            this.searchStrip.Size = new System.Drawing.Size(161, 29);
            // 
            // ToolSearchData
            // 
            this.ToolSearchData.Name = "ToolSearchData";
            this.ToolSearchData.Size = new System.Drawing.Size(100, 23);
            this.ToolSearchData.Text = "抽出対象文字列";
            this.ToolSearchData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolSearchData_KeyDown);
            // 
            // keyboardHook
            // 
            this.keyboardHook.KeyboardHooked += new NewType.Seeker.Interface.Common.KeyboardHookedEventHandler(this.keyboardHook_KeyboardHooked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = global::NewType.Seeker.Properties.Settings.Default.FormSize;
            this.Controls.Add(this.mainPanel);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::NewType.Seeker.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::NewType.Seeker.Properties.Settings.Default, "FormSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("メイリオ", 9F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = global::NewType.Seeker.Properties.Settings.Default.Location;
            this.MainMenuStrip = this.formBar;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DataSeeker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.underBar.ResumeLayout(false);
            this.underBar.PerformLayout();
            this.closeStrip.ResumeLayout(false);
            this.searchStrip.ResumeLayout(false);
            this.searchStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ToolStripMenuItem closeBtn;
        private ToolStripMenuItem flatBtn;
        private ToolStripMenuItem maxBtn;
        private ToolStripMenuItem minBtn;
        public Panel mainPanel;
        private ToolStripMenuItem text;
        public MenuStrip formBar;
        private SplitContainer splitContainer;
        private MenuStrip toolBar;
        private ToolStripMenuItem F1_Tables;
        private ToolStripMenuItem F2_Rename;
        private ToolStripMenuItem F3_Search;
        private ToolStripMenuItem F4_BarVisible;
        private ToolStripMenuItem F5_Execute;
        public ToolStripComboBox DBcombo;
        private ToolStripMenuItem F6_MoveFocus;
        private ToolStripMenuItem F8_Update;
        private ToolStripMenuItem F7_Combo;
        private ToolStripMenuItem F9_Opacity;
        private ToolStripMenuItem F10_TopMost;
        private ToolStripMenuItem F11_FullScreen;
        private ToolStripMenuItem F12_Setting;
        private ToolStripMenuItem topMost;
        private StatusStrip underBar;
        private ToolStripStatusLabel tableInfomation;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip closeStrip;
        private ToolStripMenuItem closeItem;
        private MenuStrip menuBar;
        private ToolStripSeparator sep;
        private ToolStripSeparator sep2;
        private ToolStripSeparator sep3;
        private ToolStripMenuItem FileTool;
        private ToolStripMenuItem fNewTool;
        private ToolStripMenuItem fOpenTool;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem fOverwriteTool;
        private ToolStripMenuItem fSaveTool;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem fOutputTool;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem fCloseTool;
        private ToolStripMenuItem EditTool;
        private ToolStripMenuItem eUndo;
        private ToolStripMenuItem eRedo;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem eCutTool;
        private ToolStripMenuItem eCopyTool;
        private ToolStripMenuItem ePasteTool;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem eSelectTool;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem hVersionTool;
        private ToolStripMenuItem VisualTool;
        private ToolStripMenuItem vMenuTool;
        private ToolStripMenuItem vToolTool;
        private ToolStripMenuItem vTabTool;
        private ToolStripMenuItem vInfoTool;
        private KeyboardHook keyboardHook;
        private ToolStripSeparator sep5;
        private ToolStripMenuItem F0_Redo;
        private ToolStripMenuItem F0_Undo;
        private ToolStripMenuItem F0_Open;
        private ToolStripMenuItem F0_Overwrite;
        private ToolStripMenuItem F0_Save;
        private ToolStripSeparator sep4;
        private ToolStripMenuItem ToolTool;
        private ToolStripMenuItem tTablesTool;
        private ToolStripMenuItem tRenameTool;
        private ToolStripMenuItem tSearchTool;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem tExecuteTool;
        private ToolStripMenuItem tUpdateTool;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem tOpacityTool;
        private ToolStripMenuItem tTopmostTool;
        private ToolStripMenuItem tFullScreenTool;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem tSettingTool;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem tDBcomboTool;
        public Control.TabView.TabView tabView;
        private ContextMenuStrip searchStrip;
        private ToolStripTextBox ToolSearchData;
        private ToolStripMenuItem F0_adComment;
        private ToolStripMenuItem F0_unComment;
        public Sgry.Azuki.WinForms.AzukiControl CommandBox;
    }
}

