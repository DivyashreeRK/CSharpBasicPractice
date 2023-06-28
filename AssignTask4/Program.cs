namespace AssignTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text:");
            string line = Console.ReadLine();

            Console.WriteLine("Enter a word to search:");
            string word = Console.ReadLine();

            bool found = SearchWord(line, word);

            if (found)
            {
                Console.WriteLine("The word {0} found in the line.", word);
            }
            else
            {
                Console.WriteLine("The word {0} not found in the line.", word);
            }

        }

        static bool SearchWord(string line,string word)
        {
             string[] WordArray  = line.Split(' ');

             foreach(string w in WordArray)
            {
                if (string.Equals(w, word, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}