using YoutubeToMP3Installer.Views;

namespace YoutubeToMP3Installer
{
        public partial class Form1 : Form
        {
                public Form1()
                {
                        InitializeComponent();
                }
                public void ShowView(UserControl view)
                {
                        panelContent.Controls.Clear();
                        panelContent.Controls.Add(view);
                        view.Dock = DockStyle.Fill;
                }

                private void Form1_Load(object sender, EventArgs e)
                {
                        labelTitle.Text = "Welcome";
                        ShowStep(WizardStep.Welcome);
                }
                private enum WizardStep
                {
                        Welcome,
                        InstallationOptions,
                        Installing,
                        Finished
                }

                private WizardStep currentStep;

                private void ShowStep(WizardStep step)
                {
                        currentStep = step;

                        switch (step)
                        {
                                case WizardStep.Welcome:
                                        labelTitle.Text = "Welcome";
                                        ShowView(new WelcomeView(this));
                                        buttonBack.Visible = false;
                                        buttonNext.Visible = true;
                                        buttonNext.Text = "Begin";
                                        buttonCancel.Visible = true;
                                        break;

                                case WizardStep.InstallationOptions:
                                        labelTitle.Text = "Choose Install Directory";
                                        ShowView(new InstallationOptionsView(this));
                                        buttonBack.Visible = true;
                                        buttonNext.Visible = true;
                                        buttonNext.Text = "Install";
                                        buttonCancel.Visible = true;
                                        break;

                                case WizardStep.Installing:
                                        labelTitle.Text = "Installing...";
                                        //ShowView(new InstallProgressView(this));
                                        buttonBack.Visible = false;
                                        buttonNext.Visible = false;
                                        buttonCancel.Visible = false;
                                        break;

                                case WizardStep.Finished:
                                        labelTitle.Text = "Installation Complete!";
                                        //ShowView(new FinishView(this));
                                        buttonBack.Visible = false;
                                        buttonNext.Visible = true;
                                        buttonNext.Text = "Finish";
                                        buttonCancel.Visible = false;
                                        break;
                        }
                }

                private void buttonNext_Click(object sender, EventArgs e)
                {
                        if (buttonNext.Text == "Finish")
                        {
                                this.Close();
                                return;
                        }
                        ShowStep(currentStep + 1);
                }

                private void buttonBack_Click(object sender, EventArgs e)
                {
                        ShowStep(currentStep - 1);
                }

                private void buttonCancel_Click(object sender, EventArgs e)
                {
                        this.Close();
                        return;
                }
        }  
}
