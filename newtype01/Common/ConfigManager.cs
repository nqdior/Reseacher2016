using NewType.Seeker.DataBase;
using NewType.Seeker.Properties;
using NewType.Seeker.Control.TabView;

namespace NewType.Seeker.Common
{
    public static class ConfigManager
    {

        public static void SaveConfig(TabView tabView)
        {
            foreach (var f in tabView.TabList)
            {
                string Text = string.Format("tab{0}Text", f.Value.Index.ToString());
                string Sql = string.Format("tab{0}SQL", f.Value.Index.ToString());

                Settings.Default[Text] = f.Value.Item.Text;
                Settings.Default[Sql] = f.Value.SqlCommand;

                Settings.Default.Save();
            }
        }

        public static void LoadConfig(TabView tabView)
        {
            foreach (var f in tabView.TabList)
            {
                string Text = string.Format("tab{0}Text", f.Value.Index.ToString());
                string Sql = string.Format("tab{0}SQL", f.Value.Index.ToString());
                if (string.IsNullOrEmpty(Settings.Default[Text].ToString()))
                {
                    f.Value.Item.Text = Settings.Default[Text].ToString();
                }
                f.Value.SqlCommand = Settings.Default[Sql].ToString();
            }
        }

    }
}
