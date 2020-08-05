using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesAPIService.Domain
{
    public class RecruitmentRequisition
    {
        public int RecruitmentRequisitionID { get; set; }
        public int DepartmentID { get; set; }
        public int JobTitleID { get; set; }
        public int JobGradeID { get; set; }
        public int Quantity { get; set; }
        public Department Department { get; set; }
        public JobGrade JobGrade { get; set; }
        public JobTitle JobTitle { get; set; }
    }
}
