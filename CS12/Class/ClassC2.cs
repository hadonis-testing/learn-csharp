using CS12.Interface;

namespace CS12.Class
{
    internal class ClassC2 : IClassC
    {
        public ClassC2() => Console.WriteLine("[ClassC2] - Constructor");

        public void ActionC()
        {
            Console.WriteLine("[ClassC2] - Action C");
        }
    }
}
