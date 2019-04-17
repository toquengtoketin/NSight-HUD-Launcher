using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

namespace NSight_HUD_Launcher
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public static class GlobalVars
        {
            public readonly static string CD = Directory.GetCurrentDirectory() + "\\";
            public readonly static string NSightLauncherPath = CD + "NSight_Path.CFG";
            public readonly static string GitHubVersion = "https://github.com/toquengtoketin/NSight-HUD-Launcher/releases/latest";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            bool isElevated;
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            if (isElevated == false)
            {
                labelIsElevated.ForeColor = Color.Red;
                labelIsElevated.Text = "Privileges Denied - HUD Graphs Inactive";
            }
            if (isElevated == true)
            {
                labelIsElevated.ForeColor = Color.Green;
                labelIsElevated.Text = "Privileges Granted - HUD Graphs Active";
            }

            if (!File.Exists(GlobalVars.NSightLauncherPath))
            {
                if (openFileDialogNSightLauncherLocation.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(GlobalVars.NSightLauncherPath, openFileDialogNSightLauncherLocation.FileName);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

        private void TimerProcessStatus_Tick(object sender, EventArgs e)
        {
            Process[] ProcessImageName = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(openFileDialogBrowseFile.FileName));
            if (ProcessImageName.Length == 0)
            {
                pictureBoxProcessStatus.BackColor = Color.Red;
            }
            else
            {
                pictureBoxProcessStatus.BackColor = Color.Green;
            }
        }

        private void FormMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("created out of spite", "by TOKI");
            e.Cancel = true;
        }

        private void ButtonConfig_Click(object sender, EventArgs e)
        {
            if (openFileDialogNSightLauncherLocation.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(GlobalVars.NSightLauncherPath, openFileDialogNSightLauncherLocation.FileName);
            }
            else
            {
                return;
            }
        }

        private void ButtonBrowseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogBrowseFile.ShowDialog() == DialogResult.OK)
            {
                textBoxSelectedFileName.Text = openFileDialogBrowseFile.FileName;
            }
            else
            {
                return;
            }
        }

        private void ButtonExecute_Click(object sender, EventArgs e)
        {
            Process.Start(File.ReadAllText(GlobalVars.NSightLauncherPath), textBoxSelectedFileName.Text);
        }

        private void LinkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(GlobalVars.GitHubVersion);
            linkLabelGitHub.LinkVisited = false;
        }
    }
}
