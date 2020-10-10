using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ManageEmployeeVacation.Data;
using ManageEmployeeVacation.Models;

namespace ManageEmployeeVacation.Pages.Employees
{
    public class CreateModel : PageModel
    {
        // private readonly ManageEmployeeVacation.Data.ManageEmployeeVacationContext _context;
        private readonly IEmployeeRepository employeeRepository;
        public CreateModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            employeeRepository.Add(Employee);

            return RedirectToPage("./Index");
        }

    }
}
