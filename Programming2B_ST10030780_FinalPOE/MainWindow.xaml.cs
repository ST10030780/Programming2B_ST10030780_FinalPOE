using Microsoft.Win32; // For file dialog
using System.Windows;

namespace Programming2B_ST10030780_FinalPOE
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Submit Claim logic
        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            // Input Validation
            if (string.IsNullOrEmpty(txtHoursWorked.Text) || string.IsNullOrEmpty(txtHourlyRate.Text))
            {
                MessageBox.Show("Please enter both hours worked and hourly rate.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!decimal.TryParse(txtHoursWorked.Text, out decimal hoursWorked) || !decimal.TryParse(txtHourlyRate.Text, out decimal hourlyRate))
            {
                MessageBox.Show("Please enter valid numerical values for hours worked and hourly rate.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Auto-calculation of total payment
            decimal totalPayment = hoursWorked * hourlyRate;
            lblTotalPayment.Text = $"Total Payment: {totalPayment:C}";  // Display the total payment

            // Add claim to claim status list (basic simulation)
            string claimSummary = $"Claim Submitted - Hours: {txtHoursWorked.Text}, Rate: {txtHourlyRate.Text}, Total: {totalPayment:C}";
            lstClaimStatus.Items.Add(claimSummary);

            // Clear fields
            txtHoursWorked.Clear();
            txtHourlyRate.Clear();
            txtNotes.Clear();
        }

        // Upload Document logic
        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            // Open File Dialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Document Files|*.pdf;*.docx;*.xlsx",
                Title = "Select a Supporting Document"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                lblFileName.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
                MessageBox.Show("File uploaded successfully!", "Upload", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
