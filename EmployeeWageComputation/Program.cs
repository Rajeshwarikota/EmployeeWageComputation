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
            int totalEmpHrs = 0;
            int empDailyWage = 0;
            int empMontlyWage = 0;
            int empWorkinDaysPerMonth = 20;
            //UC1- Employee Attendance
            Random random = new Random();
            for (int i = 0; i < empWorkinDaysPerMonth; i++)
            {
                int empAttendance = random.Next(0, 3);
                //UC3- Add Part Time Employee
                //UC4- Switch Case
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
                totalEmpHrs += empHrs;
            }
            //UC2- Employee Daily Wage
            //UC5- Employee Monthly Wage
            empMontlyWage = empWagePerHr * totalEmpHrs;
            Console.WriteLine("Montly Wage of Emplyoee is " + empMontlyWage);

            Console.ReadLine();
        }
    }
}
