namespace NSight_HUD_Launcher
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxSelectedFileName = new System.Windows.Forms.TextBox();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.openFileDialogNSightLauncherLocation = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogBrowseFile = new System.Windows.Forms.OpenFileDialog();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.labelIsElevated = new System.Windows.Forms.Label();
            this.timerProcessStatus = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxProcessStatus = new System.Windows.Forms.PictureBox();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSelectedFileName
            // 
            this.textBoxSelectedFileName.Location = new System.Drawing.Point(12, 65);
            this.textBoxSelectedFileName.Name = "textBoxSelectedFileName";
            this.textBoxSelectedFileName.Size = new System.Drawing.Size(376, 20);
            this.textBoxSelectedFileName.TabIndex = 2;
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.BackColor = System.Drawing.Color.Transparent;
            this.buttonBrowseFile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBrowseFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseFile.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBrowseFile.Location = new System.Drawing.Point(12, 36);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFile.TabIndex = 1;
            this.buttonBrowseFile.Text = "Browse";
            this.buttonBrowseFile.UseVisualStyleBackColor = false;
            this.buttonBrowseFile.Click += new System.EventHandler(this.ButtonBrowseFile_Click);
            // 
            // openFileDialogNSightLauncherLocation
            // 
            this.openFileDialogNSightLauncherLocation.FileName = "Nvda.Launcher.exe";
            this.openFileDialogNSightLauncherLocation.Title = "NSight HUD Launcher - Select Location";
            // 
            // openFileDialogBrowseFile
            // 
            this.openFileDialogBrowseFile.FileName = "application.exe";
            this.openFileDialogBrowseFile.Title = "Select An Application";
            // 
            // buttonExecute
            // 
            this.buttonExecute.BackColor = System.Drawing.Color.Transparent;
            this.buttonExecute.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonExecute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExecute.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonExecute.Location = new System.Drawing.Point(313, 91);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 23);
            this.buttonExecute.TabIndex = 3;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.ButtonExecute_Click);
            // 
            // buttonConfig
            // 
            this.buttonConfig.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfig.FlatAppearance.BorderSize = 0;
            this.buttonConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfig.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonConfig.Location = new System.Drawing.Point(313, 12);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonConfig.TabIndex = 0;
            this.buttonConfig.Text = "Config";
            this.buttonConfig.UseVisualStyleBackColor = false;
            this.buttonConfig.Click += new System.EventHandler(this.ButtonConfig_Click);
            // 
            // labelIsElevated
            // 
            this.labelIsElevated.AutoSize = true;
            this.labelIsElevated.BackColor = System.Drawing.Color.Transparent;
            this.labelIsElevated.ForeColor = System.Drawing.SystemColors.Control;
            this.labelIsElevated.Location = new System.Drawing.Point(12, 128);
            this.labelIsElevated.Name = "labelIsElevated";
            this.labelIsElevated.Size = new System.Drawing.Size(57, 13);
            this.labelIsElevated.TabIndex = 4;
            this.labelIsElevated.Text = "IsElevated";
            // 
            // timerProcessStatus
            // 
            this.timerProcessStatus.Enabled = true;
            this.timerProcessStatus.Interval = 1000;
            this.timerProcessStatus.Tick += new System.EventHandler(this.TimerProcessStatus_Tick);
            // 
            // pictureBoxProcessStatus
            // 
            this.pictureBoxProcessStatus.Location = new System.Drawing.Point(372, 125);
            this.pictureBoxProcessStatus.Name = "pictureBoxProcessStatus";
            this.pictureBoxProcessStatus.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxProcessStatus.TabIndex = 5;
            this.pictureBoxProcessStatus.TabStop = false;
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabelGitHub.AutoSize = true;
            this.linkLabelGitHub.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelGitHub.LinkColor = System.Drawing.Color.Green;
            this.linkLabelGitHub.Location = new System.Drawing.Point(12, 9);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(40, 13);
            this.linkLabelGitHub.TabIndex = 6;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "GitHub";
            this.linkLabelGitHub.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelGitHub_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NSight_HUD_Launcher.Properties.Resources.nvidia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.linkLabelGitHub);
            this.Controls.Add(this.pictureBoxProcessStatus);
            this.Controls.Add(this.labelIsElevated);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonBrowseFile);
            this.Controls.Add(this.textBoxSelectedFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NSight HUD Launcher";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormMain_HelpButtonClicked);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSelectedFileName;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogNSightLauncherLocation;
        private System.Windows.Forms.OpenFileDialog openFileDialogBrowseFile;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Label labelIsElevated;
        private System.Windows.Forms.Timer timerProcessStatus;
        private System.Windows.Forms.PictureBox pictureBoxProcessStatus;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
    }
}

