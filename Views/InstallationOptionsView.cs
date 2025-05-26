using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeToMP3Installer.Views
{
        public partial class InstallationOptionsView : UserControl
        {
                public InstallationOptionsView(Form1 form)
                {
                        InitializeComponent();
                        SetDefaultInstallPath();
                }

                private void SetDefaultInstallPath()
                {
                        String defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\FisherBitLLC\YouTubeToMP3";
                        textBoxInstallationDirectory.Text = defaultPath;
                }

                private void buttonBrowseDirectory_Click(object sender, EventArgs e)
                {
                        using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                        {
                                dialog.Description = "Select the folder where you want to install the application.";
                                dialog.UseDescriptionForTitle = true; // shows description as window title ( on newer versions of windows)
                                dialog.ShowNewFolderButton = true;

                                if (dialog.ShowDialog() == DialogResult.OK)
                                {
                                        textBoxInstallationDirectory.Text = dialog.SelectedPath;
                                }
                        }
                }
        }
}