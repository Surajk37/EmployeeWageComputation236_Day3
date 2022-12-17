namespace EmployeeWageComputation236_Day3
{
    class EmployeeWage
    {
        static void Main(string[] args)
        {
            const int Is_Full_Time = 0;
            const int Is_Part_Time = 1;
            Console.WriteLine("\t\tWelcome To Employee Wage Computation Problem\n");
            int Emp_Rate_PerHr = 20;
            int empHrs = 0;
            int empWages = 0;

            //UC3 Calculating Employee Wage Based On Time
            Random random = new Random();
            int Input = random.Next(0, 3);

            if (Is_Full_Time == Input)
            {
                empHrs = 8;
                Console.WriteLine("\nEmployee is Present and He his Full Time");

            }
            else if (Is_Part_Time == Input)
            {
                empHrs = 4;

                Console.WriteLine("\nEmployee is Present and He his Part Time");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
                empWages = empHrs * Emp_Rate_PerHr;
            Console.WriteLine("Employee Wages are : " + empWages);
            Console.ReadLine();
        }
    }
}