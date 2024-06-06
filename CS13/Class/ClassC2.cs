using CS13.Interface;

namespace CS13.Class
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
