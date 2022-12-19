namespace EmpWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day;

            //UC-1 Check employee present or not
            Random random = new Random();
            for ( day=1; day <= MAX_WORKING_DAYS; day++)
            {
                int employeeInput = random.Next(0, 3);
                //UC4 using Switch case
                switch (employeeInput)
                {
                    case 1:
                 //Console.WriteLine("FullTime Employee is Present");
                        empHrs = 8;
                        break;
                    case 2:

                     // Console.WriteLine("PartTime Employee is Present");
                        empHrs = 4;
                        break;
                    default:
                     // Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;
                }
                //UC-2 & UC-3 calculate Employee Wage
                empWage = EMP_RATE_PER_HR * empHrs;
                totalWage = totalWage + empWage;
                Console.WriteLine("Employee wage is :" + empWage);
            }
            //UC5 total wage for 20 days
            Console.WriteLine("TotalWage Wage for {0} days:{1}", (day - 1), totalWage);

           
        }
    }
}