using ManageEmployeeVacation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageEmployeeVacation.Data
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee Add(Employee newEmployee);
        Employee Update(Employee updatedEmployee);
        Employee Delete(int id);
        
    }
}
