using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageEmployeeVacation.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public int VactationCasualBalance { get; set; }
        public int VactationCasualUsed { get; set; }
        public int VactationScheduleBalance { get; set; }
        public int VactationScheduleUsed { get; set; }
    }
}
