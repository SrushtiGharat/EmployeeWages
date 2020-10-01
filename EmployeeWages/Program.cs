
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Serialization;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation Program");
            EmployeeWageBuilder empWageBuilder = new EmployeeWageBuilder();
            empWageBuilder.AddCompany("D-Mart", 20, 30, 100);
            empWageBuilder.AddCompany("Big Bazaar", 10, 20, 80);
            empWageBuilder.ComputeWage();
        }
    
    }
}
