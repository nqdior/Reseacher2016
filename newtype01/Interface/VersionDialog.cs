using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;

namespace NewType.Seeker.Interface
{
    /// <summary>
    /// VerInfoDialog の概要の説明です。
    /// </summary>
    public class VerInfoDialog : System.Windows.Forms.Form
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.Container components = null;

        public VerInfoDialog()
        {
            //
            // Windows フォーム デザイナ サポートに必要です。
            //
            InitializeComponent();

            //
            // TODO: InitializeComponent 呼び出しの後に、コンストラクタ コードを追加してください。
            //
        }

        /// <summary>
        /// 使用されているリソースに後処理を実行します。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード 
        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerInfoDialog));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(96, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(96, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(96, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(345, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(94, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 56);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // VerInfoDialog
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.ClientSize = new System.Drawing.Size(442, 200);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerInfoDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "バージョン情報";
            this.Load += new System.EventHandler(this.VerInfoDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            TopMost = true;

        }
        #endregion

        private void VerInfoDialog_Load(object sender, System.EventArgs e)
        {
            // ***** Applicationクラスのプロパティにより取得 *****
            // バージョン名（AssemblyInformationalVersionAttribute属性）を取得
            string appVersion = Application.ProductVersion;
            // 製品名（AssemblyProductAttribute属性）を取得
            string appProductName = Application.ProductName;
            // 会社名（AssemblyCompanyAttribute属性）を取得
            string appCompanyName = Application.CompanyName;

            // ***** アセンブリから直接取得 *****
            Assembly mainAssembly = Assembly.GetEntryAssembly();

            // コピーライト情報を取得
            string appCopyright = "-";
            object[] CopyrightArray =
                mainAssembly.GetCustomAttributes(
                typeof(AssemblyCopyrightAttribute), false);
            if ((CopyrightArray != null) && (CopyrightArray.Length > 0))
            {
                appCopyright =
                    ((AssemblyCopyrightAttribute)CopyrightArray[0]).Copyright;
            }

            // 詳細情報を取得
            string appDescription = "-";
            object[] DescriptionArray =
                mainAssembly.GetCustomAttributes(
                typeof(AssemblyDescriptionAttribute), false);
            if ((DescriptionArray != null) && (DescriptionArray.Length > 0))
            {
                appDescription =
                    ((AssemblyDescriptionAttribute)DescriptionArray[0]).Description;
            }

            // ***** EXEファイルから直接取得（Win32API使用） *****

            // アプリケーション・アイコンを取得
            Icon appIcon;
            SHFILEINFO shinfo = new SHFILEINFO();
            IntPtr hSuccess = SHGetFileInfo(
                mainAssembly.Location, 0,
                ref shinfo, (uint)Marshal.SizeOf(shinfo),
                SHGFI_ICON | SHGFI_LARGEICON);
            if (hSuccess != IntPtr.Zero)
            {
                appIcon = Icon.FromHandle(shinfo.hIcon);
            }
            else
            {
                appIcon = SystemIcons.Application;
            }

            // ラベルなどにバージョン情報をセット
            pictureBox1.Image = appIcon.ToBitmap();
            Text = appProductName + " のバージョン情報";
            label1.Text = appCompanyName + " " + appProductName;
            label2.Text = "Version " + appVersion;
            label3.Text = appCopyright;
            label4.Text = appDescription;

            // バージョン情報を取得（別バージョン）
            //AssemblyName mainAssemName = mainAssembly.GetName();
            //Version appVersion2 = mainAssemName.Version;
            //MessageBox.Show(appVersion2.ToString());
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        #region アイコン取得用のWin32API

        // SHGetFileInfo関数
        [DllImport("shell32.dll")]
        private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

        // SHGetFileInfo関数で使用するフラグ
        private const uint SHGFI_ICON = 0x100; // アイコン・リソースの取得
        private const uint SHGFI_LARGEICON = 0x0; // 大きいアイコン
        private const uint SHGFI_SMALLICON = 0x1; // 小さいアイコン

        // SHGetFileInfo関数で使用する構造体
        private struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        #endregion
    }
}