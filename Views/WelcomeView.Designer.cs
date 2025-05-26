namespace YoutubeToMP3Installer
{
        partial class WelcomeView
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

                #region Component Designer generated code

                /// <summary> 
                /// Required method for Designer support - do not modify 
                /// the contents of this method with the code editor.
                /// </summary>
                private void InitializeComponent()
                {
                        labelWelcomeText = new Label();
                        SuspendLayout();
                        // 
                        // labelWelcomeText
                        // 
                        labelWelcomeText.Dock = DockStyle.Fill;
                        labelWelcomeText.Location = new Point(0, 0);
                        labelWelcomeText.Name = "labelWelcomeText";
                        labelWelcomeText.Size = new Size(500, 500);
                        labelWelcomeText.TabIndex = 0;
                        labelWelcomeText.Text = "Welcome to the FisherBit LLC YouTube to MP3 Converter Setup Wizard.\r\n\r\nThis wizard will guide you through the installation process. Click Begin to continue or Cancel to exit the setup.";
                        labelWelcomeText.TextAlign = ContentAlignment.MiddleCenter;
                        labelWelcomeText.Click += labelWelcomeText_Click;
                        // 
                        // WelcomeView
                        // 
                        AutoScaleDimensions = new SizeF(7F, 15F);
                        AutoScaleMode = AutoScaleMode.Font;
                        Controls.Add(labelWelcomeText);
                        Name = "WelcomeView";
                        Size = new Size(500, 500);
                        ResumeLayout(false);
                }

                #endregion

                private Label labelWelcomeText;
        }
}
