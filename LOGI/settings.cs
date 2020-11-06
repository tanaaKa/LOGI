using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGI
{
    public partial class settings : Form
    {
        // Constants for default dirs
        public static string ARMADIR;
        public static string MODSDIR;
        public static string TEAMSPEAKDIR;

        public settings()
        {
            InitializeComponent();
        }

        private string folderDialog(string dir)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    dir = fbd.SelectedPath;
                    return dir;
                }

                return "";
            }
        }

        public static string getInstallDir(string program, string key1)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(program))
                {
                    //MessageBox.Show(key.ToString());
                    if (key != null)
                    {
                        Object o = key.GetValue(key1);
                        //MessageBox.Show(o.ToString());
                        if (o != null)
                        {
                            string registryContent = (Registry.GetValue(key.Name, key1, "")).ToString();
                            return registryContent;
                        }
                    }
                    return "Directory Not Found";
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex + "\n\nCouldn't find one or more directories! Please add them manually.");
                return "Directory Not Found";
            }
        }

        private void settings_Load(object sender, EventArgs e)
        {
            // Set the textboxes to match the strings found in Form1::LOGI_Load method
            tbArmaDir.Text = ARMADIR;
            tbModsDir.Text = MODSDIR;
            tbTeamspeakDir.Text = TEAMSPEAKDIR;
        }

        private void bReportIssue_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tanaaKa/LOGI/issues");
        }

        private void bSearchArmaDir_Click(object sender, EventArgs e)
        {
            // Set dir for arma manually if needed
            ARMADIR = folderDialog(ARMADIR).ToString();
            tbArmaDir.Text = ARMADIR;
        }

        private void bSearchModsDir_Click(object sender, EventArgs e)
        {
            // Set dir for mods manually if needed
            MODSDIR = folderDialog(MODSDIR).ToString();
            tbModsDir.Text = MODSDIR;
        }

        private void bSearchTeamspeakDir_Click(object sender, EventArgs e)
        {
            // Set dir for teamspeak manually if needed
            TEAMSPEAKDIR = folderDialog(TEAMSPEAKDIR).ToString();
            tbTeamspeakDir.Text = TEAMSPEAKDIR;
        }
    }
}
