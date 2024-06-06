using CS14.Interface;

namespace CS14.Class
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
