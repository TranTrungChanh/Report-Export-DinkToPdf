using Reporting.Models;
using System.Collections.Generic;

namespace Reporting.Data
{
    public class EmployeeData
    {
        public EmployeeData() { }

        public static List<Employee> GetEmployeeList()
        {
            var model = new List<Employee>() 
            {
                new Employee() { Id = 1, FirstName = "Trần", LastName = "Trung Chánh", Address = "Mỹ Thạnh", Age = 24, Gender = true },
                new Employee() { Id = 2, FirstName = "Đặng", LastName = "Thành Phát", Address = "Bình Khánh", Age = 25, Gender = true },
                new Employee() { Id = 3, FirstName = "Phan Huỳnh", LastName = "Hải Triều", Address = "Thới Thuận", Age = 23, Gender = true },
                new Employee() { Id = 4, FirstName = "Huỳnh Thị", LastName = "Thúy Vi", Address = "Hồng Ngự", Age = 29, Gender = false },
                new Employee() { Id = 5, FirstName = "Nguyễn", LastName = "Thành Tài", Address = "Mỹ Phước", Age = 25, Gender = true },
                new Employee() { Id = 6, FirstName = "Phạm", LastName = "Mạnh Cường", Address = "Hồ Chí Minh", Age = 35, Gender = true },
                new Employee() { Id = 7, FirstName = "Trần", LastName = "Tấn Lợi", Address = "Thới Thuận", Age = 25, Gender = true },
                new Employee() { Id = 8, FirstName = "Nguyễn", LastName = "Thị Hồng", Address = "Mỹ Bình", Age = 28, Gender = false }
            };

            return model;
        }
    }
}
