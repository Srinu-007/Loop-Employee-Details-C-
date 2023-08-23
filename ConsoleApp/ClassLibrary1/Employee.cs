namespace ClassLibrary1
{
    public class Employee
    {
        public int EmpId { get; set; }

        public string EmployeeName { get; set; }

        public long SalaryPerHour { get; set; }

        public  int NoOfWorkingHours { get; set; }

        public  long NetSalary { get; set; }

        public static string Organisation;

        public const string TypeOfEmployee = "Contract Based";

        public readonly string DepartmentName;

        public Employee(string departmentName)
        {
            DepartmentName = "Finanace Department";
        }
    }

   
}