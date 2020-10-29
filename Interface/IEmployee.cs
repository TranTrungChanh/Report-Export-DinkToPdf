using Reporting.Models;
using System.Collections.Generic;

namespace Reporting.Interface
{
    public interface IEmployee
    {
        IList<Employee> GetEmployees();

        Employee GetEployeeById(int employeeId);
    }
}
