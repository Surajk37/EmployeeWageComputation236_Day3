using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation236_Day3
{
    class CompanyEmpWage
    {
        public string company;
        public int empRatePerHrs, maxWorkingDays, maxWorkingHrs, totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHrs, int maxWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHrs = empRatePerHrs;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }

        public void SetTotalWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public  string ToString()
        {
            return $"Company Name:{company} \t\tRatePerHr:{empRatePerHrs}  \t\tHrs:{maxWorkingHrs} \t\tDays:{maxWorkingDays}";
        }
    }
}
