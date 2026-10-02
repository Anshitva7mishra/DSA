using System;
namespace TreeDataStructure
{
    public class ConsoleTreeIO : ITreeIO
    {
        public int GetIntInput(string prompt)
        {
            Console.Write(prompt);
            while(true)
            {
                if(int.TryParse(Console.ReadLine(), out int result))
                 return result;
                Console.Write("Invalid input. Please enter an integer: ");
            }
        }

        public void Output(string message)
        {
            Console.Write(message + " ");
        }
    }
}