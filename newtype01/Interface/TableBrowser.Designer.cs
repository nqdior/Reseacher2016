using System.Drawing;
using System.Windows.Forms;

namespace NewType.Seeker.Interface
{
    partial class TableBrowser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableBrowser));
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.tableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cols = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.テーブルを表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dgv2 = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boolnull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.text = new System.Windows.Forms.ToolStripMenuItem();
            this.formBar = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.subMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv2)).BeginInit();
            this.formBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AllowUserToResizeColumns = false;
            this.Dgv.AllowUserToResizeRows = false;
            this.Dgv.BackgroundColor = System.Drawing.Color.Silver;
            this.Dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tableName,
            this.rows,
            this.cols});
            this.Dgv.ContextMenuStrip = this.subMenu;
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv.EnableHeadersVisualStyles = false;
            this.Dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv.Location = new System.Drawing.Point(0, 2);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.RowTemplate.Height = 21;
            this.Dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.ShowCellErrors = false;
            this.Dgv.ShowCellToolTips = false;
            this.Dgv.ShowEditingIcon = false;
            this.Dgv.ShowRowErrors = false;
            this.Dgv.Size = new System.Drawing.Size(303, 302);
            this.Dgv.TabIndex = 6;
            this.Dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            this.Dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellDoubleClick);
            this.Dgv.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_CellMouseDown);
            this.Dgv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_KeyDown);
            // 
            // tableName
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tableName.DefaultCellStyle = dataGridViewCellStyle1;
            this.tableName.HeaderText = "tableName";
            this.tableName.Name = "tableName";
            this.tableName.ReadOnly = true;
            this.tableName.Width = 145;
            // 
            // rows
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.rows.DefaultCellStyle = dataGridViewCellStyle2;
            this.rows.HeaderText = "rows";
            this.rows.Name = "rows";
            this.rows.ReadOnly = true;
            this.rows.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rows.Width = 70;
            // 
            // cols
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cols.DefaultCellStyle = dataGridViewCellStyle3;
            this.cols.HeaderText = "cols";
            this.cols.Name = "cols";
            this.cols.ReadOnly = true;
            this.cols.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cols.Width = 70;
            // 
            // subMenu
            // 
            this.subMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.テーブルを表示ToolStripMenuItem});
            this.subMenu.Name = "subMenu";
            this.subMenu.Size = new System.Drawing.Size(115, 26);
            // 
            // テーブルを表示ToolStripMenuItem
            // 
            this.テーブルを表示ToolStripMenuItem.Name = "テーブルを表示ToolStripMenuItem";
            this.テーブルを表示ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.テーブルを表示ToolStripMenuItem.Text = "表示 (*)";
            this.テーブルを表示ToolStripMenuItem.Click += new System.EventHandler(this.テーブルを表示ToolStripMenuItem_Click);
            // 
            // Dgv2
            // 
            this.Dgv2.AllowUserToAddRows = false;
            this.Dgv2.AllowUserToDeleteRows = false;
            this.Dgv2.AllowUserToResizeColumns = false;
            this.Dgv2.AllowUserToResizeRows = false;
            this.Dgv2.BackgroundColor = System.Drawing.Color.Silver;
            this.Dgv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.type,
            this.length,
            this.boolnull,
            this.PK});
            this.Dgv2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Dgv2.EnableHeadersVisualStyles = false;
            this.Dgv2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dgv2.Location = new System.Drawing.Point(308, 2);
            this.Dgv2.MultiSelect = false;
            this.Dgv2.Name = "Dgv2";
            this.Dgv2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Dgv2.RowHeadersVisible = false;
            this.Dgv2.RowTemplate.Height = 21;
            this.Dgv2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv2.ShowCellErrors = false;
            this.Dgv2.ShowCellToolTips = false;
            this.Dgv2.ShowEditingIcon = false;
            this.Dgv2.ShowRowErrors = false;
            this.Dgv2.Size = new System.Drawing.Size(467, 302);
            this.Dgv2.TabIndex = 7;
            // 
            // columnName
            // 
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.columnName.DefaultCellStyle = dataGridViewCellStyle4;
            this.columnName.HeaderText = "columnName";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            this.columnName.Width = 130;
            // 
            // type
            // 
            this.type.HeaderText = "type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 80;
            // 
            // length
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.length.DefaultCellStyle = dataGridViewCellStyle5;
            this.length.HeaderText = "length";
            this.length.Name = "length";
            this.length.ReadOnly = true;
            this.length.Width = 80;
            // 
            // boolnull
            // 
            this.boolnull.HeaderText = "null";
            this.boolnull.Name = "boolnull";
            this.boolnull.ReadOnly = true;
            this.boolnull.Width = 80;
            // 
            // PK
            // 
            this.PK.HeaderText = "PK";
            this.PK.Name = "PK";
            this.PK.ReadOnly = true;
            this.PK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PK.Width = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(303, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 302);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(775, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 302);
            this.panel2.TabIndex = 9;
            // 
            // closeBtn
            // 
            this.closeBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 20);
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // text
            // 
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(12, 20);
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.formBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeBtn,
            this.text});
            this.formBar.Location = new System.Drawing.Point(0, 2);
            this.formBar.Name = "formBar";
            this.formBar.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.formBar.Size = new System.Drawing.Size(780, 26);
            this.formBar.TabIndex = 2;
            this.formBar.Text = "formBar";
            this.formBar.Visible = false;
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuBar_MouseDown);
            // 
            // TableBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(780, 306);
            this.Controls.Add(this.Dgv);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.formBar);
            this.Font = new System.Drawing.Font("メイリオ", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TableBrowser";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.BrowseTable_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TableBrowser_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.subMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv2)).EndInit();
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv;
        private DataGridView Dgv2;
        private DataGridViewTextBoxColumn tableName;
        private DataGridViewTextBoxColumn rows;
        private DataGridViewTextBoxColumn cols;
        private DataGridViewTextBoxColumn columnName;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn length;
        private DataGridViewTextBoxColumn boolnull;
        private DataGridViewTextBoxColumn PK;
        private Panel panel1;
        private Panel panel2;
        private ContextMenuStrip subMenu;
        private ToolStripMenuItem テーブルを表示ToolStripMenuItem;
        private ToolStripMenuItem closeBtn;
        private ToolStripMenuItem text;
        public MenuStrip formBar;
    }
}