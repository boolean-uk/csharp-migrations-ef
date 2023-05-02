using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace csharp_migrations_ef.Main.models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        [ForeignKey("Department")]
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        public virtual EmployeeAdress EmployeeAddress { get; set; }
        public virtual ICollection<EmployeesInProject> Projects { get; set; }
    }
}