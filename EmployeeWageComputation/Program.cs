using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Program
    {
        const int isFullTime = 1;
        const int isPartTime = 2;

        public static void Main(string[] args)
        {
            Console.WriteLine("....EMP WAGE COMPUTATION....");

            //UC7-Use Class Method and Variables
            Program obj = new Program();
            obj.EmpWage("HCL", 30, 16, 60);
            obj.EmpWage("TCS", 20, 15, 80);
            obj.EmpWage("BRIDGELAB", 15, 18, 100);
            Console.ReadLine();
        }
            //UC8-Multiple companies
            void EmpWage(string company, int empWagePerHr, int empWorkinDaysPerMonth, int empTotalWorkingHrs)
            {
                int empHrs = 0;
                int totalEmpHrs = 0;
                int empMontlyWage = 0;
                int totalWorkingDays = 0;

                //UC1- Employee Attendance
                Random random = new Random();
                //UC6-MaxHrs
                while (totalWorkingDays < empWorkinDaysPerMonth && totalEmpHrs < empTotalWorkingHrs)

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
                    totalWorkingDays++;
                    totalEmpHrs += empHrs;
                }
                //UC2- Employee Daily Wage
                //UC5- Employee Monthly Wage
                empMontlyWage = empWagePerHr * totalEmpHrs;
                Console.WriteLine("Company : " + company);
                Console.WriteLine("Total Number of Hours is  " + totalEmpHrs + ", Total Number of days is " + totalWorkingDays + ", Montly Wage of Emplyoee is " + empMontlyWage);
            }
        }
    }

