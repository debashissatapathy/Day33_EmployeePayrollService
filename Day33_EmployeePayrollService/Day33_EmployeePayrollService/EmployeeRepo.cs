using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33_EmployeePayrollService
{
    public class EmployeeRepo
    {
        public static string connectionString = @"Data Source = DESKTOP-195K6F7; Initial Catalog = PayrollService; Integrated Security = True; TrustServerCertificate=True;";
        SqlConnection connection = new SqlConnection(connectionString);
        EmployeeModel model = new EmployeeModel();
        public void ViewEmployee()
        {
            try
            {
                EmployeeModel model = new EmployeeModel();
                using (this.connection)
                {

                    //string Query = @"SELECT EmpId, EmpName, Gender, BasicPay, PhoneNumber, Address, 
                    //             Deduction, TaxablePay,Incometax, NetPay, Department from employee_payroll;";
                    SqlCommand cmd = new SqlCommand("Sp_employee_payroll_ViewRecord", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    this.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            model.EmpId = reader.GetInt32(0);
                            model.EmpName = reader.GetString(1);
                            model.Gender = reader.GetString(2);
                            model.BasicPay = reader.GetString(3);
                            model.PhoneNumber = reader.GetString(4);
                            model.Address = reader.GetString(5);
                            model.Deduction = reader.GetString(6);
                            model.TaxablePay = reader.GetString(7);
                            model.IncomeTax = reader.GetString(8);
                            model.NetPay = reader.GetInt32(9);
                            model.Department = reader.GetString(10);

                            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}", model.EmpId, model.EmpName, model.Gender, model.BasicPay,
                                                model.PhoneNumber, model.Address, model.Deduction, model.TaxablePay, model.IncomeTax, model.NetPay,
                                                model.Department);
                            Console.WriteLine("\n");

                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found");
                    }
                    reader.Close();
                    this.connection.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
        public bool AddEmployee(EmployeeModel model)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand cmd = new SqlCommand("Sp_employee_payroll_Insert", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpName", model.EmpName);
                    cmd.Parameters.AddWithValue("@Gender", model.Gender);
                    cmd.Parameters.AddWithValue("@BasicPay", model.BasicPay);
                    cmd.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", model.Address);
                    cmd.Parameters.AddWithValue("@Deduction", model.Deduction);
                    cmd.Parameters.AddWithValue("@TaxablePay", model.TaxablePay);
                    cmd.Parameters.AddWithValue("@IncomeTax", model.IncomeTax);
                    cmd.Parameters.AddWithValue("@NetPay", model.NetPay);
                    cmd.Parameters.AddWithValue("@Department", model.Department);
                    connection.Open();
                    var result = cmd.ExecuteNonQuery();
                    connection.Close();
                    if (result != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Record inserted Successfully");
                        Console.ResetColor();
                        return true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error");
                        Console.ResetColor();
                        return false;
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public int UpdateSalary()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("update employee_payroll set BasicPay=250000 where EmpName='Debashis'", connection);
            //SqlCommand command2 = new SqlCommand("update employee_payroll set NetPay=3020000 where EmpName='Pramod'", connection);


            int effectedRow = command.ExecuteNonQuery();
            //int effectedRow1 = command2.ExecuteNonQuery();

            if (effectedRow == 1)
            {
                string query = @"Select BasicPay from employee_payroll where EmpName='Debashis';";
                SqlCommand cmd = new(query, connection);
                object res = cmd.ExecuteScalar();
                connection.Close();
                model.BasicPay= (String)res;      
                               
            }
            connection.Close();
            return effectedRow;

        }
        public int CountOfRows()
        {
            connection.Open();
            string query = @"Select count(*) from employee_payroll where Gender='FeMale';";
            SqlCommand cmd = new(query, connection);
            object res = cmd.ExecuteScalar();
            connection.Close();
            int Count = (int)res;
            return Count;
        }
        public int AverageOfSalary()
        {

            connection.Open();
            string query = @"Select Avg(NetPay) from employee_payroll where Gender='FeMale';";
            SqlCommand cmd = new SqlCommand(query, connection);
            object res = cmd.ExecuteScalar();
            connection.Close();
            int NetPay = (int)res;
            return NetPay;
        }
        public int SumOfSalary()
        {
           
            connection.Open();
            string query = @"Select Sum(NetPay) from employee_payroll where Gender='FeMale';";
            SqlCommand cmd = new SqlCommand(query, connection);
            object res = cmd.ExecuteScalar();
            connection.Close();
            int Sum = (int)res;
            return Sum;
        }
        public int MinimumOfSalary()
        {
            
            connection.Open();
            string query = @"Select Min(NetPay) from employee_payroll where Gender='FeMale';";
            SqlCommand cmd = new SqlCommand(query, connection);
            object res = cmd.ExecuteScalar();
            connection.Close();
            int min = (int)res;
            return min;
        }
        public int MaximumOfSalary()
        {
            connection.Open();
            string Query = @"Select Max(NetPay) from employee_payroll where Gender = 'Male';";
            SqlCommand cmd = new SqlCommand(Query, connection);
            object res = cmd.ExecuteScalar();
            int max = (int)res;
            return max;
        }
        public void ViewEmployee_with_Netpay()
        {
            try
            {
                using (this.connection)
                {
                    string query = @"select * from employee_payroll where NetPay between 1000 and 2000 ;";
                    SqlCommand cmd = new SqlCommand(query, this.connection);

                    this.connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        model.EmpId = reader.GetInt32(0);
                        model.EmpName = reader.GetString(1);
                        model.Gender = reader.GetString(2);
                        model.BasicPay = reader.GetString(3);
                        model.PhoneNumber = reader.GetString(4);
                        model.Address = reader.GetString(5);
                        model.Deduction = reader.GetString(6);
                        model.TaxablePay = reader.GetString(7);
                        model.IncomeTax = reader.GetString(8);
                        model.NetPay = reader.GetInt32(9);
                        model.Department = reader.GetString(10);


                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                        model.EmpId,
                        model.EmpName,
                        model.Gender,
                        model.BasicPay,
                        model.PhoneNumber,
                        model.Address,
                        model.Deduction,
                        model.TaxablePay,                        
                        model.IncomeTax,
                        model.NetPay,
                        model.Department);                      
                    }
                    reader.Close();
                    this.connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}                                                                                                          
                                                                                                                
                                                                                                                
                                                                                                               