using System.ComponentModel.DataAnnotations;

namespace ContractClaimSystem.Models
{
    public class Lecturer
    {
        public int LecturerID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public double HourlyRate { get; set; }
    }

    public class Module
    {
        public string ModuleName { get; set; }
        public string Programme { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
    }

    public class Claim
    {
        public int Id { get; set; }
        public string LecturerName { get; set; }
        public string LecturerSurname { get; set; }
        public string EmployeeNo { get; set; }
        public string ContactDetails { get; set; }
        public List<Module> Modules { get; set; } = new List<Module>(); // Initialize to avoid null reference

        // This stores the total amount of the claim(Hours* Hourly Rate)
    public decimal TotalAmount { get; set; }

        // This will store the total hours worked across all modules
        public decimal TotalHours
        {
            get
            {
                // Assuming total hours is calculated from all modules
                return Modules.Sum(m => m.HoursWorked);
            }
        }

        // Lecturer property (assuming Lecturer has an HourlyRate)
        public Lecturer Lecturer { get; set; }
        public bool? IsApproved { get; set; } // Null means pending, true for approved, false for rejected
    }

}
