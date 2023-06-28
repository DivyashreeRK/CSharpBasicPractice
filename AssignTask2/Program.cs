namespace AssignTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthdate: (yyyy-MM-dd):");
            string input = Console.ReadLine();

            DateTime birthdate;

            if(DateTime.TryParse(input, out birthdate)){

                DateTime CurrDate = DateTime.Now;

                int age = calculateAge(birthdate, CurrDate);

                Console.WriteLine(age);
            }
        }
        static int calculateAge(DateTime birthdate, DateTime CurrDate)
        {
            int age = CurrDate.Year - birthdate.Year;

            if (CurrDate < birthdate.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }
}