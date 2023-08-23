using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Employee
    {
        public int EmpId;

        public string EmployeeName;

        public long SalaryPerHour;

        public int NoOfWorkingHours;

        public int NetSalary;

        public static string Organisation;

        public const string TypeOfEmployee = "Contract Based";

        public readonly string DepartmentName;
        public Employee()
        {
            DepartmentName =  "Finance Department";
        }   
        
    }
}
