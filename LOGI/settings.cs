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
using LOGI.FileIO;

namespace LOGI
{
    public partial class settings : Form
    {
        // Constants for default dirs
        public static string ARMADIR = string.Empty;
        public static string MODSDIR = string.Empty;
        public static string TEAMSPEAKDIR = string.Empty;
        private DirectoryChecker directoryChecker = new DirectoryChecker();


        public settings()
        {
            InitializeComponent();
          
        }

        private string folderDialog(string dir,string dirName)
        {
            
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string tempPath = fbd.SelectedPath;
                    directoryChecker.directories[dirName] = tempPath;
                    return tempPath;
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
            //Get directories from JSON
           
            // On load, set directories automagically from registry
            // ARMADIR = getInstallDir(@"SOFTWARE\WOW6432Node\Bohemia Interactive\arma 3", "main");
            // MODSDIR = ARMADIR + @"\COALITION";
            //TEAMSPEAKDIR = getInstallDir(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\TeamSpeak 3 Client", "InstallLocation");


            tbArmaDir.Text = ARMADIR;
            // Set default mods dir if found
            tbModsDir.Text = MODSDIR;
            // TO-DO:
            // Teamspeak doesnt read the install directory appropriately for some reason
            // Might be because it's treated as 32bit - defaults to "Not Found" for now
           
            tbTeamspeakDir.Text = TEAMSPEAKDIR;

            //Set directories
            
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
            tbArmaDir.Text = folderDialog(ARMADIR,nameof(ARMADIR));
            ARMADIR = tbArmaDir.Text;
        }

        private void bSearchModsDir_Click(object sender, EventArgs e)
        {
            tbModsDir.Text = folderDialog(MODSDIR,nameof(MODSDIR));
            MODSDIR = tbModsDir.Text;
        }

        private void bSearchTeamspeakDir_Click(object sender, EventArgs e)
        {
            // Set dir for teamspeak manually if needed
            tbTeamspeakDir.Text = folderDialog(TEAMSPEAKDIR,nameof(TEAMSPEAKDIR));
            TEAMSPEAKDIR = tbTeamspeakDir.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save directories to JSON
            directoryChecker.directories[nameof(ARMADIR)] = ARMADIR;
            directoryChecker.directories[nameof(MODSDIR)] = MODSDIR;
            directoryChecker.directories[nameof(TEAMSPEAKDIR)] = TEAMSPEAKDIR;
            directoryChecker.setDirectories();
        }
    }
}
