using Day33_EmployeePayrollService;


namespace Day33_EmployeePayrollServiceTest
{
    [TestClass]
    public class EmployeeRepoTest
    {
        [TestMethod]
        public void updateSalaryTest()
        {
            EmployeeRepo employeeRepo = new();
            EmployeeModel model = new();
            int expected = 1;            
            int salary = employeeRepo.UpdateSalary();
            Assert.AreEqual(expected, salary);
        }
        [TestMethod]
        public void CountOfRowsTest()
        {
            EmployeeRepo employeeRepo = new();
            EmployeeModel model = new();
            int expected = 1;
            int count = employeeRepo.CountOfRows();
            Assert.AreEqual(expected, count);
        }
        [TestMethod]
        public void AverageOfSalaryTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeeModel employeeDetails = new EmployeeModel();
            int expected = 5000;
            int AverageSalary = employeeRepo.AverageOfSalary();
            Assert.AreEqual(expected, AverageSalary);
        }
        [TestMethod]
        public void SumOfSalaryTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeeModel employeeDetails = new EmployeeModel();
            int expected = 5000;
            int SumOfTheSalary = employeeRepo.SumOfSalary();
            Assert.AreEqual(expected, SumOfTheSalary);
        }
        [TestMethod]
        public void MinimumOfSalaryTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeeModel employeeDetails = new EmployeeModel();
            int expected = 5000;
            int minimum = employeeRepo.MinimumOfSalary();
            Assert.AreEqual(expected, minimum);
        }
        [TestMethod]
        public void MaximumOfSalaryTest()
        {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            EmployeeModel employeeDetails = new EmployeeModel();
            int expected = 3020000;
            int maximum = employeeRepo.MaximumOfSalary();
            Assert.AreEqual(expected, maximum);
        }

    }
}