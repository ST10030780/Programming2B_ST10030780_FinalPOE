using System.Linq;
using System.Windows;
using System.Collections.Generic; // For List

namespace Programming2B_ST10030780_FinalPOE
{
    public partial class HRView : Window
    {
        // Constructor
        public HRView()
        {
            InitializeComponent();
        }

        // Logic to generate claims report (simulated)
        private void GenerateClaimsReport_Click(object sender, RoutedEventArgs e)
        {
            // Example: Simulating the generation of a report for approved claims
            List<Claim> approvedClaims = GetApprovedClaims();  // Simulated data fetch

            // Example: Generating a simple report
            MessageBox.Show($"Report Generated. Total Approved Claims: {approvedClaims.Count}", "Report", MessageBoxButton.OK, MessageBoxImage.Information);

            // Further reporting logic can be added here (e.g., exporting to PDF, Excel, etc.)
        }

        // Simulated method to get approved claims (replace this with actual EF query)
        private List<Claim> GetApprovedClaims()
        {
            // Simulated approved claims data
            return new List<Claim>
            {
                new Claim { ClaimId = 1, Status = "Approved", Amount = 500 },
                new Claim { ClaimId = 2, Status = "Approved", Amount = 300 }
            };
        }

        // Logic for updating lecturer data (simulated)
        private void UpdateLecturerData_Click(object sender, RoutedEventArgs e)
        {
            // Simulate updating lecturer data in the database
            var lecturer = GetLecturerById(1); // Example for lecturer ID 1
            if (lecturer != null)
            {
                lecturer.Email = "newemail@example.com"; // Update the lecturer's email
                MessageBox.Show("Lecturer data updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Lecturer not found.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Simulated method to get lecturer by ID
        private Lecturer GetLecturerById(int lecturerId)
        {
            // Simulated lecturer data
            return new Lecturer { Id = 1, Name = "John Doe", Email = "johndoe@example.com" };
        }
    }

    // Simulated Claim class
    public class Claim
    {
        public int ClaimId { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
    }

    // Simulated Lecturer class
    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
