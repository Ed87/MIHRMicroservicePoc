using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesAPIService.Domain
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public DateTime JoiningDate { get; set; }
        [Required]
        public string EmployeeNumber { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        public int RecruitmentRequisitionID { get; set; }
        public RecruitmentRequisition RecruitmentRequisition { get; set; }

    }
}
