using System.Windows;

namespace Programming2B_ST10030780_FinalPOE
{
    public partial class MenuWindow : Window
    {
        // Constructor
        public MenuWindow()
        {
            InitializeComponent();
        }

        // Navigate to Lecturer View
        private void OpenLecturerView(object sender, RoutedEventArgs e)
        {
            // Create an instance of MainWindow (Lecturer View) and show it
            MainWindow lecturerView = new MainWindow();
            lecturerView.Show();
        }

        // Navigate to Coordinator View
        private void OpenCoordinatorView(object sender, RoutedEventArgs e)
        {
            // Create an instance of CoordinatorView and show it
            CoordinatorView coordinatorView = new CoordinatorView();
            coordinatorView.Show();
        }

        // Navigate to HR View
        private void OpenHRView(object sender, RoutedEventArgs e)
        {
            // Create an instance of HRView and show it
            HRView hrView = new HRView();
            hrView.Show();
        }
    }
}
