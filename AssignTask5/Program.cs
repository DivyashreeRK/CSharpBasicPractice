namespace AssignTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string: ");
            string Text = Console.ReadLine();

            Console.WriteLine("Enter the text you want to insert: ");
            string InsertText = Console.ReadLine();

            int insertPos = Text.IndexOf("___");

           if(insertPos >= 0)
            {
                string modifiedStr = Text.Remove(insertPos,3).Insert(insertPos, InsertText);

                Console.WriteLine(modifiedStr);
           }
        }
    }
}