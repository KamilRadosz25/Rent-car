using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class ColorChanger
    {
 
        public static void MainColor(string sentence)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(sentence);
            Console.ResetColor();
        }
        public static void OptionColor(string sentence)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(sentence);
            Console.ResetColor();

        }
        public static void AcceptColor(string sentence)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(sentence);
            Console.ResetColor();

        }
        public static void DeclineColor(string sentence)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(sentence);
            Console.ResetColor();
        }
    }
}
