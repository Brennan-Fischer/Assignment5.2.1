namespace Assignment5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a series of words and this program will return the length of the last word");
            string userInput=Console.ReadLine();
            userInput = userInput.Trim();
            int endIndex=userInput.Length;
            int startIndex = 0;

             
            for (int i = userInput.Length-1; i >= 0; i--)
            {
                if (userInput[i] == ' ')
                {
                    startIndex = i + 1;
                    break;
                }
            }
            Console.WriteLine($"Lenth of last word in string is {endIndex + 1 - startIndex}");

        }

    }
}
