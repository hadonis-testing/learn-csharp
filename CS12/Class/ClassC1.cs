using CS12.Interface;

namespace CS12.Class
{
    internal class ClassC1 : IClassC
    {
        public ClassC1() => Console.WriteLine("[ClassC1] - Constructor");

        public void ActionC()
        {
            Console.WriteLine("[ClassC1] - Action C");
        }
    }
}
