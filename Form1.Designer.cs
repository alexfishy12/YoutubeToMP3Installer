namespace YoutubeToMP3Installer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
                ///  Required method for Designer support - do not modify
                ///  the contents of this method with the code editor.
                /// </summary>
                private void InitializeComponent()
                {
                        tableLayoutPanelMain = new TableLayoutPanel();
                        labelTitle = new Label();
                        panelFooter = new Panel();
                        flowLayoutPanel1 = new FlowLayoutPanel();
                        buttonNext = new Button();
                        buttonBack = new Button();
                        buttonCancel = new Button();
                        panelContent = new Panel();
                        labelInformation = new Label();
                        tableLayoutPanelMain.SuspendLayout();
                        panelFooter.SuspendLayout();
                        flowLayoutPanel1.SuspendLayout();
                        panelContent.SuspendLayout();
                        SuspendLayout();
                        // 
                        // tableLayoutPanelMain
                        // 
                        tableLayoutPanelMain.ColumnCount = 1;
                        tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                        tableLayoutPanelMain.Controls.Add(labelTitle, 0, 0);
                        tableLayoutPanelMain.Controls.Add(panelFooter, 0, 2);
                        tableLayoutPanelMain.Controls.Add(panelContent, 0, 1);
                        tableLayoutPanelMain.Dock = DockStyle.Fill;
                        tableLayoutPanelMain.Location = new Point(0, 0);
                        tableLayoutPanelMain.Name = "tableLayoutPanelMain";
                        tableLayoutPanelMain.Padding = new Padding(10);
                        tableLayoutPanelMain.RowCount = 1;
                        tableLayoutPanelMain.RowStyles.Add(new RowStyle());
                        tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                        tableLayoutPanelMain.RowStyles.Add(new RowStyle());
                        tableLayoutPanelMain.Size = new Size(552, 399);
                        tableLayoutPanelMain.TabIndex = 0;
                        // 
                        // labelTitle
                        // 
                        labelTitle.AutoSize = true;
                        labelTitle.Dock = DockStyle.Fill;
                        labelTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
                        labelTitle.Location = new Point(13, 10);
                        labelTitle.Name = "labelTitle";
                        labelTitle.Size = new Size(526, 30);
                        labelTitle.TabIndex = 7;
                        labelTitle.Text = "YouTube to MP3 Converter Installation Setup";
                        labelTitle.TextAlign = ContentAlignment.MiddleCenter;
                        // 
                        // panelFooter
                        // 
                        panelFooter.AutoSize = true;
                        panelFooter.Controls.Add(flowLayoutPanel1);
                        panelFooter.Dock = DockStyle.Fill;
                        panelFooter.Location = new Point(13, 357);
                        panelFooter.Name = "panelFooter";
                        panelFooter.Size = new Size(526, 29);
                        panelFooter.TabIndex = 8;
                        // 
                        // flowLayoutPanel1
                        // 
                        flowLayoutPanel1.AutoSize = true;
                        flowLayoutPanel1.Controls.Add(buttonNext);
                        flowLayoutPanel1.Controls.Add(buttonBack);
                        flowLayoutPanel1.Controls.Add(buttonCancel);
                        flowLayoutPanel1.Dock = DockStyle.Fill;
                        flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
                        flowLayoutPanel1.Location = new Point(0, 0);
                        flowLayoutPanel1.Name = "flowLayoutPanel1";
                        flowLayoutPanel1.Size = new Size(526, 29);
                        flowLayoutPanel1.TabIndex = 0;
                        // 
                        // buttonNext
                        // 
                        buttonNext.Location = new Point(448, 3);
                        buttonNext.Name = "buttonNext";
                        buttonNext.Size = new Size(75, 23);
                        buttonNext.TabIndex = 1;
                        buttonNext.Text = "Next";
                        buttonNext.UseVisualStyleBackColor = true;
                        buttonNext.Click += buttonNext_Click;
                        // 
                        // buttonBack
                        // 
                        buttonBack.Location = new Point(367, 3);
                        buttonBack.Name = "buttonBack";
                        buttonBack.Size = new Size(75, 23);
                        buttonBack.TabIndex = 0;
                        buttonBack.Text = "Back";
                        buttonBack.UseVisualStyleBackColor = true;
                        buttonBack.Click += buttonBack_Click;
                        // 
                        // buttonCancel
                        // 
                        buttonCancel.Location = new Point(286, 3);
                        buttonCancel.Name = "buttonCancel";
                        buttonCancel.Size = new Size(75, 23);
                        buttonCancel.TabIndex = 3;
                        buttonCancel.Text = "Cancel";
                        buttonCancel.UseVisualStyleBackColor = true;
                        buttonCancel.Click += buttonCancel_Click;
                        // 
                        // panelContent
                        // 
                        panelContent.Controls.Add(labelInformation);
                        panelContent.Dock = DockStyle.Fill;
                        panelContent.Location = new Point(13, 43);
                        panelContent.Name = "panelContent";
                        panelContent.Size = new Size(526, 308);
                        panelContent.TabIndex = 9;
                        // 
                        // labelInformation
                        // 
                        labelInformation.Dock = DockStyle.Fill;
                        labelInformation.Location = new Point(0, 0);
                        labelInformation.Name = "labelInformation";
                        labelInformation.Size = new Size(526, 308);
                        labelInformation.TabIndex = 7;
                        labelInformation.Text = "This setup program will install FisherBit LLC's YouTube to MP3 Converter onto your computer.";
                        labelInformation.TextAlign = ContentAlignment.MiddleCenter;
                        // 
                        // Form1
                        // 
                        AutoScaleDimensions = new SizeF(7F, 15F);
                        AutoScaleMode = AutoScaleMode.Font;
                        ClientSize = new Size(552, 399);
                        Controls.Add(tableLayoutPanelMain);
                        Name = "Form1";
                        Text = "YouTube to MP3 Installer";
                        Load += Form1_Load;
                        tableLayoutPanelMain.ResumeLayout(false);
                        tableLayoutPanelMain.PerformLayout();
                        panelFooter.ResumeLayout(false);
                        panelFooter.PerformLayout();
                        flowLayoutPanel1.ResumeLayout(false);
                        panelContent.ResumeLayout(false);
                        ResumeLayout(false);
                }

                #endregion

                private TableLayoutPanel tableLayoutPanelMain;
                private Label labelTitle;
                private Panel panelFooter;
                private Panel panelContent;
                private Label labelInformation;
                private FlowLayoutPanel flowLayoutPanel1;
                private Button buttonBack;
                private Button buttonNext;
                private Button buttonCancel;
        }
}
