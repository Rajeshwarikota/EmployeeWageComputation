using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....EMP WAGE COMPUTATION....");
            const int isFullTime = 1;
            const int isPartTime = 2;
            int empWagePerHr = 20;
            int empHrs = 0;
            int empDailyWage = 0;
            //UC1- Employee Attendance
            Random random = new Random();
            int empAttendance = random.Next(0, 3);
            //UC3-Add Part Time Employee
            //UC4-Using switch case
            switch (empAttendance)
            {
                case isFullTime:
                    Console.WriteLine("Employee is FullTime");
                    empHrs = 8;
                    break;
                case isPartTime:
                    Console.WriteLine("Employee is PartTime");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            //UC2- Employee Daily Wage
            empDailyWage = empWagePerHr * empHrs;
            Console.WriteLine("Daily Wage of Emplyoee is " + empDailyWage);

            
            Console.ReadLine();
        }
    }
}
