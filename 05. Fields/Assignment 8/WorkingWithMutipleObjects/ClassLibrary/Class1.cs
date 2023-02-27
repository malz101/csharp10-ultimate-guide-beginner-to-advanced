//Create a class called Employee in the class library with fields EmpID, EmpName,
//SalaryPerHour, NoOfWorkingHours and NetSalary. Additionally, add the following fields:
// A static field called OrganizationName. It should be initialized as "Harsha Inc." in Main
//method.
// A constant field called TypeOfEmployee and initialize it as "Contract Based" along with
//declaration.
// A readonly field called DepartmentName and initialize it as "Finance Department" in
//constructor.


namespace ClassLibrary
{
    public class Employee
    {
        //fields
        public int EmpID;
        public string EmpName;
        public double SalaryPerHour;
        public float NoOfWorkingHours;
        public double NetSalary;
        public static string OrganizationName;
        public const string TypeOfEmployee = "Contract Based";
        public readonly string DepartmentName;

        //constructor
        public Employee()
        {
            DepartmentName = "Finance Department";
        }

    }
}
