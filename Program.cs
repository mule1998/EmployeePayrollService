using System;

namespace EmpolyeePayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Payroll Service");
            EmployeeRepository repository = new EmployeeRepository();
            Console.WriteLine("Id Name BasicPay Startdate Gender Department PhoneNumber Address Deduction Tax IncomeTax NetPay \n");
            repository.GetAllEmployee();
            Console.ReadLine();
        }
    }
}