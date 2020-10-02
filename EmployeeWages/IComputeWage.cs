using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    interface IComputeWage
    {
        public void AddCompany(string companyName, int empRatePerHour, int noOfWorkingDays, int maxWorkingHrs);
        public int getTotalWageByCompany(string companyName);
        public int GetEmployeeHrs();
        public void ComputeWage();
    }
}
