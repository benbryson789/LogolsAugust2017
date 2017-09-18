using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Training11.Models
{
    public class EmployeeViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Hired?")]
        public bool WasHired { get; set; }
    }
}