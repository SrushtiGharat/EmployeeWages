using System;
using System.Globalization;

namespace EmployeeWages
{
    class Program
    {   public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        public const int MONTHLY_WORKING_DAYS = 20;
        public const int MAX_WORKING_HOURS = 100;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation Program");
            ComputeWage();
        }
        public static int getEmployeeHrs()
        {
            int empHrs = 0;
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
            return totalEmpHrs;
        }
        public static void ComputeWage()
        {
            int totalEmpHrs = getEmployeeHrs();
            int empWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Working Hours :" + totalEmpHrs);
            Console.WriteLine("Monthly Employee Wage:" + empWage);

        }
    }
}
