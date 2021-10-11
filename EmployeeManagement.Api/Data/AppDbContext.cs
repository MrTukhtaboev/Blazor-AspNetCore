using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed for department
            modelBuilder.Entity<Department>().HasData(
                new Department 
                { 
                    DepartmentId = 1, 
                    DepartmentName = "Moliya Vazirligi" 
                },
                new Department 
                { 
                    DepartmentId = 2, 
                    DepartmentName = "Davlat Soliq Qo'mitasi" 
                },
                new Department 
                { 
                    DepartmentId = 3, 
                    DepartmentName = "ICT o'quv markazi" }
                );

            // seed for employee
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Janob",
                    LastName = "Panda",
                    Email = "toxtaboyev.m@iCloud.com",
                    DateOfBirth = new DateTime(1999, 5, 3),
                    Gender = Gender.Male,
                    DepartmentId = 1,
                    PhotoPath = "images/muhammadkarim.jpg"
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Abduvohid",
                    LastName = "Ergashev",
                    Email = "abduvohid_eam@gmail.com",
                    DateOfBirth = new DateTime(2000, 7, 1),
                    Gender = Gender.Male,
                    DepartmentId = 2,
                    PhotoPath = "images/abduvohid.jpg"
                },
                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Ixtiyor",
                    LastName = "Baxodirov",
                    Email = "ixtiyor1977@gmail.com",
                    DateOfBirth = new DateTime(1999, 10, 2),
                    Gender = Gender.Male,
                    DepartmentId = 3,
                    PhotoPath = "images/ixtiyor.jpg"
                });
        }
    }
}
