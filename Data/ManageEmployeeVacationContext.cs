using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManageEmployeeVacation.Models;

namespace ManageEmployeeVacation.Data
{
    public class ManageEmployeeVacationContext : DbContext
    {
        public ManageEmployeeVacationContext (DbContextOptions<ManageEmployeeVacationContext> options)
            : base(options)
        {
        }

        public DbSet<ManageEmployeeVacation.Models.Employee> Employee { get; set; }
    }
}
