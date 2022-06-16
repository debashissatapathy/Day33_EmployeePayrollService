using Day33_EmployeePayrollService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33_EmployeePayrollServiceTest
{
    [TestClass]
    public class OperationWithThreadTest
    {
        [TestMethod]
        public void addEmployeeToPayRollTest()
        {
            List<Employee_details2> employeeDetails = new List<Employee_details2>();
            employeeDetails.Add(new Employee_details2(EmployeeID: 1, FirstName: "Vishnu", LastName: "vardhan", Gender: "Male", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "vijayawada", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails.Add(new Employee_details2(EmployeeID: 2, FirstName: "Debashis", LastName: "Satapathy", Gender: "Male", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Bhadrak", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails.Add(new Employee_details2(EmployeeID: 3, FirstName: "Roshni", LastName: "AdatRao", Gender: "FeMale", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Pune", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails.Add(new Employee_details2(EmployeeID: 4, FirstName: "Viraj", LastName: "Jadhav", Gender: "Male", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Pune", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
            employeeDetails.Add(new Employee_details2(EmployeeID: 5, FirstName: "Puja", LastName: "Rana", Gender: "FeMale", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Delhi", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));

            OperationWithThread operation = new  OperationWithThread();
            DateTime StartdateTime = DateTime.Now;
            operation.addEmployeeToPayRoll(employeeDetails);
            DateTime StopDataTime = DateTime.Now;
            Console.WriteLine("Duration without Thread: " + (StopDataTime - StartdateTime));

            DateTime StartdateTimeThread = DateTime.Now;
            operation.addEmployeeToPayRollWithThread(employeeDetails);
            DateTime StopDataTimeThread = DateTime.Now;
            Console.WriteLine("Duration with Thread: " + (StopDataTimeThread - StartdateTimeThread));


        }


    }
}
