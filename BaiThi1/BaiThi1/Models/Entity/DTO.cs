using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi1.Models.Entity
{
    class DTO
    {
        public class EmployeeList
        {
            public string name { get; set; }
            public string role { get; set; }
            public int birthyear { get; set; }
        }

        public class Employees
        {
            public List<EmployeeList> employee_list { get; set; }
        }


    }
}
