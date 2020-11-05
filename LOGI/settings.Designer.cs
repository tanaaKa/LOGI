namespace LOGI
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bReportIssue = new System.Windows.Forms.Button();
            this.tbArmaDir = new System.Windows.Forms.TextBox();
            this.bSearchArmaDir = new System.Windows.Forms.Button();
            this.tbModsDir = new System.Windows.Forms.TextBox();
            this.bSearchModsDir = new System.Windows.Forms.Button();
            this.tbTeamspeakDir = new System.Windows.Forms.TextBox();
            this.bSearchTeamspeakDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ArmA3 Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mods Directory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teamspeak Directory";
            // 
            // bReportIssue
            // 
            this.bReportIssue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReportIssue.Location = new System.Drawing.Point(473, 237);
            this.bReportIssue.Name = "bReportIssue";
            this.bReportIssue.Size = new System.Drawing.Size(138, 50);
            this.bReportIssue.TabIndex = 3;
            this.bReportIssue.Text = "Report Issue";
            this.bReportIssue.UseVisualStyleBackColor = true;
            this.bReportIssue.Click += new System.EventHandler(this.bReportIssue_Click);
            // 
            // tbArmaDir
            // 
            this.tbArmaDir.Location = new System.Drawing.Point(18, 33);
            this.tbArmaDir.Name = "tbArmaDir";
            this.tbArmaDir.ReadOnly = true;
            this.tbArmaDir.Size = new System.Drawing.Size(558, 23);
            this.tbArmaDir.TabIndex = 4;
            // 
            // bSearchArmaDir
            // 
            this.bSearchArmaDir.Location = new System.Drawing.Point(582, 32);
            this.bSearchArmaDir.Name = "bSearchArmaDir";
            this.bSearchArmaDir.Size = new System.Drawing.Size(29, 23);
            this.bSearchArmaDir.TabIndex = 5;
            this.bSearchArmaDir.Text = "...";
            this.bSearchArmaDir.UseVisualStyleBackColor = true;
            this.bSearchArmaDir.Click += new System.EventHandler(this.bSearchArmaDir_Click);
            // 
            // tbModsDir
            // 
            this.tbModsDir.Location = new System.Drawing.Point(17, 96);
            this.tbModsDir.Name = "tbModsDir";
            this.tbModsDir.ReadOnly = true;
            this.tbModsDir.Size = new System.Drawing.Size(558, 23);
            this.tbModsDir.TabIndex = 6;
            // 
            // bSearchModsDir
            // 
            this.bSearchModsDir.Location = new System.Drawing.Point(582, 96);
            this.bSearchModsDir.Name = "bSearchModsDir";
            this.bSearchModsDir.Size = new System.Drawing.Size(29, 23);
            this.bSearchModsDir.TabIndex = 7;
            this.bSearchModsDir.Text = "...";
            this.bSearchModsDir.UseVisualStyleBackColor = true;
            this.bSearchModsDir.Click += new System.EventHandler(this.bSearchModsDir_Click);
            // 
            // tbTeamspeakDir
            // 
            this.tbTeamspeakDir.Location = new System.Drawing.Point(17, 155);
            this.tbTeamspeakDir.Name = "tbTeamspeakDir";
            this.tbTeamspeakDir.ReadOnly = true;
            this.tbTeamspeakDir.Size = new System.Drawing.Size(558, 23);
            this.tbTeamspeakDir.TabIndex = 8;
            // 
            // bSearchTeamspeakDir
            // 
            this.bSearchTeamspeakDir.Location = new System.Drawing.Point(582, 155);
            this.bSearchTeamspeakDir.Name = "bSearchTeamspeakDir";
            this.bSearchTeamspeakDir.Size = new System.Drawing.Size(29, 23);
            this.bSearchTeamspeakDir.TabIndex = 9;
            this.bSearchTeamspeakDir.Text = "...";
            this.bSearchTeamspeakDir.UseVisualStyleBackColor = true;
            this.bSearchTeamspeakDir.Click += new System.EventHandler(this.bSearchTeamspeakDir_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 300);
            this.Controls.Add(this.bSearchTeamspeakDir);
            this.Controls.Add(this.tbTeamspeakDir);
            this.Controls.Add(this.bSearchModsDir);
            this.Controls.Add(this.tbModsDir);
            this.Controls.Add(this.bSearchArmaDir);
            this.Controls.Add(this.tbArmaDir);
            this.Controls.Add(this.bReportIssue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.Text = "LOGI Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bReportIssue;
        private System.Windows.Forms.TextBox tbArmaDir;
        private System.Windows.Forms.Button bSearchArmaDir;
        private System.Windows.Forms.TextBox tbModsDir;
        private System.Windows.Forms.Button bSearchModsDir;
        private System.Windows.Forms.TextBox tbTeamspeakDir;
        private System.Windows.Forms.Button bSearchTeamspeakDir;
    }
}