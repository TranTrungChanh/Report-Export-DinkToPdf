using Reporting.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reporting.Interface
{
    public class EmployeeAppService : IEmployee
    {
        public EmployeeAppService() { }

        public IList<Employee> GetEmployees()
        {
            var model = GetEmployeeList();

            return model;
        }

        public Employee GetEployeeById(int employeeId)
        {
            var data = GetEmployeeList().FirstOrDefault(a => a.Id == employeeId);

            return data;
        }

        private static List<Employee> GetEmployeeList()
        {
            var model = new List<Employee>()
            {
                new Employee() { Id = 1, Code = "NV-00001", FirstName = "Trần", LastName = "Trung Chánh", Address = "Mỹ Thạnh", Age = 24, Gender = true },
                new Employee() { Id = 2, Code = "NV-00002", FirstName = "Đặng", LastName = "Thành Phát", Address = "Bình Khánh", Age = 25, Gender = true },
                new Employee() { Id = 3, Code = "NV-00003", FirstName = "Phan Huỳnh", LastName = "Hải Triều", Address = "Thới Thuận", Age = 23, Gender = true },
                new Employee() { Id = 4, Code = "NV-00004", FirstName = "Huỳnh Thị", LastName = "Thúy Vi", Address = "Hồng Ngự", Age = 29, Gender = false },
                new Employee() { Id = 5, Code = "NV-00005", FirstName = "Nguyễn", LastName = "Thành Tài", Address = "Mỹ Phước", Age = 25, Gender = true },
                new Employee() { Id = 6, Code = "NV-00006", FirstName = "Phạm", LastName = "Mạnh Cường", Address = "Hồ Chí Minh", Age = 35, Gender = true },
                new Employee() { Id = 7, Code = "NV-00007", FirstName = "Trần", LastName = "Tấn Lợi", Address = "Thới Thuận", Age = 25, Gender = true },
                new Employee() { Id = 8, Code = "NV-00008", FirstName = "Nguyễn", LastName = "Thị Hồng", Address = "Mỹ Bình", Age = 28, Gender = false }
            };

            return model;
        }
    }
}
