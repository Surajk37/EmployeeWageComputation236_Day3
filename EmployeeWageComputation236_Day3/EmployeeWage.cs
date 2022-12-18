namespace EmployeeWageComputation236_Day3
{
    class EmployeeWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Employee Wage Computation Problem\n");
            int Emp_Rate_PerHr = 20;
            int empHrs = 0;
            int empWages = 0;

            //UC4 Calculating Employee Wage Based On Time using Swtich case
            Random random = new Random();
            int Input = random.Next(0, 3);

            switch (Input)
            {
                case 1:
                    empHrs = 8;
                    Console.WriteLine("\nEmployee is Present and He his Full Time");
                    break;

                case 2:
                    empHrs = 4;
                    Console.WriteLine("\nEmployee is Present and He his Part Time");
                    break;
                
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            empWages = empHrs * Emp_Rate_PerHr;
            Console.WriteLine("Employee Wages are : " + empWages);
            Console.ReadLine();
        }
    }
}