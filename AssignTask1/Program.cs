namespace AssignTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime CurrDateTime = DateTime.Now;
            string formattedDateTime = CurrDateTime.ToString("yyyy-MM-dd HH:mm");
            Console.WriteLine(formattedDateTime);
        }
    }
}