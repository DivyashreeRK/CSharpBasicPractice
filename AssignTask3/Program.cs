
namespace AssignTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a name:");
            string input = Console.ReadLine();

            for(int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }

        }
    }
}