namespace CS16
{
    internal class Program
    {
        public static IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }

        static void Main(string[] args)
        {
            foreach (int i in GetNumbers()) Console.WriteLine(i);
        }
    }
}
