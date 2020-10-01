using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmployeeWageBuilder
    {
        public const int IS_FULL_TIME = 2;
        public const int IS_PART_TIME = 1;

        List<Company> companyList;

        public EmployeeWageBuilder()
        {
            companyList = new List<Company>();
        }

        public void AddCompany(string companyName, int empRatePerHour, int noOfWorkingDays, int maxWorkingHrs)
        {
            Company c = new Company(companyName, empRatePerHour, noOfWorkingDays, maxWorkingHrs);
            companyList.Add(c);
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
            for (int i = 0; i < companyList.Count; i++)
            {
                companyList[i].setTotalEmpWage(ComputeWage(companyList[i]));
            }
        }
        public int ComputeWage(Company company)
        {
            int i = 0;
            int totalEmpHrs = 0;
            int empHr = 0;

            while (i < company.noOfWorkingDays && totalEmpHrs < company.maxWorkingHrs)
            {
                empHr = GetEmployeeHrs();
                totalEmpHrs = totalEmpHrs + empHr;
                int dailyWage = empHr * company.empRatePerHour;
                i++;
            }
            int empWage = totalEmpHrs * company.empRatePerHour;
            Console.WriteLine("Total Employee Hrs :" + totalEmpHrs);
            Console.WriteLine("Employee Wage for company " + company.companyName + " is " + empWage);
            return empWage;
        }
    }
}
