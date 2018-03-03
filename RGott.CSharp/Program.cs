using System;

namespace RGott.CSharp
{
    public class Program
    {
        /// <summary>
        /// Prints Message
        /// </summary>
        /// <param name="message">message to print</param>
        /// <returns>Language Name</returns>
        public string Run(string message)
        {
            Console.WriteLine($"{ message } -From C#");
            return "C#";
        }
    }
}
