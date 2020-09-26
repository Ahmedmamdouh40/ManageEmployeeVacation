using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManageEmployeeVacation.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required]
        public string Gender { get; set; }
        public int VactationCasualBalance { get; set; }
        public int VactationCasualUsed { get; set; }
        public int VactationScheduleBalance { get; set; }
        public int VactationScheduleUsed { get; set; }
    }
}
