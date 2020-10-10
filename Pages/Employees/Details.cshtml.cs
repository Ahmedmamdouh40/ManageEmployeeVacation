using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ManageEmployeeVacation.Data;
using ManageEmployeeVacation.Models;

namespace ManageEmployeeVacation.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        // private readonly ManageEmployeeVacation.Data.ManageEmployeeVacationContext _context;
        private readonly IEmployeeRepository employeeRepository;
        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public Employee Employee { get; set; }

        public void OnGet(int id)
        {

            Employee = employeeRepository.GetEmployee(id);

        }

    }
}
