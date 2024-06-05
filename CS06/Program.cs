namespace CS06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            try
            {
                Console.WriteLine(5 / a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
