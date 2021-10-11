using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Data
{
    public interface IDepartmentRepository
    {
        Task<Department> GetDepartment(int departmentId);
        Task<IEnumerable<Department>> GetDepartments();
    }
}
