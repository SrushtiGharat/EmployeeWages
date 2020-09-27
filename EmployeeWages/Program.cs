using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation Program");
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            switch (empCheck)
            {
                case 0: 
                    Console.WriteLine("Employee is absent");
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

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage per day :" + empWage);
   
        }
        
    }
}
