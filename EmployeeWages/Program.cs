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

            if(empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present full-time");
                empHrs = 8;
                
            }
            else if(empCheck == IS_PART_TIME)
            {
                Console.WriteLine("Employee is present part-time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage per day :" + empWage);
   
        }
        
    }
}
