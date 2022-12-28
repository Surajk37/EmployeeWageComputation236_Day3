namespace EmployeeWageComputation236_Day3
{
    public class EmpWageBuilder
    {
        String company;
        int emprateperhr;
        int noofworkingdays;
        int maxhrinmonth;
        public EmpWageBuilder(String company, int emprateperhr, int noofworkingdays, int maxhrinmonth)
        {
            this.company = company;
            this.emprateperhr = emprateperhr;
            this.noofworkingdays = noofworkingdays;
            this.maxhrinmonth = maxhrinmonth;
        }

        public void ComputeEmpwage()
        {
            const int isft = 1;
            const int ispt = 0;
            int totalwage = 0;
            int emphr = 0;
            int totalemphr = 0;
            int workingdays = 0;

            while (totalemphr <= maxhrinmonth && workingdays < noofworkingdays)
            {
                workingdays++;
                Random ran = new Random();
                int empcheck = ran.Next(0, 3);
                switch (empcheck)
                {
                    case isft:
                        emphr = 8;
                        break;
                    case ispt:
                        emphr = 4;
                        break;
                    default:
                        emphr = 0;
                        break;
                }
                totalemphr += emphr;
                Console.WriteLine("Days:" + workingdays + "  Emp Hours:" + totalemphr);
            }
            totalwage = totalemphr * emprateperhr;
            Console.WriteLine("Total Wage For Company:" + company + " is " + totalwage);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome To Employee Wage Computation Problem\n");
            EmpWageBuilder ob1 = new EmpWageBuilder("Wipro", 230, 26, 208);
            ob1.ComputeEmpwage();
            Console.WriteLine("----------------------------------------------------------------------------------------");
            EmpWageBuilder ob2 = new EmpWageBuilder("Infosys", 240, 27, 216);
            ob2.ComputeEmpwage();
            Console.ReadLine();
        }
    }
}