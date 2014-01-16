using System.Windows;

namespace Gui
{
    /// <summary>
    /// Interaction logic for FinishStep.xaml
    /// </summary>
    public partial class FinishStep
    {
        public FinishStep(int stepNumber, int totalSteps)
        {
            InitializeComponent();

            // swap text at end if not install mode ;)
            if(!InstallVariables.IsInstallMode)
            {
                cbStartStudio.Visibility = Visibility.Hidden;
                tbFinish.Visibility = Visibility.Visible;
            }
            else
            {
                cbStartStudio.Visibility = Visibility.Visible;
                tbFinish.Visibility = Visibility.Hidden;

                // Force a studio start ;)
                InstallVariables.StartStudioOnExit = true;
            }
            DataContext = new InfoStepDataContext(stepNumber, totalSteps);
        }

        void BtnExitWithStart(object sender, RoutedEventArgs e)
        {
            // swap the start flag ;)
            InstallVariables.StartStudioOnExit = !(InstallVariables.StartStudioOnExit);
        }

    }
}
