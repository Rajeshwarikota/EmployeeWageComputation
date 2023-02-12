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
            int empWagePerHr = 20;
            int empHrs = 0;
            int empDailyWage = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Problem");
            //UC1- Employee Attendance
            Random random = new Random();
            int empAttendance = random.Next(0, 2);

            if (empAttendance == isFullTime)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;

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
