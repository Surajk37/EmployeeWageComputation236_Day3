namespace EmployeeWageComputation236_Day3
{
    class EmployeeWage
    {
        public const int Absent = 0;           //Constants
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public const int Emp_Rate_PerHr = 20;
        public static int ComputeEmpWage()
        {
            //Refactor the code to write a class method
            Console.WriteLine("\t\tWelcome To Employee Wage Computation Problem\n");
         
            int empHrs = 0;                  //Variables
            //int empWages = 0;
            int totalEmpWage = 0;
            int Num_Of_Working_Days = 20;
            int Maximum_Hrs = 100;
            int totalEmp_Hrs = 0;
            int totalWorkingDays = 0;

            while(totalEmp_Hrs <= Maximum_Hrs && totalWorkingDays < Num_Of_Working_Days)
            {
                totalWorkingDays++;
                Random random = new Random();
                int Input = random.Next(0, 3);
                switch (Input)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        Console.WriteLine("Employee is Present and is Full Time");
                        break;

                    case Is_Part_Time:
                        empHrs = 4;
                        Console.WriteLine("Employee is Present and is Part Time");
                        break;

                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                totalEmp_Hrs = totalEmp_Hrs + empHrs;
                Console.WriteLine("Day : {0}", totalWorkingDays + " emp hour : " + empHrs);
            }
            Console.WriteLine("\n\t\tTotal Employee hours is : {0}", totalEmp_Hrs);

            totalEmpWage = totalEmp_Hrs * Emp_Rate_PerHr;
            Console.WriteLine("\t\tTotal employee wage : {0}", totalEmpWage);
             return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage();
            Console.ReadLine();
        }
    }
}