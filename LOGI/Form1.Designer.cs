namespace LOGI
{
    partial class LOGI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGI));
            this.pbBar = new System.Windows.Forms.ProgressBar();
            this.bCheck = new System.Windows.Forms.Button();
            this.bSettings = new System.Windows.Forms.Button();
            this.cbRepo = new System.Windows.Forms.ComboBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.sliderTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBar
            // 
            this.pbBar.Location = new System.Drawing.Point(12, 474);
            this.pbBar.Name = "pbBar";
            this.pbBar.Size = new System.Drawing.Size(659, 33);
            this.pbBar.TabIndex = 0;
            // 
            // bCheck
            // 
            this.bCheck.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.bCheck.Location = new System.Drawing.Point(762, 441);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(159, 66);
            this.bCheck.TabIndex = 1;
            this.bCheck.Text = "CHECK MODS";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // bSettings
            // 
            this.bSettings.Image = ((System.Drawing.Image)(resources.GetObject("bSettings.Image")));
            this.bSettings.Location = new System.Drawing.Point(710, 474);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(46, 33);
            this.bSettings.TabIndex = 2;
            this.bSettings.UseVisualStyleBackColor = true;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // cbRepo
            // 
            this.cbRepo.FormattingEnabled = true;
            this.cbRepo.Items.AddRange(new object[] {
            "Session Repo"});
            this.cbRepo.Location = new System.Drawing.Point(762, 412);
            this.cbRepo.Name = "cbRepo";
            this.cbRepo.Size = new System.Drawing.Size(159, 23);
            this.cbRepo.TabIndex = 3;
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(12, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(909, 382);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // sliderTimer
            // 
            this.sliderTimer.Enabled = true;
            this.sliderTimer.Interval = 10000;
            this.sliderTimer.Tick += new System.EventHandler(this.sliderTimer_Tick);
            // 
            // LOGI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.cbRepo);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.pbBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOGI";
            this.Text = "LOGI Launcher";
            this.Load += new System.EventHandler(this.LOGI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbBar;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.ComboBox cbRepo;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Timer sliderTimer;
    }
}

