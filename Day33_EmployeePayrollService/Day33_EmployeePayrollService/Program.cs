// See https://aka.ms/new-console-template for more information
using Day33_EmployeePayrollService;
Console.WriteLine("Welcome to EmployeePayroll");
EmployeeRepo repo = new EmployeeRepo();
EmployeeModel model = new EmployeeModel();
Console.WriteLine("Choose the option :\n1.Add Employeee\n2.View Employee\n3.Update salary\n4.Get Employee Details from a DateRange\n5.Aggregate Operations");
int option = Convert.ToInt16(Console.ReadLine());
switch (option)
{
    case 1:
        model.EmpName = "Pramod";
        model.Gender = "Male";
        model.BasicPay = "22000";
        model.PhoneNumber = "9876564325";
        model.Address = "Rourkela";
        model.Deduction = "2000";
        model.TaxablePay = "1000";
        model.IncomeTax = "1000";
        model.NetPay = "500";
        model.Department = "Banker";
        repo.AddEmployee(model);
        break;
    case 2:
        repo.ViewEmployee();
        break;
    case 3:
        repo.updateSalary();
        int salary = repo.updateSalary();
        Console.WriteLine(salary);
        break;
    case 4:
        repo.ViewEmployee_with_Netpay();
        break;
    case 5:
        int count = repo.CountOfRows();
        Console.WriteLine("Count of Records :" + count);
        int AverageSalary = repo.AverageOfSalary();
        Console.WriteLine("Average salary is :" + AverageSalary);
        int SumOfTheSalary = repo.SumOfSalary();
        Console.WriteLine("Sum of salaries is :" + SumOfTheSalary);
        int minimum = repo.MinimumOfSalary();
        Console.WriteLine("Minimum of salaries is :" + minimum);
        int maximum = repo.MaximumOfSalary();
        Console.WriteLine("Maximum of salaries is :" + maximum);
        break;
    default:
        Console.WriteLine("Please choose the correct option");
        break;
}



