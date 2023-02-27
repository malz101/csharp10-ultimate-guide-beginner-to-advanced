//Create up to 10 objects of Employee class in the console application. Read each
//employee details (EmpID, EmpName, SalaryPerHour, NoOfWorkingHours) from the user (from
//the keyboard) using loop.
// Calculate net salary (SalaryPerHour * NoOfWorkingHours).
// And display the all details of the same object (including EmpID, EmpName,
//SalaryPerHour, NoOfWorkingHours, NetSalary, OrganizationName, TypeOfEmployee,
//DepartmentName) and then ask the user 'Do you want to continue to next employee'.
// If the user choose 'Yes', proceed to the next employee; otherwise stop the loop.

using System;
using ClassLibrary;

namespace WorkingWithMutipleObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string programName = "**Working With Mutiple Objects**";
            const int maxNoOfEmployee = 10;
            Employee employee;

            //initialize company name as "Harsha Inc."
            Employee.OrganizationName = "Harsha Inc.";

            Console.WriteLine(programName+"\n\n");

            for(int count=1; count<= maxNoOfEmployee; count++) {
                //create employee object
                employee = new Employee();

                Console.WriteLine($"Entering details for employee {count}...");
                
                //get details for employee
                Console.Write("Enter employee ID: ");
                employee.EmpID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter employee's name: ");
                employee.EmpName = Console.ReadLine();

                Console.Write("Enter employee's salary per hour: $");
                employee.SalaryPerHour = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter employee's no. of working hours: ");
                employee.NoOfWorkingHours = Convert.ToSingle(Console.ReadLine());

                //calculate salary
                employee.NetSalary = employee.SalaryPerHour * employee.NoOfWorkingHours;

                Console.WriteLine("\nEmployee successfully created! See details below:");
                Console.WriteLine($"Employee ID: {employee.EmpID}");
                Console.WriteLine($"Name: {employee.EmpName}");
                Console.WriteLine($"Organization name: {Employee.OrganizationName}");
                Console.WriteLine($"Department name: {employee.DepartmentName}");
                Console.WriteLine($"Employee type: {Employee.TypeOfEmployee}");
                Console.WriteLine($"Salary per hour: ${employee.SalaryPerHour}");
                Console.WriteLine($"No. of working hours: {employee.NoOfWorkingHours}");
                Console.WriteLine($"Net salary: ${employee.NetSalary}");

                if (count < maxNoOfEmployee)
                {
                    Console.Write("\nDo you want to continue to next employee (Yes/No)? ");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        Console.Write("\n\n");
                        continue;
                    }
                    else
                        break;
                }

            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
