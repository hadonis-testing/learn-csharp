namespace CS03
{
    public delegate int Calculate(int num);

    internal class Program
    {
        static public void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Info: {message}");
            Console.ResetColor();
        }

        static public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {message}");
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            Calculate? cal = null;

            cal += (num) => num * num;
            cal += (num) => num * num * num;

            Console.WriteLine($"Value = {cal?.Invoke(2)}"); // Will print 8

            Action<string>? log2 = null;

            log2 += Info;
            log2 += Error;

            log2?.Invoke("Hi 2!");

            Calculate? cal2 = null;

            Func<int, int>? cal2 = null;

            cal2 += (num) =>
            {
                Console.WriteLine(1);
                return num * num;
            };

            cal2 += (num) =>
            {
                Console.WriteLine(2);
                return num * num * num;
            };
            cal2 += (num) =>
            {
                Console.WriteLine(3);
                return num * num * num + 1;
            };

            var a = cal2?.Invoke(6);

            Console.WriteLine($"Value = {a}");
        }
    }
}
