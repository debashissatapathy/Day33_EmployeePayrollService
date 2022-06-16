// See https://aka.ms/new-console-template for more information
using Day33_EmployeePayrollService;
Console.WriteLine("Welcome to EmployeePayroll");
EmployeeRepo repo = new EmployeeRepo();
EmployeeModel model = new EmployeeModel();
Console.WriteLine("Choose the option :\n1.Add Employeee\n2.View Employee\n3.Update salary\n4.Get Employee Details from a DateRange\n5.Aggregate Operations\n6.Operation with thread");
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
        model.NetPay = 500;
        model.Department = "Banker";
        repo.AddEmployee(model);
        break;
    case 2:
        repo.ViewEmployee();
        break;
    case 3:
        repo.UpdateSalary();
        int salary = repo.UpdateSalary();
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
    case 6:

        List<Employee_details2> employeeDetails2 = new List<Employee_details2>();
        employeeDetails2.Add(new Employee_details2(EmployeeID: 1, FirstName: "Vishnu", LastName: "vardhan", Gender: "Male", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "vijayawada", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
        employeeDetails2.Add(new Employee_details2(EmployeeID: 2, FirstName: "Debashis", LastName: "Satapathy", Gender: "Male", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Bhadrak", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
        employeeDetails2.Add(new Employee_details2(EmployeeID: 3, FirstName: "Roshni", LastName: "AdatRao", Gender: "FeMale", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Pune", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
        employeeDetails2.Add(new Employee_details2(EmployeeID: 4, FirstName: "Viraj", LastName: "Jadhav", Gender: "Male", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Pune", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));
        employeeDetails2.Add(new Employee_details2(EmployeeID: 5, FirstName: "Puja", LastName: "Rana", Gender: "FeMale", StartDate: DateTime.Now, Company: "bridge Labs", Departent: "Development", Address: "Delhi", BasicPay: 20000, Deductions: 1000, TaxablePay: 200, IncomeTax: 180, NetPay: 25000));

        OperationWithThread operation = new OperationWithThread();
        DateTime StartdateTime = DateTime.Now;
        operation.addEmployeeToPayRoll(employeeDetails2);
        DateTime StopDataTime = DateTime.Now;
        Console.WriteLine("Duration without Thread: " + (StopDataTime - StartdateTime));

        break;
    default:
        Console.WriteLine("Please choose the correct option");
        break;
}



