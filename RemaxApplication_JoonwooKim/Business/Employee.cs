using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemaxApplication_JoonwooKim.Business
{
    public class Employee:Person
    {
        public int RefEmp { get; set; }
        public string EmpID { get; set; }
        public string EmpPW { get; set; }
        public string Phone { get; set; }
        public string Post { get; set; }
    }
}
