using ManageEmployeeVacation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageEmployeeVacation.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ManageEmployeeVacationContext context;

        public EmployeeRepository(ManageEmployeeVacationContext context)
        {
            this.context = context;
        }
        public Employee Add(Employee newEmployee)
        {
            context.Employee.Add(newEmployee);
            context.SaveChanges();
            return newEmployee;
        }

        public Employee Delete(int id)
        {
            Employee employee = context.Employee.Find(id);
            if (employee != null)
            {
                context.Employee.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return context.Employee;
        }

        public Employee GetEmployee(int id)
        {
            return context.Employee
                .First(c => c.ID == id);
        }

        public Employee Update(Employee updatedEmployee)
        {
            var employee = context.Employee.Attach(updatedEmployee);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return updatedEmployee;
        }
    }
}
