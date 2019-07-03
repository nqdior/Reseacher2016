namespace NewType.Seeker.Interface
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.panel = new System.Windows.Forms.Panel();
            this.connectBtn = new System.Windows.Forms.Button();
            this.testBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.formBar = new System.Windows.Forms.MenuStrip();
            this.closeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.text = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.formBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Font = new System.Drawing.Font("メイリオ", 9F);
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(406, 197);
            this.propertyGrid.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.propertyGrid);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(3, 29);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(406, 197);
            this.panel.TabIndex = 1;
            // 
            // connectBtn
            // 
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Font = new System.Drawing.Font("メイリオ", 9F);
            this.connectBtn.Location = new System.Drawing.Point(221, 6);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(98, 31);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // testBtn
            // 
            this.testBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testBtn.Font = new System.Drawing.Font("メイリオ", 9F);
            this.testBtn.Location = new System.Drawing.Point(12, 6);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(66, 31);
            this.testBtn.TabIndex = 3;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("メイリオ", 9F);
            this.cancelBtn.Location = new System.Drawing.Point(325, 6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 31);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // formBar
            // 
            this.formBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.formBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeBtn,
            this.text});
            this.formBar.Location = new System.Drawing.Point(3, 3);
            this.formBar.Name = "formBar";
            this.formBar.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.formBar.Size = new System.Drawing.Size(406, 26);
            this.formBar.TabIndex = 5;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.connectBtn);
            this.panel1.Controls.Add(this.testBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 49);
            this.panel1.TabIndex = 6;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 278);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConnectionForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ConnectionForm";
            this.panel.ResumeLayout(false);
            this.formBar.ResumeLayout(false);
            this.formBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button cancelBtn;
        public System.Windows.Forms.MenuStrip formBar;
        private System.Windows.Forms.ToolStripMenuItem closeBtn;
        private System.Windows.Forms.ToolStripMenuItem text;
        private System.Windows.Forms.Panel panel1;
    }
}