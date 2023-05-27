using System.ComponentModel.DataAnnotations;
namespace AspDotNetAssignments.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50)]
        [MinLength(2)]
        [DataType(DataType.Text)]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Department name is required")]
        public string? Department { get; set; }

        [Required(ErrorMessage = "Salary is require")]
        public double Salary { get; set; }
    }
}
