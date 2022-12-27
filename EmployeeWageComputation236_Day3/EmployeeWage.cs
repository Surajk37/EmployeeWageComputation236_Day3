namespace EmployeeWageComputation236_Day3
{
    class EmployeeWage
    {
        public const int Absent = 0;           //Constants
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public static void ComputeEmpWage(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            //Compute Employee Wage for multiple compaines.
 
            int empHrs = 0;                  //Variables
            int total_Emp_Wage = 0;
            int totalWorkingDays = 1;
            int total_Emp_Hrs = 0;
            int daily_Emp_Wage = 0;

            Random random = new Random();
            while (totalWorkingDays <= working_Days_Per_Month && total_Emp_Hrs <= max_Hrs_Per_Month)
            {
                int randomInput = random.Next(0, 3);
                switch (randomInput)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                daily_Emp_Wage = empHrs * emp_Wage_Per_Hr;
                Console.WriteLine("Employee wage for day {0} is: {1} for {2} Hrs", totalWorkingDays, daily_Emp_Wage, empHrs);
                total_Emp_Wage += daily_Emp_Wage;
                total_Emp_Hrs += empHrs;
                totalWorkingDays++;
            }
            Console.WriteLine("Total Days: {0}, Total working hours: {1}", (totalWorkingDays - 1), total_Emp_Hrs);
            Console.WriteLine("Total Employee Wage is: " + total_Emp_Wage + "\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Employee Wage Computation Problem\n");
            EmployeeWage.ComputeEmpWage("Google", 20, 2, 10);
            EmployeeWage.ComputeEmpWage("Microsoft", 10, 4, 20);
            EmployeeWage.ComputeEmpWage("Deloitte", 15, 3, 15);
            Console.ReadLine();
        }
    }
}