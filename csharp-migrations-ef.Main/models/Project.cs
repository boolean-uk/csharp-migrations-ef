namespace csharp_migrations_ef.Main.models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<EmployeesInProject> Employees { get; set; }
    }
}