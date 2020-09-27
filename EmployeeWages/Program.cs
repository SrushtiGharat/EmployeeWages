using System;
using System.Globalization;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation Program");
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int MONTHLY_WORKING_DAYS = 20;
            int MAX_WORKING_HOURS = 100;
            int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            int empWage = 0;
            int totalEmpHrs = 0;
            int i = 0;
           
            Random random = new Random();

            while (i < MONTHLY_WORKING_DAYS && totalEmpHrs < MAX_WORKING_HOURS)
            {
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case 0:
                        Console.WriteLine("Employee is absent");
                        empHrs = 0;
                        break;
                    case 1:
                        Console.WriteLine("Employee is present part-time");
                        empHrs = 4;
                        break;
                    case 2:
                        Console.WriteLine("Employee is present full-time");
                        empHrs = 8;
                        break;
                    default:
                        Console.WriteLine("No such Employee");
                        break;
                }
                i++;
                totalEmpHrs = totalEmpHrs + empHrs;
            }
            empWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Working Hours :" + totalEmpHrs);
            Console.WriteLine("Monthly Employee Wage:" + empWage);

        }
    }
}
