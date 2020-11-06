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
        public string ARMADIR;
        public string MODSDIR;
        public string TEAMSPEAKDIR;

        

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
            // On load, set directories automagically from registry
            tbArmaDir.Text = getInstallDir(@"SOFTWARE\WOW6432Node\Bohemia Interactive\arma 3", "main");
            MODSDIR = tbArmaDir.Text + @"\COALITION"; // Set default mods dir if found
            tbModsDir.Text = MODSDIR;
            // TO-DO:
            // Teamspeak doesnt read the install directory appropriately for some reason
            // Might be because it's treated as 32bit - defaults to "Not Found" for now
            tbTeamspeakDir.Text = getInstallDir(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\TeamSpeak 3 Client", "InstallLocation");
        }

        private void bReportIssue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet");
        }

        private void bSearchArmaDir_Click(object sender, EventArgs e)
        {
            // Set dir for arma manually if needed
            tbArmaDir.Text = folderDialog(ARMADIR);
        }

        private void bSearchModsDir_Click(object sender, EventArgs e)
        {
            // Set dir for mods manually if needed
            tbModsDir.Text = folderDialog(MODSDIR);
        }

        private void bSearchTeamspeakDir_Click(object sender, EventArgs e)
        {
            // Set dir for teamspeak manually if needed
            tbTeamspeakDir.Text = folderDialog(TEAMSPEAKDIR);
        }
    }
}
