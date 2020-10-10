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
    public class DeleteModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;
        public DeleteModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        [BindProperty]
        public Employee Employee { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = employeeRepository.GetEmployee(id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            

            employeeRepository.Delete(id);

            return RedirectToPage("./Index");
        }
    }
}
