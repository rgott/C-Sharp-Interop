using System;

namespace RGott.CSharp
{
    public class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Prints Message
        /// </summary>
        /// <param name="message">message to print</param>
        /// <returns>Language Name</returns>
        public void Run(string message)
        {
            Console.WriteLine($"{ message } -From C#");
        }
    }
}
