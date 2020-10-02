using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation Program");
            
            EmployeeWageBuilder empWageBuilder = new EmployeeWageBuilder();
            empWageBuilder.AddCompany("D-Mart", 20, 30, 100);
            empWageBuilder.AddCompany("Walmart", 10, 20, 80);
            empWageBuilder.ComputeWage();

            Console.WriteLine("Enter the company name to find Employee Wage");
            string companyName = Console.ReadLine();
            Console.WriteLine("The total Employee Wage for "+companyName+" is "+ empWageBuilder.getTotalWageByCompany(companyName));

        }

    }
}
