using EmployeeWageComputation236_Day3;

class EmpWageBuilderArray
{
    public const int IS_PARTTIME = 1;
    public const int IS_FULLTIME = 2;
    CompanyEmpWage[] companies;
    int numbOfCompanies = 0;

    public EmpWageBuilderArray()
    {
        companies = new CompanyEmpWage[5];
    }

    public void AddComapnyDetailsIntoArray(string company, int empRatePerHrs, int maxWorkingDays, int maxWorkingHrs)
    {
        CompanyEmpWage comp = new CompanyEmpWage(company, empRatePerHrs, maxWorkingDays, maxWorkingHrs);
        companies[numbOfCompanies] = comp;
        numbOfCompanies++;
    }

    public void IterateOverCompany()
    {
        for (int i = 0; i < numbOfCompanies; i++)
        {
            int totalEmpWage = CalculateWages(companies[i]);
            companies[i].SetTotalWage(totalEmpWage);
            Console.WriteLine(companies[i].ToString());
        }
    }
    public int CalculateWages(CompanyEmpWage companyDetails)        
    {
        int empHrs = 0, empWage = 0, totalEmpHrs = 0, totalWorkingDays = 0, totalEmpWages = 0;   //Variables       
        Random random5 = new Random();

        while (totalEmpHrs < companyDetails.maxWorkingHrs && totalWorkingDays < companyDetails.maxWorkingDays)            
        {
            totalWorkingDays++;
            int empCheck = random5.Next(0, 3);
            switch (empCheck)
            {
                case IS_PARTTIME:
                    empHrs = 4;
                    break;
                case IS_FULLTIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = companyDetails.empRatePerHrs * empHrs;
            totalEmpHrs = totalEmpHrs + empHrs;
            totalEmpWages = totalEmpHrs * companyDetails.empRatePerHrs;

        }
        return totalEmpWages;
    }
}
namespace Computation 
{
    internal class EmployeeWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Employee Wage Computation Problem\n ");
            EmpWageBuilderArray builder = new EmpWageBuilderArray();
            builder.AddComapnyDetailsIntoArray("Google", 20, 25, 70);
            builder.AddComapnyDetailsIntoArray("DXC", 42, 30, 85);
            builder.AddComapnyDetailsIntoArray("Microsoft", 25, 55, 65);
            builder.IterateOverCompany();
        }
    }
}