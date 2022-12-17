namespace EmployeeWageComputation236_Day3
{
    class EmployeeWage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Employee Wage Computation Problem\n");
            int Is_Full_Time = 1;
            int Emp_Rate_PerHr = 20;

            int empHrs = 0;
            int empWages = 0;

            //UC2 Calculating Daily Employee Wage
            Random random = new Random();
            int Input = random.Next(0, 2);

            if (Is_Full_Time == Input)
                empHrs = 8;
            else
                empHrs = 0;
            empWages = empHrs * Emp_Rate_PerHr;
            Console.WriteLine("Employee Daily Wages are : " + empWages);
            Console.ReadLine();
        }
    }
}