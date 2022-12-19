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
            int empHrs = 0;
            int empWage = 0;

            //UC-1 Check employee present or not
            Random random = new Random();
            int employeeInput = random.Next(0, 3);
            switch (employeeInput) //UC4 using Switch case
            {
                case 1:
                    Console.WriteLine("FullTime Employee is Present");
                    empHrs = 8;
                    break;
                case 2:

                    Console.WriteLine("PartTime Employee is Present");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;
            }

            //UC-2 & UC-3 calculate Employee Wage
            empWage = EMP_RATE_PER_HR*empHrs;
            Console.WriteLine("Employee wage is :" + empWage);
        }
    }
}