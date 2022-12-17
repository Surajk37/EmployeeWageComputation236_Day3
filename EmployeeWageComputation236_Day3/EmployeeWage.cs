namespace EmployeeWageComputation236_Day3
{
    class EmployeeWage
    {
        static void Main(string[] args)
        {
            const int IS_PRESENT = 0;
            Console.WriteLine("\t\tWelcome To Employee Wage Computation Problem\n");

            //UC1 Check employee is present or absent
            Random random = new Random();
            int Input = random.Next(0, 2);

            if (IS_PRESENT == Input)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
            Console.ReadLine();
        }
    }
}