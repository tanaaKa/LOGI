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
    public partial class LOGI : Form
    {
        string tempFile = Environment.GetEnvironmentVariable("LocalAppData") + @"\LOGI\temp.txt";
        string logFile = Environment.GetEnvironmentVariable("LocalAppData") +  @"\LOGI\log.txt";
        string dir = Environment.GetEnvironmentVariable("LocalAppData") + @"\LOGI";

        public LOGI()
        {
            InitializeComponent();
        }

        private void LOGI_Load(object sender, EventArgs e)
        {
            // Defaults
            bCheck.Text = "CHECK MODS";
            cbRepo.Text = "Session Repo";

            // TEMP AND LOGGING STUFF
            // Create directory if not exists
            DirectoryInfo di = Directory.CreateDirectory(dir);
            // Create temp file for various uses
            if (File.Exists(tempFile))
            {
                File.Delete(tempFile);
            }
            // Create a new file     
            using (FileStream fs = File.Create(tempFile))
            {
                // Add temp as needed here 
                Byte[] text = new UTF8Encoding(true).GetBytes(DateTime.Now.ToString("ddd, MMMM d, yyyy"));
                fs.Write(text, 0, text.Length);
            }
            // Create log file if not found
            if (!File.Exists(logFile))
            {
                using (StreamWriter sw = (File.Exists(logFile)) ? File.AppendText(logFile) : File.CreateText(logFile))
                {
                    sw.Write("LOGI LOG FILE CREATED\n-------------");
                }
            }
        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            bCheck.Enabled = false;
            settings.getInstallDir();

            // Check mods logic here
            // download = checkMods();
            // if true, then:
            // bCheck.Text = "DOWNLOAD MODS";
            // else:
            // bCheck.Text = "PLAY";
            // serverBrowser();
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            var settingsWindow = new settings();
            settingsWindow.Show();
        }
    }
}
