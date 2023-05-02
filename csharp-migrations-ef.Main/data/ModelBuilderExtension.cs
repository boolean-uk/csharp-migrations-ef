using csharp_migrations_ef.Main.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_migrations_ef.Main.data
{
    public static class ModelBuilderExtensionMethod
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeesInProject>()
              .HasKey(e => new { e.EmployeeID, e.ProjectID });

            modelBuilder.Entity<Department>()
                   .HasData(
                     new Department { DepartmentID = 1, Name = "C#/React Developer" },
                     new Department { DepartmentID = 2, Name = "C#/Angular Developer" },
                     new Department { DepartmentID = 3, Name = "C#/Vue Developer" },
                     new Department { DepartmentID = 4, Name = "Java Developer" }
                   );

            modelBuilder.Entity<Project>()
                   .HasData(
                     new Project { ProjectID = 1, Name = "Company Website" },
                     new Project { ProjectID = 2, Name = "Banking Application" },
                     new Project { ProjectID = 3, Name = "Restaurant Booking System" },
                     new Project { ProjectID = 4, Name = "City Bike Rental Application" },
                     new Project { ProjectID = 5, Name = "Parking Meter Application" },
                     new Project { ProjectID = 6, Name = "Criminal Tracking System" }
                   );

            modelBuilder.Entity<Employee>()
                   .HasData(
                      new Employee { EmployeeID = 1, Name = "Stavros S", DepartmentID = 1 },
                      new Employee { EmployeeID = 2, Name = "Thanasis A", DepartmentID = 1 },
                      new Employee { EmployeeID = 3, Name = "Iasonas K", DepartmentID = 2 },
                      new Employee { EmployeeID = 4, Name = "Valentina G", DepartmentID = 2 },
                      new Employee { EmployeeID = 5, Name = "Nikita P", DepartmentID = 3 },
                      new Employee { EmployeeID = 6, Name = "Joeri L", DepartmentID = 3 },
                      new Employee { EmployeeID = 7, Name = "Max de R", DepartmentID = 3 },
                      new Employee { EmployeeID = 8, Name = "Nigel S", DepartmentID = 4 }
                   );

            modelBuilder.Entity<EmployeeAdress>()
                   .HasData(
                     new EmployeeAdress { EmployeeID = 1, Address = "Bangalore, India" },
                     new EmployeeAdress { EmployeeID = 2, Address = "Newyork, USA" },
                     new EmployeeAdress { EmployeeID = 3, Address = "California, USA" },
                     new EmployeeAdress { EmployeeID = 4, Address = "NewDelhi, India" },
                     new EmployeeAdress { EmployeeID = 5, Address = "Kentuki, USA" },
                     new EmployeeAdress { EmployeeID = 6, Address = "Hurth, Germany" },
                     new EmployeeAdress { EmployeeID = 7, Address = "Rosario, Argentina" },
                     new EmployeeAdress { EmployeeID = 8, Address = "Manacor, Spain" }
                   );

            modelBuilder.Entity<EmployeesInProject>()
                   .HasData(
                      new EmployeesInProject { EmployeeID = 1, ProjectID = 1 },
                      new EmployeesInProject { EmployeeID = 1, ProjectID = 4 },
                      new EmployeesInProject { EmployeeID = 2, ProjectID = 2 },
                      new EmployeesInProject { EmployeeID = 2, ProjectID = 3 },
                      new EmployeesInProject { EmployeeID = 3, ProjectID = 2 },
                      new EmployeesInProject { EmployeeID = 3, ProjectID = 5 },
                      new EmployeesInProject { EmployeeID = 4, ProjectID = 1 },
                      new EmployeesInProject { EmployeeID = 4, ProjectID = 3 },
                      new EmployeesInProject { EmployeeID = 5, ProjectID = 3 },
                      new EmployeesInProject { EmployeeID = 5, ProjectID = 2 },
                      new EmployeesInProject { EmployeeID = 6, ProjectID = 4 },
                      new EmployeesInProject { EmployeeID = 6, ProjectID = 2 },
                      new EmployeesInProject { EmployeeID = 7, ProjectID = 5 },
                      new EmployeesInProject { EmployeeID = 7, ProjectID = 1 },
                      new EmployeesInProject { EmployeeID = 8, ProjectID = 6 },
                      new EmployeesInProject { EmployeeID = 8, ProjectID = 5 }
                   );


        }

    }
}
