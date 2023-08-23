using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main()
        {
            Employee.Organisation = "Harsha Inc..";

            Console.WriteLine("*****************" + Employee.Organisation + "****************");

            for (int i = 0; i < 10; i++)
            {
                string employeenum;
                switch (i)
                {
                    case 0: employeenum = "FirstEmployee: "; break;
                    case 1: employeenum = "SecondEmployee: "; break;
                    case 2: employeenum = "ThirdEmployee: "; break;
                    case 3: employeenum = "FouthEmployee: "; break;
                    case 4: employeenum = "FifthEmployee: "; break;
                    case 5: employeenum = "SixthEmployee: "; break;
                    case 6: employeenum = "SeventhEmployee: "; break;
                    case 7: employeenum = "EightEmployee: "; break;
                    case 8: employeenum = "NinthEmployee: "; break;
                    case 9: employeenum = "TenthEmployee: "; break;
                    default: employeenum = "OtherEmployee: ";break;

                }
                Console.WriteLine(employeenum);
                Employee emp = new Employee();

                Console.Write("EmployeeId: ");
                emp.EmpId = Convert.ToInt32(Console.ReadLine());


                Console.Write("EmployeeName: ");
                emp.EmployeeName = Console.ReadLine();


                Console.Write("NoOfWorkingHours: ");
                emp.NoOfWorkingHours = Convert.ToInt32(Console.ReadLine());

                Console.Write("SalaryPerHour: ");
                emp.SalaryPerHour = Convert.ToInt32(Console.ReadLine());

                emp.NetSalary = emp.NoOfWorkingHours * Convert.ToInt32(emp.SalaryPerHour);

                Console.WriteLine("\nDetails Of: " + employeenum);
                Console.WriteLine("EmployeeId: " + emp.EmpId);
                Console.WriteLine("EmployeeName: " + emp.EmployeeName);
                Console.WriteLine("NoOfWorkingHours: " + emp.NoOfWorkingHours);
                Console.WriteLine("SalaryPerHour: " + emp.SalaryPerHour);
                Console.WriteLine("NetSlaray: " + emp.NetSalary);
                Console.WriteLine("NetSlaray: " + emp.NetSalary);
                Console.WriteLine("TypeOfEmployee: " + Employee.TypeOfEmployee);
                Console.WriteLine("DepartmentName: " + emp.DepartmentName);


                Console.Write("Do you want to continue? YES or No...");

                string choice = Console.ReadLine();

                if(choice == "yes" || choice == "Yes" || choice == "YES" || choice == "Y" || choice == "y")
                {
                    Console.WriteLine("---------------");
                }
                else
                { 
                    break ;
                }

            }
            Console.WriteLine("\nThank you");
            Console.ReadKey();

        }
    }
}
