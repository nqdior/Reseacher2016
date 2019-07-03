namespace NewType.Seeker.Interface
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.formBar = new System.Windows.Forms.MenuStrip();
            this.closeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.text = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rightNewLine = new System.Windows.Forms.CheckBox();
            this.newLine = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.formBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.formBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeBtn,
            this.text});
            this.formBar.Location = new System.Drawing.Point(0, 0);
            this.formBar.Name = "formBar";
            this.formBar.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.formBar.Size = new System.Drawing.Size(400, 26);
            this.formBar.TabIndex = 3;
            this.formBar.Text = "formBar";
            this.formBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuBar_MouseDown);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("メイリオ", 9F);
            this.tabControl1.Location = new System.Drawing.Point(0, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 274);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.rightNewLine);
            this.tabPage1.Controls.Add(this.newLine);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(392, 243);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "表示";
            // 
            // rightNewLine
            // 
            this.rightNewLine.AutoSize = true;
            this.rightNewLine.Location = new System.Drawing.Point(19, 117);
            this.rightNewLine.Name = "rightNewLine";
            this.rightNewLine.Size = new System.Drawing.Size(219, 22);
            this.rightNewLine.TabIndex = 3;
            this.rightNewLine.Text = "テキストボックスの右端で折り返す";
            this.rightNewLine.UseVisualStyleBackColor = true;
            this.rightNewLine.CheckedChanged += new System.EventHandler(this.rightNewLine_CheckedChanged);
            // 
            // newLine
            // 
            this.newLine.AutoSize = true;
            this.newLine.Location = new System.Drawing.Point(19, 89);
            this.newLine.Name = "newLine";
            this.newLine.Size = new System.Drawing.Size(147, 22);
            this.newLine.TabIndex = 2;
            this.newLine.Text = "SQL整形時に改行する";
            this.newLine.UseVisualStyleBackColor = true;
            this.newLine.CheckedChanged += new System.EventHandler(this.newLine_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "テーマカラー";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 26);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.formBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip formBar;
        private System.Windows.Forms.ToolStripMenuItem closeBtn;
        private System.Windows.Forms.ToolStripMenuItem text;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox newLine;
        private System.Windows.Forms.CheckBox rightNewLine;
    }
}