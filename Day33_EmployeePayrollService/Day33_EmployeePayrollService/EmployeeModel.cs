using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33_EmployeePayrollService
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Gender { get; set; }
        public string BasicPay { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Deduction { get; set; }
        public string TaxablePay { get; set; }
        public string IncomeTax { get; set; }
        public string NetPay { get; set; }
        public string Department { get; set; }

       
    }
}
