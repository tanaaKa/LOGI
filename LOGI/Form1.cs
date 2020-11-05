using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LOGI
{
    public partial class LOGI : Form
    {
        public LOGI()
        {
            InitializeComponent();
        }

        private void LOGI_Load(object sender, EventArgs e)
        {
            //Defaults
            bCheck.Text = "CHECK MODS";
            cbRepo.Text = "Session Repo";


        }

        private void bCheck_Click(object sender, EventArgs e)
        {
            bCheck.Enabled = false;

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
