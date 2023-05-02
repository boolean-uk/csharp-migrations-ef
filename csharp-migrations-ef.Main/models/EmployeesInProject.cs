using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_migrations_ef.Main.models
{
    public class EmployeesInProject
    {
        public int EmployeeID { get; set; }
        public int ProjectID { get; set; }

        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        [ForeignKey("ProjectID")]
        public Project Project { get; set; }
    }
}