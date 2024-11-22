using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Programming2B_ST10030780_FinalPOE
{
    public partial class CoordinatorView : Window
    {
        public CoordinatorView()
        {
            InitializeComponent();

            // Simulate loading pending claims
            lstPendingClaims.Items.Add("Claim #1 - Hours: 10, Rate: 100, Notes: Overtime work");
            lstPendingClaims.Items.Add("Claim #2 - Hours: 8, Rate: 90, Notes: Regular hours");
        }

        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            if (lstPendingClaims.SelectedItem == null)
            {
                MessageBox.Show("Please select a claim to approve.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Simulate automated verification (this can be expanded with actual policies)
            string claim = lstPendingClaims.SelectedItem.ToString();
            if (claim.Contains("Rate: 100")) // Example of a simple policy check
            {
                MessageBox.Show($"Approved: {claim}", "Approval", MessageBoxButton.OK, MessageBoxImage.Information);
                lstPendingClaims.Items.Remove(lstPendingClaims.SelectedItem);
            }
            else
            {
                MessageBox.Show("Claim does not meet approval criteria.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RejectClaim_Click(object sender, RoutedEventArgs e)
        {
            if (lstPendingClaims.SelectedItem == null)
            {
                MessageBox.Show("Please select a claim to reject.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBox.Show($"Rejected: {lstPendingClaims.SelectedItem}", "Rejection", MessageBoxButton.OK, MessageBoxImage.Warning);
            lstPendingClaims.Items.Remove(lstPendingClaims.SelectedItem);
        }
    }
}