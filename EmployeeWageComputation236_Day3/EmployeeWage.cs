namespace EmployeeWageComputation236_Day3
{
    class EmployeeWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Employee Wage Computation Problem\n");
            const int Emp_Rate_PerHr = 20;
            int empHrs = 0;
            int empWages = 0;
            int totalEmpWages = 0;
            int Num_Of_Working_Days = 20;

            //Uc5 Calculating monthly employee wages
            for (int i = 0; i < Num_Of_Working_Days; i++)
            {
                Random random = new Random();
                int Input = random.Next(0, 3);
                switch (Input)
                {
                    case 1:
                        empHrs = 8;
                        Console.WriteLine("Employee is Present and is Full Time");
                        break;

                    case 2:
                        empHrs = 4;
                        Console.WriteLine("Employee is Present and is Part Time");
                        break;

                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                empWages = empHrs * Emp_Rate_PerHr;
                totalEmpWages += empWages;
                Console.WriteLine("Daily Employee Wages are :{0}\n", empWages);
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("\t\tMonthly Wages of Employee Are : {0}", totalEmpWages);
            Console.ReadLine();
        }
    }
}