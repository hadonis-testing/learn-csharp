using CS13.Interface;

namespace CS13.Class
{
    internal class ClassB1 : IClassB
    {
        private IClassC _classC;

        public ClassB1(IClassC classC)
        {
            _classC = classC;

            Console.WriteLine("[ClassB1] - Constructor");
        }

        public void ActionB()
        {
            Console.WriteLine("[ClassB1] - Action B");

            _classC.ActionC();
        }
    }
}
