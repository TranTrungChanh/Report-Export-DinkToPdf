using Reporting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reporting.Interface
{
    public interface IEmployee
    {
        IList<Employee> GetEmployees();

        Employee GetEployeeById(int employeeId);
    }
}
