using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace csharp_migrations_ef.Main.models
{
    public class EmployeeAdress
    {
        [Key, ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public string Address { get; set; }
        public virtual Employee Employee { get; set; }
    }
}