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

    }
    class EmployeeWageBuilder
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;
        int noOfCompanies = 0;

        Company[] companyList;

        public EmployeeWageBuilder()
        {
            companyList = new Company[5];
        }

        public void AddCompany(string companyName, int empRatePerHour, int noOfWorkingDays, int maxWorkingHrs)
        {
            companyList[noOfCompanies] = new Company(companyName, empRatePerHour, noOfWorkingDays, maxWorkingHrs);
            noOfCompanies++;
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
            for (int i = 0; i < noOfCompanies; i++)
            {
                companyList[i].setTotalEmpWage(ComputeWage(companyList[i]));

            }
        }
        public int ComputeWage(Company company)
        {
            int i = 0;
            int totalEmpHrs = 0;

            while (i < company.noOfWorkingDays && totalEmpHrs < company.maxWorkingHrs)
            {
                totalEmpHrs = totalEmpHrs + GetEmployeeHrs();
                i++;
            }
            int empWage = totalEmpHrs * company.empRatePerHour;
            Console.WriteLine("Total Employee Hrs :" + totalEmpHrs);
            Console.WriteLine("Employee Wage for company " + company.companyName + " is " + empWage);
            return empWage;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation Program");
            
            EmployeeWageBuilder empWageBuilder = new EmployeeWageBuilder();
            empWageBuilder.AddCompany("D-Mart", 20, 30, 100);
            empWageBuilder.AddCompany("Walmart", 10, 20, 80);
            empWageBuilder.ComputeWage();

        }

    }
}
