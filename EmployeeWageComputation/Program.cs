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
            if (empAttendance == isFullTime)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;

            }
            else if (empAttendance == isPartTime)
            {
                Console.WriteLine("Employee is PartTime");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            //UC2- Employee Daily Wage
            empDailyWage = empWagePerHr * empHrs;
            Console.WriteLine("Daily Wage of Emplyoee is " + empDailyWage);

            
            Console.ReadLine();
        }
    }
}
