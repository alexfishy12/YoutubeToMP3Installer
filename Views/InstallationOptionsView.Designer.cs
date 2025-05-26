namespace YoutubeToMP3Installer.Views
{
        partial class InstallationOptionsView
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
                        tableLayoutPanelInstallMain = new TableLayoutPanel();
                        labelInstructions = new Label();
                        tableLayoutPanelDirectoryOption = new TableLayoutPanel();
                        buttonBrowseDirectory = new Button();
                        textBoxInstallationDirectory = new TextBox();
                        labelInstallationDirectory = new Label();
                        tableLayoutPanelInstallMain.SuspendLayout();
                        tableLayoutPanelDirectoryOption.SuspendLayout();
                        SuspendLayout();
                        // 
                        // tableLayoutPanelInstallMain
                        // 
                        tableLayoutPanelInstallMain.ColumnCount = 1;
                        tableLayoutPanelInstallMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                        tableLayoutPanelInstallMain.Controls.Add(labelInstructions, 0, 0);
                        tableLayoutPanelInstallMain.Controls.Add(tableLayoutPanelDirectoryOption, 0, 1);
                        tableLayoutPanelInstallMain.Dock = DockStyle.Fill;
                        tableLayoutPanelInstallMain.Location = new Point(0, 0);
                        tableLayoutPanelInstallMain.Name = "tableLayoutPanelInstallMain";
                        tableLayoutPanelInstallMain.Padding = new Padding(10);
                        tableLayoutPanelInstallMain.RowCount = 2;
                        tableLayoutPanelInstallMain.RowStyles.Add(new RowStyle());
                        tableLayoutPanelInstallMain.RowStyles.Add(new RowStyle());
                        tableLayoutPanelInstallMain.Size = new Size(450, 361);
                        tableLayoutPanelInstallMain.TabIndex = 0;
                        // 
                        // labelInstructions
                        // 
                        labelInstructions.AutoSize = true;
                        labelInstructions.Dock = DockStyle.Fill;
                        labelInstructions.Location = new Point(13, 10);
                        labelInstructions.Name = "labelInstructions";
                        labelInstructions.Padding = new Padding(0, 0, 0, 20);
                        labelInstructions.Size = new Size(424, 65);
                        labelInstructions.TabIndex = 0;
                        labelInstructions.Text = "Choose where to install the application.\r\nBy default, it will be installed in the standard Programs folder. You may select a different location if you prefer.";
                        // 
                        // tableLayoutPanelDirectoryOption
                        // 
                        tableLayoutPanelDirectoryOption.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                        tableLayoutPanelDirectoryOption.AutoSize = true;
                        tableLayoutPanelDirectoryOption.ColumnCount = 3;
                        tableLayoutPanelDirectoryOption.ColumnStyles.Add(new ColumnStyle());
                        tableLayoutPanelDirectoryOption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                        tableLayoutPanelDirectoryOption.ColumnStyles.Add(new ColumnStyle());
                        tableLayoutPanelDirectoryOption.Controls.Add(buttonBrowseDirectory, 2, 0);
                        tableLayoutPanelDirectoryOption.Controls.Add(textBoxInstallationDirectory, 1, 0);
                        tableLayoutPanelDirectoryOption.Controls.Add(labelInstallationDirectory, 0, 0);
                        tableLayoutPanelDirectoryOption.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
                        tableLayoutPanelDirectoryOption.Location = new Point(13, 78);
                        tableLayoutPanelDirectoryOption.Name = "tableLayoutPanelDirectoryOption";
                        tableLayoutPanelDirectoryOption.RowCount = 1;
                        tableLayoutPanelDirectoryOption.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                        tableLayoutPanelDirectoryOption.Size = new Size(424, 29);
                        tableLayoutPanelDirectoryOption.TabIndex = 2;
                        // 
                        // buttonBrowseDirectory
                        // 
                        buttonBrowseDirectory.Dock = DockStyle.Fill;
                        buttonBrowseDirectory.Location = new Point(346, 3);
                        buttonBrowseDirectory.Name = "buttonBrowseDirectory";
                        buttonBrowseDirectory.Size = new Size(75, 23);
                        buttonBrowseDirectory.TabIndex = 2;
                        buttonBrowseDirectory.Text = "Browse";
                        buttonBrowseDirectory.UseVisualStyleBackColor = true;
                        buttonBrowseDirectory.Click += buttonBrowseDirectory_Click;
                        // 
                        // textBoxInstallationDirectory
                        // 
                        textBoxInstallationDirectory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                        textBoxInstallationDirectory.Location = new Point(131, 3);
                        textBoxInstallationDirectory.Name = "textBoxInstallationDirectory";
                        textBoxInstallationDirectory.Size = new Size(209, 23);
                        textBoxInstallationDirectory.TabIndex = 1;
                        // 
                        // labelInstallationDirectory
                        // 
                        labelInstallationDirectory.AutoSize = true;
                        labelInstallationDirectory.Dock = DockStyle.Fill;
                        labelInstallationDirectory.Location = new Point(3, 0);
                        labelInstallationDirectory.Name = "labelInstallationDirectory";
                        labelInstallationDirectory.Size = new Size(122, 29);
                        labelInstallationDirectory.TabIndex = 0;
                        labelInstallationDirectory.Text = "Installation Directory: ";
                        labelInstallationDirectory.TextAlign = ContentAlignment.MiddleCenter;
                        // 
                        // InstallationOptionsView
                        // 
                        AutoScaleDimensions = new SizeF(7F, 15F);
                        AutoScaleMode = AutoScaleMode.Font;
                        AutoSize = true;
                        Controls.Add(tableLayoutPanelInstallMain);
                        Name = "InstallationOptionsView";
                        Size = new Size(450, 361);
                        tableLayoutPanelInstallMain.ResumeLayout(false);
                        tableLayoutPanelInstallMain.PerformLayout();
                        tableLayoutPanelDirectoryOption.ResumeLayout(false);
                        tableLayoutPanelDirectoryOption.PerformLayout();
                        ResumeLayout(false);
                }

                #endregion

                private TableLayoutPanel tableLayoutPanelInstallMain;
                private Label labelInstructions;
                private Label labelInstallationDirectory;
                private TextBox textBoxInstallationDirectory;
                private Button buttonBrowseDirectory;
                private TableLayoutPanel tableLayoutPanelDirectoryOption;
        }
}
