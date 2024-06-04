namespace CS04
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput u = new();

            TinhCan can = new();
            can.Sub(u);

            u.Input();
        }
    }
}
