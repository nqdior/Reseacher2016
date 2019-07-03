using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NewType.Seeker.Control.TabView
{
    [Serializable]
    public class TabControls
    {
        public int Index { get; set;}
        public string TabName { get; set; }
        public string SqlCommand { get; set; }
        public DataGridView Dgv { get; set; }
        public Panel Panel { get; set; }
        public TabPage Tab { get; set; }
        public ToolStripMenuItem Item { get; set; }
        public bool Visible
        {
            set
            {
                Dgv.Visible = value;
                Panel.Visible = value;
            }
        }

        public TabControls(TabControl tabControl, string tabName)
        {
            // maxtab <= 9
            if (tabControl.TabCount >= 9) { return; }

            for (Index = 1; Index <= 9; Index++)
            {
                if (!tabControl.TabPages.ContainsKey(tabName + Index.ToString()))
                { break; }
            }
                  
            // MasterName
            TabName = tabName + Index.ToString();

            Dgv = new DataGridView();
            Dgv.Name = "dgv" + Index.ToString();

            Panel = new Panel();
            Panel.Name = "panel" + Index.ToString();

            Tab = new TabPage(TabName);
            Tab.Name = TabName;

            Item = new ToolStripMenuItem();
            Item.Name = TabName;
            Item.Text = TabName;

            // dataGrid  
            Dgv.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            Dgv.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single;
            Dgv.EnableHeadersVisualStyles = false;
            Dgv.BackgroundColor = Color.Silver;
            Dgv.BorderStyle = BorderStyle.None;
            Dgv.Dock = DockStyle.Fill;
            Dgv.Location = new Point(3, 3);
            Dgv.RowTemplate.Height = 21;
            Dgv.Size = new Size(641, 336);
            Dgv.TabIndex = 6;
            Dgv.GridColor = Color.FromArgb(224, 224, 224);

            // tmpPanel
            Panel.Controls.Add(Dgv);
            Panel.Font = new Font("メイリオ", 8);
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(3, 3);
            Panel.Size = new Size(641, 336);
            Panel.TabIndex = 0;

            // tabPage
            Tab.Controls.Add(Panel);
            Tab.Padding = new Padding(3);
            Tab.Size = new Size(647, 342);
            Tab.TabIndex = 1;
            Tab.Text = TabName;
            Tab.UseVisualStyleBackColor = true;

            // StripItem
            Item.Size = new Size(34, 22);
            Item.ShortcutKeys = (Keys.Control | ConvertStringToKeys("D" + Index.ToString()));
            
            // Add
            tabControl.TabPages.Add(Tab);

            Visible = false;
        }

        private Keys ConvertStringToKeys(string keys)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Keys));
            return (Keys)converter.ConvertFromString(keys);
        }
    }
}
