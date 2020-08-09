using System.ComponentModel.DataAnnotations;
namespace Nithin_Emp.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Please enter Id"), MaxLength(50)]
        public string Id { get; set; }
        [Required(ErrorMessage = "Please enter Name"), MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Address"), MaxLength(50)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter Gender"), MaxLength(10)]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter Company"), MaxLength(50)]
        public string Company { get; set; }
        [Required(ErrorMessage = "Please enter Designation"), MaxLength(50)]
        public string Designation { get; set; }
    }
}