using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class Company
    {
        public string companyName;
        public int empRatePerHour;
        public int noOfWorkingDays;
        public int maxWorkingHrs;
        public int totalEmpWage;

        public Company(string companyName, int empRatePerHour, int noOfWorkingDays, int maxWorkingHrs)
        {
            this.companyName = companyName;
            this.empRatePerHour = empRatePerHour;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public void print()
        {
            Console.WriteLine("Employee Wage for company " + companyName + " is " + totalEmpWage);
        }
    }
}
