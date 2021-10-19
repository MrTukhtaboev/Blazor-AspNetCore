using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient _httpClient;
        public DepartmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Department> GetDepartment(int Id)
        {
            return await _httpClient.GetFromJsonAsync<Department>($"/api/department/{Id}");
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _httpClient.GetFromJsonAsync<Department[]>($"/api/department");
        }
    }
}
