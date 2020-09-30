
using System;
using System.Globalization;

namespace EmployeeWages
{
    class EmployeeWageBuilder
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        
        String companyName;
        int empRatePerHour;
        int noOfWorkingDays;
        int maxWorkingHrs;
        public EmployeeWageBuilder(String companyName,int empRatePerHour,int noOfWorkingDays,int maxWorkingHrs)
        {
            this.companyName = companyName;
            this.empRatePerHour = empRatePerHour;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        public int GetEmployeeHrs()
        {
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case 0:
                    empHrs = 0;
                    break;
                case 1:
                    empHrs = 4;
                    break;
                case 2:
                    empHrs = 8;
                    break;
                default:
                    Console.WriteLine("No such Employee");
                    empHrs = 0;
                    break;
            }
            return empHrs;
        }
        public void ComputeWage()
        {
            int i = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (i < noOfWorkingDays && totalEmpHrs <= maxWorkingHrs)
            {
                totalEmpHrs = totalEmpHrs + GetEmployeeHrs();
                i++;
            }
            double empWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employee Hrs :" + totalEmpHrs);
            Console.WriteLine("Employee Wage for company " + companyName + " is " + empWage);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation Program");
            EmployeeWageBuilder dMart = new EmployeeWageBuilder("DMart", 20, 25, 100);
            EmployeeWageBuilder bigBazaar = new EmployeeWageBuilder("Big Bazaar", 10, 20, 80);
            dMart.ComputeWage();
            bigBazaar.ComputeWage();
        }
       
        
        
    }
}
