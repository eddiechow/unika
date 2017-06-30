using MetroFramework.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace BackendForCompany
{
    class Language
    {
        private static string[][] languageList = {
            //new string {"Language Name", "Language Code"}
            new string[] { "English", "en-US"},
            new string[] { "繁體中文", "zh-Hant"}
        };

        private static Properties.Settings setting = Properties.Settings.Default;

        public static void setLanguageComboBox(MetroComboBox comboBox)
        {
            //Create a language list
            BindingList<KeyValuePair<string, string>> languageList = new BindingList<KeyValuePair<string, string>>();

            //Clear the combox
            comboBox.DataSource = null;
            comboBox.Items.Clear();
            comboBox.Refresh();

            //Bind the combobox
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
            comboBox.DataSource = languageList;

            //Add Language name and Language code to list
            for (int i = 0; i < Language.languageList.Length; i++)
                languageList.Add(new KeyValuePair<string, string>(Language.languageList[i][0], Language.languageList[i][1]));

            for (int i = 0; i <= Language.languageList.Length; i++)
            {
                if (i == Language.languageList.Length || string.IsNullOrEmpty(setting.language))
                {
                    setLanguage("en-US");
                    comboBox.SelectedValue = "en-US";
                    break;
                }
                else if (i < Language.languageList.Length)
                {
                    if (setting.language.Equals(Language.languageList[i][1]))
                    {
                        comboBox.SelectedValue = Language.languageList[i][1];
                        break;
                    }
                }
            }

        }

        public static void setLanguage(string language)
        {
            try
            {
                for (int i = 0; i <= languageList.Length; i++)
                {
                    if (i == languageList.Length || string.IsNullOrEmpty(language))
                        setting.language = "en-US";
                    else if (i < languageList.Length)
                    {
                        if (language.Equals(languageList[i][1]))
                        {
                            setting.language = language;
                            break;
                        }
                    }
                }

                setting.Save();

                CultureInfo ci = new CultureInfo(setting.language);
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;

                foreach (Form form in Application.OpenForms)
                {
                    ComponentResourceManager manager = new ComponentResourceManager(form.GetType());
                    applyResources(manager, form.Controls);
                }
            }
            catch (CultureNotFoundException)
            {
                CultureInfo ci = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
                setting.language = "en-US";
                setting.Save();
            }
            catch (System.ArgumentException)
            {
                CultureInfo ci = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
                setting.language = "en-US";
                setting.Save();
            }
        }

        private static void applyResources(ComponentResourceManager manager, Control.ControlCollection ctls)
        {
            foreach (Control ctl in ctls)
            {
                manager.ApplyResources(ctl, ctl.Name);
                applyResources(manager, ctl.Controls);
            }
        }

        public static string getLanguageCode()
        {
            return setting.language;
        }

    }
}