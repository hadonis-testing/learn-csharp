
namespace CS08
{
    internal class Program
    {
        public static void DoSomeThing(int seconds, string msg, ConsoleColor color)
        {
            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{msg,10} ... Start");
                Console.ResetColor();
            }

            for (int i = 0; i < seconds; i++)
            {
                lock (Console.Out)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine($"{msg,10} {i,2}");
                    Console.ResetColor();
                }

                Thread.Sleep(500);
            }

            lock (Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{msg,10} ... End");
                Console.ResetColor();
            }
        }

        public static async Task Task2()
        {
            Task t2 = new(() =>
            {
                DoSomeThing(10, "T2", ConsoleColor.Red);
            });

            t2.Start();

            await t2;

            Console.WriteLine("Task2 completed");
        }

        public static async Task Task3()
        {
            Task t3 = new((object? obj) =>
            {
                DoSomeThing(5, obj == null ? "T3" : (string)obj, ConsoleColor.Green);
            },
            "T3");

            t3.Start();

            await t3;

            Console.WriteLine("Task3 completed");
        }

        public static async Task Main(string[] args)
        {
            Task t2 = Task2();
            Task t3 = Task3();

            DoSomeThing(6, "T1", ConsoleColor.Magenta);

            //t2.Wait();
            //t3.Wait();
            //Task.WaitAll(t2, t3);

            await t2;
            await t3;

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
