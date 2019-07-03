using System.Collections.Generic;
using System.Windows.Forms;

namespace NewType.Seeker.Control.TabView
{
    partial class TabView
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabView));
            this.basePanel = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBar = new System.Windows.Forms.MenuStrip();
            this.Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.DisConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.addDgv = new System.Windows.Forms.ToolStripMenuItem();
            this.basePanel.SuspendLayout();
            this.tabBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.Controls.Add(this.tabControl);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(442, 271);
            this.basePanel.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(442, 271);
            this.tabControl.TabIndex = 5;
            this.tabControl.Visible = false;
            // 
            // tabBar
            // 
            this.tabBar.BackColor = System.Drawing.Color.Transparent;
            this.tabBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Setting,
            this.DisConnect,
            this.addDgv});
            this.tabBar.Location = new System.Drawing.Point(0, 245);
            this.tabBar.Name = "tabBar";
            this.tabBar.Size = new System.Drawing.Size(442, 26);
            this.tabBar.TabIndex = 3;
            this.tabBar.Text = "menuStrip1";
            // 
            // Setting
            // 
            this.Setting.Image = ((System.Drawing.Image)(resources.GetObject("Setting.Image")));
            this.Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Setting.Name = "Setting";
            this.Setting.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.Setting.Size = new System.Drawing.Size(28, 22);
            this.Setting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Setting.Click += new System.EventHandler(this.configBtn_Click);
            // 
            // DisConnect
            // 
            this.DisConnect.Image = ((System.Drawing.Image)(resources.GetObject("DisConnect.Image")));
            this.DisConnect.Name = "DisConnect";
            this.DisConnect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.DisConnect.Size = new System.Drawing.Size(28, 22);
            this.DisConnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // addDgv
            // 
            this.addDgv.Name = "addDgv";
            this.addDgv.Size = new System.Drawing.Size(30, 22);
            this.addDgv.Text = "+";
            this.addDgv.Visible = false;
            this.addDgv.Click += new System.EventHandler(this.addDgv_Click);
            // 
            // TabView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.basePanel);
            this.Name = "TabView";
            this.Size = new System.Drawing.Size(442, 271);
            this.basePanel.ResumeLayout(false);
            this.tabBar.ResumeLayout(false);
            this.tabBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel basePanel;

        private ToolStripMenuItem addDgv;
        private TabControl tabControl;
        public ToolStripMenuItem Setting;
        public MenuStrip tabBar;
        private ToolStripMenuItem DisConnect;
    }
}
