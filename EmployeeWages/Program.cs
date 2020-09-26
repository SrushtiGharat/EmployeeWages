using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation Program");
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            int empHrs = 0;
            int empWage = 0;
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is Present");
                empHrs = 8;
            }

            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage per day :"+empWage);

        }
    }
}
