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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGI));
            this.pbBar = new System.Windows.Forms.ProgressBar();
            this.bCheck = new System.Windows.Forms.Button();
            this.bSettings = new System.Windows.Forms.Button();
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
            this.bCheck.Location = new System.Drawing.Point(788, 441);
            this.bCheck.Name = "bCheck";
            this.bCheck.Size = new System.Drawing.Size(133, 66);
            this.bCheck.TabIndex = 1;
            this.bCheck.Text = "CHECK MODS";
            this.bCheck.UseVisualStyleBackColor = true;
            this.bCheck.Click += new System.EventHandler(this.bCheck_Click);
            // 
            // bSettings
            // 
            this.bSettings.Image = ((System.Drawing.Image)(resources.GetObject("bSettings.Image")));
            this.bSettings.Location = new System.Drawing.Point(736, 474);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(46, 33);
            this.bSettings.TabIndex = 2;
            this.bSettings.UseVisualStyleBackColor = true;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // LOGI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.bCheck);
            this.Controls.Add(this.pbBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LOGI";
            this.Text = "LOGI Launcher";
            this.Load += new System.EventHandler(this.LOGI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbBar;
        private System.Windows.Forms.Button bCheck;
        private System.Windows.Forms.Button bSettings;
    }
}

