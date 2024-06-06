namespace CS11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClassC c = new ClassC();
            IClassB b = new ClassB(c);
            ClassA a = new ClassA(b);

            a.ActionA();
        }
    }
}
