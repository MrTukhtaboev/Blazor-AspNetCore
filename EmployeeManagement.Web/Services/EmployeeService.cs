using EmployeeManagement.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var httpMessage = await _httpClient.GetAsync("api/employee");
            var result = await httpMessage.Content.ReadAsStringAsync();
            var employees = JsonConvert.DeserializeObject<Employee[]>(result);
            return employees;
        }
    }
}
