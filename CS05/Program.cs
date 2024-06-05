using System.Drawing;
using System.Runtime.CompilerServices;

namespace CS05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Extension Method";

            str.PrintWithColor(ConsoleColor.Green);

            "Xin chao moi nguoi".PrintWithColor(ConsoleColor.Blue);
        }
    }
}
